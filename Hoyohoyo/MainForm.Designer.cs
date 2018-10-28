/* Hoyohoyo: Main form Designer
 * (c) 2018, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
namespace Hoyohoyo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonSelect = new System.Windows.Forms.Button();
			this.textBoxFolder = new System.Windows.Forms.TextBox();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.folderBrowserDialogSearch = new System.Windows.Forms.FolderBrowserDialog();
			this.colorDialogSettings = new System.Windows.Forms.ColorDialog();
			this.fontDialogSettings = new System.Windows.Forms.FontDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.menuStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.Controls.Add(this.menuStripMain, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonSelect, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxFolder, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxOutput, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.buttonStart, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 389);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1Paint);
			// 
			// menuStripMain
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.menuStripMain, 3);
			this.menuStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.settingsToolStripMenuItem,
									this.languangeToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(542, 30);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.selectFolderToolStripMenuItem,
									this.startToolStripMenuItem,
									this.toolStripSeparator1,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 26);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// selectFolderToolStripMenuItem
			// 
			this.selectFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectFolderToolStripMenuItem.Image")));
			this.selectFolderToolStripMenuItem.Name = "selectFolderToolStripMenuItem";
			this.selectFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.selectFolderToolStripMenuItem.Text = "Select Folder";
			this.selectFolderToolStripMenuItem.Click += new System.EventHandler(this.SelectFolderToolStripMenuItemClick);
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startToolStripMenuItem.Image")));
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.startToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.startToolStripMenuItem.Text = "Start";
			this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fontToolStripMenuItem,
									this.backroundToolStripMenuItem,
									this.muteToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// fontToolStripMenuItem
			// 
			this.fontToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fontToolStripMenuItem.Image")));
			this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
			this.fontToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.fontToolStripMenuItem.Text = "Font";
			this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItemClick);
			// 
			// backroundToolStripMenuItem
			// 
			this.backroundToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backroundToolStripMenuItem.Image")));
			this.backroundToolStripMenuItem.Name = "backroundToolStripMenuItem";
			this.backroundToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.backroundToolStripMenuItem.Text = "Backround";
			this.backroundToolStripMenuItem.Click += new System.EventHandler(this.BackroundToolStripMenuItemClick);
			// 
			// muteToolStripMenuItem
			// 
			this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
			this.muteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.muteToolStripMenuItem.Text = "Mute";
			this.muteToolStripMenuItem.Click += new System.EventHandler(this.MuteToolStripMenuItemClick);
			// 
			// languangeToolStripMenuItem
			// 
			this.languangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.englishToolStripMenuItem,
									this.greekToolStripMenuItem});
			this.languangeToolStripMenuItem.Name = "languangeToolStripMenuItem";
			this.languangeToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
			this.languangeToolStripMenuItem.Text = "Languange";
			// 
			// englishToolStripMenuItem
			// 
			this.englishToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("englishToolStripMenuItem.Image")));
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			this.englishToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.englishToolStripMenuItem.Text = "English";
			this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItemClick);
			// 
			// greekToolStripMenuItem
			// 
			this.greekToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("greekToolStripMenuItem.Image")));
			this.greekToolStripMenuItem.Name = "greekToolStripMenuItem";
			this.greekToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.greekToolStripMenuItem.Text = "Ελληνικά";
			this.greekToolStripMenuItem.Click += new System.EventHandler(this.GreekToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 26);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// buttonSelect
			// 
			this.buttonSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.buttonSelect.AutoSize = true;
			this.buttonSelect.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelect.Image")));
			this.buttonSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonSelect.Location = new System.Drawing.Point(3, 43);
			this.buttonSelect.Name = "buttonSelect";
			this.buttonSelect.Size = new System.Drawing.Size(74, 23);
			this.buttonSelect.TabIndex = 1;
			this.buttonSelect.Text = "Search";
			this.buttonSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSelect.UseVisualStyleBackColor = true;
			this.buttonSelect.Click += new System.EventHandler(this.ButtonSelectClick);
			// 
			// textBoxFolder
			// 
			this.textBoxFolder.AllowDrop = true;
			this.textBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxFolder.Location = new System.Drawing.Point(83, 43);
			this.textBoxFolder.Name = "textBoxFolder";
			this.textBoxFolder.Size = new System.Drawing.Size(376, 24);
			this.textBoxFolder.TabIndex = 2;
			this.textBoxFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxFolderDragDrop);
			this.textBoxFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxFolderDragEnter);
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.BackColor = System.Drawing.Color.Black;
			this.tableLayoutPanel1.SetColumnSpan(this.textBoxOutput, 3);
			this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBoxOutput.Location = new System.Drawing.Point(3, 83);
			this.textBoxOutput.MaxLength = 2000000;
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ReadOnly = true;
			this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxOutput.Size = new System.Drawing.Size(536, 303);
			this.textBoxOutput.TabIndex = 4;
			// 
			// buttonStart
			// 
			this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.buttonStart.AutoSize = true;
			this.buttonStart.Image = ((System.Drawing.Image)(resources.GetObject("buttonStart.Image")));
			this.buttonStart.Location = new System.Drawing.Point(465, 43);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(74, 23);
			this.buttonStart.TabIndex = 3;
			this.buttonStart.Text = "Start";
			this.buttonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
			// 
			// fontDialogSettings
			// 
			this.fontDialogSettings.AllowVectorFonts = false;
			this.fontDialogSettings.AllowVerticalFonts = false;
			this.fontDialogSettings.FontMustExist = true;
			this.fontDialogSettings.ShowColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 389);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripMain;
			this.MinimumSize = new System.Drawing.Size(400, 160);
			this.Name = "MainForm";
			this.Text = "Hoyohoyo";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
		private System.Windows.Forms.FontDialog fontDialogSettings;
		private System.Windows.Forms.ColorDialog colorDialogSettings;
		private System.Windows.Forms.ToolStripMenuItem backroundToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greekToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem languangeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSearch;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonSelect;
		private System.Windows.Forms.TextBox textBoxFolder;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
