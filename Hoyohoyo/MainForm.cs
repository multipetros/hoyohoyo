/* Hoyohoyo: Main form
 * (c) 2018, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO ;
using System.Diagnostics ;
using System.Resources;
using System.Globalization;
using System.Media ;
using Multipetros.Config;

namespace Hoyohoyo{
	public partial class MainForm : Form{
		//constant strings representing registry setting key names
		private readonly string WND_TOP = "top" ;
		private readonly string WND_LEFT = "left" ;
		private readonly string WND_WIDTH = "width" ;
		private readonly string WND_HEIGHT = "height" ;
		private readonly string WND_FONT = "font" ;
		private readonly string WND_BG_COLOR = "bgcolor" ;
		private readonly string WND_COLOR = "color" ;
		private readonly string WND_LANG = "lang" ;
		private readonly string WND_MUTE = "mute" ;
		
		//default window meassurements
		private readonly int DEFAULT_TOP = 100 ;
		private readonly int DEFAULT_LEFT = 100 ;
		private readonly int DEFAULT_WIDTH = 600 ;
		private readonly int DEFAULT_HEIGHT = 400 ;
		
		//available language resources
		private readonly string[] AVAILABLE_LANGS = new string[]{"en","el"} ;
		private readonly int LANG_EN = 0 ;
		private readonly int LANG_EL = 1 ;
		
		//sound files
		private readonly string SND_TAKEOWN = "snd/stage1.wav" ;
		private readonly string SND_ICACLS = "snd/stage2.wav" ;
		private readonly string SND_DONE = "snd/done.wav" ;
		
		//constant strings representing resources keys
		private readonly string RES_BUTTON_SELECT = "BUTTON_SELECT" ;
		private readonly string RES_BUTTON_START = "BUTTON_START" ;
		private readonly string RES_MENU_SELECT = "MENU_SELECT" ;
		private readonly string RES_MENU_START = "MENU_START" ;
		private readonly string RES_MENU_ABOUT = "MENU_ABOUT" ;
		private readonly string RES_MENU_HELP = "MENU_HELP" ;
		private readonly string RES_MENU_FILE = "MENU_FILE" ;
		private readonly string RES_MENU_EXIT = "MENU_EXIT" ;
		private readonly string RES_MENU_SETTINGS = "MENU_SETTINGS" ;
		private readonly string RES_MENU_FONT = "MENU_FONT" ;
		private readonly string RES_MENU_BGCOLOR = "MENU_BGCOLOR" ;
		private readonly string RES_MENU_LANGUANGE = "MENU_LANGUANGE" ;
		private readonly string RES_MSG_FOLDER_NOT_EXIST_ERROR = "MSG_FOLDER_NOT_EXIST_ERROR" ;
		private readonly string RES_MSG_TITLE_ERROR = "MSG_TITLE_ERROR" ;
		private readonly string RES_MSG_TITLE_ABOUT = "MSG_TITLE_ABOUT" ;
		private readonly string RES_MSG_ABOUT = "MSG_ABOUT" ;
		private readonly string RES_MENU_MUTE = "MENU_MUTE" ;
		
		//init vars
		private ResourceManager resmgr ;
		private CultureInfo ci ;
		private RegistryIni ini = new RegistryIni(Application.CompanyName, Application.ProductName) ;
		private SoundPlayer player ;
		
		public MainForm(){
			InitializeComponent();
			resmgr = new ResourceManager(typeof(MainForm)) ;
		}
		
		//import kernel func to determinate system console codepage
		[System.Runtime.InteropServices.DllImport("kernel32.dll")]
		public static extern int GetSystemDefaultLCID();
		
		private int GetConsoleCodepage(){
			int lcid = GetSystemDefaultLCID();
			System.Globalization.CultureInfo sysCulture = System.Globalization.CultureInfo.GetCultureInfo(lcid);
			return sysCulture.TextInfo.OEMCodePage;			
		}
		
		private string GetRes(string key){
			return resmgr.GetString(key, ci) ;
		}
		
		private void LoadRes(){
			buttonSelect.Text = GetRes(RES_BUTTON_SELECT) ;
			buttonStart.Text = GetRes(RES_BUTTON_START) ;
			fileToolStripMenuItem.Text = GetRes(RES_MENU_FILE) ;
			selectFolderToolStripMenuItem.Text = GetRes(RES_MENU_SELECT) ;
			startToolStripMenuItem.Text = GetRes(RES_MENU_START) ;
			exitToolStripMenuItem.Text = GetRes(RES_MENU_EXIT) ;
			languangeToolStripMenuItem.Text = GetRes(RES_MENU_LANGUANGE) ;
			helpToolStripMenuItem.Text = GetRes(RES_MENU_HELP) ;
			aboutToolStripMenuItem.Text = GetRes(RES_MENU_ABOUT) ;
			settingsToolStripMenuItem.Text = GetRes(RES_MENU_SETTINGS) ;
			fontToolStripMenuItem.Text = GetRes(RES_MENU_FONT) ;
			backroundToolStripMenuItem.Text = GetRes(RES_MENU_BGCOLOR) ;
			muteToolStripMenuItem.Text = GetRes(RES_MENU_MUTE) ;
		}
		
		private void StartTakeownProc(){
			if(!muteToolStripMenuItem.Checked && File.Exists(SND_TAKEOWN)){
				player = new SoundPlayer(SND_TAKEOWN) ;
				player.Play() ;
			}
			textBoxOutput.Clear() ;
			if(Directory.Exists(textBoxFolder.Text)){
				Process takeown = new Process() ;	
				takeown.StartInfo.FileName = "TAKEOWN.EXE" ;
				takeown.StartInfo.Arguments = "/F \"" + textBoxFolder.Text + "\" /R /D Y" ;
				takeown.StartInfo.RedirectStandardOutput = true ;
				takeown.StartInfo.CreateNoWindow = true ;
				takeown.StartInfo.UseShellExecute = false ;
				takeown.EnableRaisingEvents = true ;
				takeown.OutputDataReceived += new DataReceivedEventHandler(Cmd_OutputDataReceived);
				takeown.Exited += new EventHandler(Takeown_Exited);
				takeown.StartInfo.StandardOutputEncoding = System.Text.Encoding.GetEncoding(GetConsoleCodepage()) ;
				takeown.Start() ;
				takeown.BeginOutputReadLine() ;
			}else{
				MessageBox.Show(GetRes(RES_MSG_FOLDER_NOT_EXIST_ERROR), GetRes(RES_MSG_TITLE_ERROR), MessageBoxButtons.OK, MessageBoxIcon.Error) ;
			}			
		}
		
		private void StartIcaclsProc(){
			if(!muteToolStripMenuItem.Checked && File.Exists(SND_ICACLS)){
				player = new SoundPlayer(SND_ICACLS) ;
				player.Play() ;
			}
			Process icacls = new Process() ;
			icacls.StartInfo.FileName = "ICACLS.EXE" ;
			icacls.StartInfo.Arguments = "\"" +  textBoxFolder.Text + "\" /reset /T" ;
			icacls.StartInfo.RedirectStandardOutput = true ;
			icacls.StartInfo.CreateNoWindow = true ;
			icacls.StartInfo.UseShellExecute = false ;
			icacls.EnableRaisingEvents = true ;
			icacls.OutputDataReceived += new DataReceivedEventHandler(Cmd_OutputDataReceived);
			icacls.Exited += new EventHandler(Icacls_Exited);
			icacls.StartInfo.StandardOutputEncoding = System.Text.Encoding.GetEncoding(GetConsoleCodepage()) ;
			icacls.Start() ;
			icacls.BeginOutputReadLine() ;
		}		

		//update textbox with console output
		void Cmd_OutputDataReceived(object sender, DataReceivedEventArgs e){
			if(textBoxOutput.InvokeRequired && !String.IsNullOrEmpty(e.Data)){
				textBoxOutput.Invoke(new MethodInvoker(delegate() { textBoxOutput.AppendText(e.Data+"\r\n") ; } ));
			}
		}

		//when takeown proc ends
		void Takeown_Exited(object sender, EventArgs e){
			StartIcaclsProc() ;
		}
		
		//when icalcls proc ends
		void Icacls_Exited(object sender, EventArgs e){
			if(!muteToolStripMenuItem.Checked){
				if(File.Exists(SND_DONE)){
					player = new SoundPlayer(SND_DONE) ;
					player.Play() ;
				}else{
					SystemSounds.Asterisk.Play() ;
				}
			}
		}
		
		private void SelectFolder(){
			DialogResult searchDialod = folderBrowserDialogSearch.ShowDialog() ;
			if(searchDialod == DialogResult.OK){
				textBoxFolder.Text = folderBrowserDialogSearch.SelectedPath ;
			}
		}
		
		void TableLayoutPanel1Paint(object sender, PaintEventArgs e){
			tableLayoutPanel1.ColumnStyles[0].Width = buttonSelect.Width + 10 ;
			tableLayoutPanel1.ColumnStyles[2].Width = buttonStart.Width + 10 ;
			tableLayoutPanel1.RowStyles[1].Height = buttonSelect.Height + 10 ;
		}
		
		void ButtonSelectClick(object sender, EventArgs e){
			SelectFolder() ;
		}		
		
		void SelectFolderToolStripMenuItemClick(object sender, EventArgs e){
			SelectFolder() ;
		}
		
		void ButtonStartClick(object sender, EventArgs e){
			StartTakeownProc() ;
		}
		
		void StartToolStripMenuItemClick(object sender, EventArgs e){
			StartTakeownProc() ;
		}
		
		//when something dragged over the textbox, check if is folder and allow or not the dragging
		void TextBoxFolderDragEnter(object sender, DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy ;
			else
				e.Effect = DragDropEffects.None ;
		}
		
		//if folder dropped and  exist add its path to the textbox
		void TextBoxFolderDragDrop(object sender, DragEventArgs e){
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			if(Directory.Exists(files[files.Length-1])){
				textBoxFolder.Text = files[files.Length-1] ;
			}
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit() ;
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			MessageBox.Show(GetRes(RES_MSG_ABOUT), GetRes(RES_MSG_TITLE_ABOUT), MessageBoxButtons.OK, MessageBoxIcon.Information) ;
		}
		
		void GreekToolStripMenuItemClick(object sender, EventArgs e){
			ci = new CultureInfo(AVAILABLE_LANGS[LANG_EL]) ;
			LoadRes() ;
		}
		
		void EnglishToolStripMenuItemClick(object sender, EventArgs e){
			ci = new CultureInfo(AVAILABLE_LANGS[LANG_EN]) ;
			LoadRes() ;
		}
		
		void MainFormLoad(object sender, EventArgs e){
			//load ini params and use them to init sizes, languanges, etc.
			int left ;
			int.TryParse(ini[WND_LEFT], out left) ;
			this.Left = left > 0 ? left : DEFAULT_LEFT ;
			
			int top ;
			int.TryParse(ini[WND_TOP], out top) ;
			this.Top = top > 0 ? top : DEFAULT_TOP ;
			
			int width ;
			int.TryParse(ini[WND_WIDTH], out width) ;
			this.Width = width > 0 ? width : DEFAULT_WIDTH ;
			
			int height ;
			int.TryParse(ini[WND_HEIGHT], out height) ;
			this.Height = height > 0 ? height : DEFAULT_HEIGHT ;
			
			string lang = ini[WND_LANG] ;
			if(lang != "" && (Array.IndexOf(AVAILABLE_LANGS, lang) >= 0)){
				ci = new CultureInfo(lang) ;
			}else{
				lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName ;
				if(Array.IndexOf(AVAILABLE_LANGS, lang) > -1){
					ci = CultureInfo.CurrentCulture ;
				}else{
					lang = AVAILABLE_LANGS[LANG_EN] ;
					ci = new CultureInfo(lang) ;
				}
			}			
			LoadRes() ;
			
			bool mute ;
			bool.TryParse(ini[WND_MUTE], out mute) ;
			muteToolStripMenuItem.Checked = mute ;
			
			//load font 'serialized' string and convert it into a Font object, via the FontConverter class
			string fontStr = ini[WND_FONT] ;
			if(fontStr != ""){
				FontConverter fontCon = new FontConverter() ;
				try{
					Font fontObj = (Font)fontCon.ConvertFromString(fontStr) ;
					textBoxOutput.Font = fontObj ;
				}catch(Exception){ }			
			}
			
			//load text fore color 'serialized' string and convert it into a Color struct, via the ColorConverter class
			string colorStr = ini[WND_COLOR] ;
			if(colorStr != ""){
				ColorConverter colorCon = new ColorConverter() ;
				try {
					Color color = (Color)colorCon.ConvertFromString(colorStr) ;
					textBoxOutput.ForeColor = color ;
				} catch (Exception) { }
			}
			
			//load text background color 'serialized' string and convert it into a Color struct, via the ColorConverter class
			string bgColorStr = ini[WND_BG_COLOR] ;
			if(bgColorStr != ""){
				ColorConverter colorCon = new ColorConverter() ;
				try {
					Color bgcolor = (Color)colorCon.ConvertFromString(bgColorStr) ;
					textBoxOutput.BackColor = bgcolor ;
				} catch (Exception) { }
			}
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e){
			//store sizes, language & settings to ini
			ini[WND_LEFT] = this.Left.ToString() ;
			ini[WND_TOP] = this.Top.ToString() ;
			ini[WND_WIDTH] = this.Width.ToString() ;
			ini[WND_HEIGHT] = this.Height.ToString() ;
			ini[WND_LANG] = ci.TwoLetterISOLanguageName ;
			ini[WND_MUTE] = muteToolStripMenuItem.Checked.ToString() ;
			
			//use FontConverter call to 'serialize' the current Font object into string
			FontConverter fontCon = new FontConverter() ;
			ini[WND_FONT] = fontCon.ConvertToString(textBoxOutput.Font) ;
			
			//use ColorConverter call to 'serialize' the current Color struct into string
			ColorConverter colorCon = new ColorConverter() ;
			ini[WND_COLOR] = colorCon.ConvertToString(textBoxOutput.ForeColor) ;
			ini[WND_BG_COLOR] = colorCon.ConvertToString(textBoxOutput.BackColor) ;
		}
		
		void FontToolStripMenuItemClick(object sender, EventArgs e){
			fontDialogSettings.Font = textBoxOutput.Font ;
			fontDialogSettings.Color = textBoxOutput.ForeColor ;
			DialogResult result = DialogResult.Abort ;
			try{
				result = fontDialogSettings.ShowDialog() ;
			}catch(Exception err) {
				MessageBox.Show(err.Message, GetRes(RES_MSG_TITLE_ERROR), MessageBoxButtons.OK, MessageBoxIcon.Error) ;
			}
			if(result == DialogResult.OK){
				textBoxOutput.Font = fontDialogSettings.Font ;	
				textBoxOutput.ForeColor = fontDialogSettings.Color ;
			}
		}
		
		void BackroundToolStripMenuItemClick(object sender, EventArgs e){
			colorDialogSettings.Color = textBoxOutput.BackColor ;
			DialogResult result = colorDialogSettings.ShowDialog() ;
			if(result == DialogResult.OK){
				textBoxOutput.BackColor = colorDialogSettings.Color ;
			}
		}
		
		void MuteToolStripMenuItemClick(object sender, EventArgs e){
			muteToolStripMenuItem.Checked = !muteToolStripMenuItem.Checked ;
		}
	}
}
