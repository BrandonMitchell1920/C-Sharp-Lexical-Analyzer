
namespace LexicalAnalyzer
{
    partial class Root
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Root));
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScanTableMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openTokenTableMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openKeywordTableMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openSourceFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveOutputMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOutputMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.scanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextTokenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.autoScanMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.restartScanningMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyrightMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.scanTableText = new System.Windows.Forms.TextBox();
            this.scanTextLabel = new System.Windows.Forms.Label();
            this.tokenTableLabel = new System.Windows.Forms.Label();
            this.tokenTableText = new System.Windows.Forms.TextBox();
            this.keywordTableLabel = new System.Windows.Forms.Label();
            this.keywordTableText = new System.Windows.Forms.TextBox();
            this.sourceFileLabel = new System.Windows.Forms.Label();
            this.sourceFileText = new System.Windows.Forms.TextBox();
            this.openScanTableButton = new System.Windows.Forms.Button();
            this.openTokenTableButton = new System.Windows.Forms.Button();
            this.openKeywordTableButton = new System.Windows.Forms.Button();
            this.openSourceFileButton = new System.Windows.Forms.Button();
            this.nextTokenButton = new System.Windows.Forms.Button();
            this.autoScanButton = new System.Windows.Forms.Button();
            this.scanControlLabel = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(152, 35);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(51, 17);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Output";
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.White;
            this.outputText.DetectUrls = false;
            this.outputText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(12, 55);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.outputText.Size = new System.Drawing.Size(332, 383);
            this.outputText.TabIndex = 1;
            this.outputText.Text = "";
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.scanToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(758, 24);
            this.menuBar.TabIndex = 2;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openScanTableMenu,
            this.openTokenTableMenu,
            this.openKeywordTableMenu,
            this.openSourceFileMenu,
            this.toolStripSeparator1,
            this.saveOutputMenu,
            this.toolStripSeparator2,
            this.exitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "F";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openScanTableMenu
            // 
            this.openScanTableMenu.Name = "openScanTableMenu";
            this.openScanTableMenu.Size = new System.Drawing.Size(194, 22);
            this.openScanTableMenu.Text = "Open Scan Table ...";
            this.openScanTableMenu.Click += new System.EventHandler((sender, e) => openScanTable());
            // 
            // openTokenTableMenu
            // 
            this.openTokenTableMenu.Name = "openTokenTableMenu";
            this.openTokenTableMenu.Size = new System.Drawing.Size(194, 22);
            this.openTokenTableMenu.Text = "Open Token Table ...";
            this.openTokenTableMenu.Click += new System.EventHandler((sender, e) => openTokenTable());
            // 
            // openKeywordTableMenu
            // 
            this.openKeywordTableMenu.Name = "openKeywordTableMenu";
            this.openKeywordTableMenu.Size = new System.Drawing.Size(194, 22);
            this.openKeywordTableMenu.Text = "Open Keyword Table ...";
            this.openKeywordTableMenu.Click += new System.EventHandler((sender, e) => openKeywordTable());
            // 
            // openSourceFileMenu
            // 
            this.openSourceFileMenu.Name = "openSourceFileMenu";
            this.openSourceFileMenu.Size = new System.Drawing.Size(194, 22);
            this.openSourceFileMenu.Text = "Open Source File ...";
            this.openSourceFileMenu.Click += new System.EventHandler((sender, e) => openSourceFile());
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // saveOutputMenu
            // 
            this.saveOutputMenu.Name = "saveOutputMenu";
            this.saveOutputMenu.Size = new System.Drawing.Size(194, 22);
            this.saveOutputMenu.Text = "Save Output ...";
            this.saveOutputMenu.Click += new System.EventHandler((sender, e) => saveOutputText());
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(194, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler((sender, e) => System.Windows.Forms.Application.Exit());
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearOutputMenu});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeyDisplayString = "E";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearOutputMenu
            // 
            this.clearOutputMenu.Name = "clearOutputMenu";
            this.clearOutputMenu.Size = new System.Drawing.Size(142, 22);
            this.clearOutputMenu.Text = "Clear Output";
            this.clearOutputMenu.Click += new System.EventHandler((sender, e) => outputText.Clear());
            // 
            // scanToolStripMenuItem
            // 
            this.scanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextTokenMenu,
            this.autoScanMenu,
            this.restartScanningMenu});
            this.scanToolStripMenuItem.Name = "scanToolStripMenuItem";
            this.scanToolStripMenuItem.ShortcutKeyDisplayString = "S";
            this.scanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.scanToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.scanToolStripMenuItem.Text = "Scan";
            // 
            // nextTokenMenu
            // 
            this.nextTokenMenu.Name = "nextTokenMenu";
            this.nextTokenMenu.Size = new System.Drawing.Size(162, 22);
            this.nextTokenMenu.Text = "Next Token";
            this.nextTokenMenu.Click += new System.EventHandler((sender, e) => scanManager());
            // 
            // autoScanMenu
            // 
            this.autoScanMenu.Name = "autoScanMenu";
            this.autoScanMenu.Size = new System.Drawing.Size(162, 22);
            this.autoScanMenu.Text = "Auto Scan";
            this.autoScanMenu.Click += new System.EventHandler((sender, e) => autoScanManager());
            // 
            // restartScanningMenu
            // 
            this.restartScanningMenu.Name = "restartScanningMenu";
            this.restartScanningMenu.Size = new System.Drawing.Size(162, 22);
            this.restartScanningMenu.Text = "Restart Scanning";
            this.restartScanningMenu.Click += new System.EventHandler((sender, e) => lex.restartScanning());
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu,
            this.copyrightMenu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = "H";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(163, 22);
            this.aboutMenu.Text = "About ...";
            this.aboutMenu.Click += new System.EventHandler((sender, e) => about());
            // 
            // copyrightMenu
            // 
            this.copyrightMenu.Name = "copyrightMenu";
            this.copyrightMenu.Size = new System.Drawing.Size(163, 22);
            this.copyrightMenu.Text = "Copyright Info ...";
            this.copyrightMenu.Click += new System.EventHandler((sender, e) => copyright());
            // 
            // scanTableText
            // 
            this.scanTableText.BackColor = System.Drawing.SystemColors.Window;
            this.scanTableText.Location = new System.Drawing.Point(384, 80);
            this.scanTableText.Name = "scanTableText";
            this.scanTableText.ReadOnly = true;
            this.scanTableText.Size = new System.Drawing.Size(268, 20);
            this.scanTableText.TabIndex = 3;
            // 
            // scanTextLabel
            // 
            this.scanTextLabel.AutoSize = true;
            this.scanTextLabel.Location = new System.Drawing.Point(384, 64);
            this.scanTextLabel.Name = "scanTextLabel";
            this.scanTextLabel.Size = new System.Drawing.Size(62, 13);
            this.scanTextLabel.TabIndex = 4;
            this.scanTextLabel.Text = "Scan Table";
            // 
            // tokenTableLabel
            // 
            this.tokenTableLabel.AutoSize = true;
            this.tokenTableLabel.Location = new System.Drawing.Point(384, 136);
            this.tokenTableLabel.Name = "tokenTableLabel";
            this.tokenTableLabel.Size = new System.Drawing.Size(68, 13);
            this.tokenTableLabel.TabIndex = 6;
            this.tokenTableLabel.Text = "Token Table";
            // 
            // tokenTableText
            // 
            this.tokenTableText.BackColor = System.Drawing.SystemColors.Window;
            this.tokenTableText.Location = new System.Drawing.Point(384, 152);
            this.tokenTableText.Name = "tokenTableText";
            this.tokenTableText.ReadOnly = true;
            this.tokenTableText.Size = new System.Drawing.Size(268, 20);
            this.tokenTableText.TabIndex = 5;
            // 
            // keywordTableLabel
            // 
            this.keywordTableLabel.AutoSize = true;
            this.keywordTableLabel.Location = new System.Drawing.Point(384, 208);
            this.keywordTableLabel.Name = "keywordTableLabel";
            this.keywordTableLabel.Size = new System.Drawing.Size(78, 13);
            this.keywordTableLabel.TabIndex = 8;
            this.keywordTableLabel.Text = "Keyword Table";
            // 
            // keywordTableText
            // 
            this.keywordTableText.BackColor = System.Drawing.SystemColors.Window;
            this.keywordTableText.Location = new System.Drawing.Point(384, 224);
            this.keywordTableText.Name = "keywordTableText";
            this.keywordTableText.ReadOnly = true;
            this.keywordTableText.Size = new System.Drawing.Size(268, 20);
            this.keywordTableText.TabIndex = 7;
            // 
            // sourceFileLabel
            // 
            this.sourceFileLabel.AutoSize = true;
            this.sourceFileLabel.Location = new System.Drawing.Point(384, 280);
            this.sourceFileLabel.Name = "sourceFileLabel";
            this.sourceFileLabel.Size = new System.Drawing.Size(60, 13);
            this.sourceFileLabel.TabIndex = 10;
            this.sourceFileLabel.Text = "Source File";
            // 
            // sourceFileText
            // 
            this.sourceFileText.BackColor = System.Drawing.SystemColors.Window;
            this.sourceFileText.Location = new System.Drawing.Point(384, 296);
            this.sourceFileText.Name = "sourceFileText";
            this.sourceFileText.ReadOnly = true;
            this.sourceFileText.Size = new System.Drawing.Size(268, 20);
            this.sourceFileText.TabIndex = 9;
            // 
            // openScanTableButton
            // 
            this.openScanTableButton.Location = new System.Drawing.Point(671, 80);
            this.openScanTableButton.Name = "openScanTableButton";
            this.openScanTableButton.Size = new System.Drawing.Size(75, 24);
            this.openScanTableButton.TabIndex = 11;
            this.openScanTableButton.Text = "Browse";
            this.openScanTableButton.UseVisualStyleBackColor = true;
            this.openScanTableButton.Click += new System.EventHandler((sender, e) => openScanTable());
            // 
            // openTokenTableButton
            // 
            this.openTokenTableButton.Location = new System.Drawing.Point(671, 152);
            this.openTokenTableButton.Name = "openTokenTableButton";
            this.openTokenTableButton.Size = new System.Drawing.Size(75, 24);
            this.openTokenTableButton.TabIndex = 12;
            this.openTokenTableButton.Text = "Browse";
            this.openTokenTableButton.UseVisualStyleBackColor = true;
            this.openTokenTableButton.Click += new System.EventHandler((sender, e) => openTokenTable());
            // 
            // openKeywordTableButton
            // 
            this.openKeywordTableButton.Location = new System.Drawing.Point(671, 224);
            this.openKeywordTableButton.Name = "openKeywordTableButton";
            this.openKeywordTableButton.Size = new System.Drawing.Size(75, 24);
            this.openKeywordTableButton.TabIndex = 13;
            this.openKeywordTableButton.Text = "Browse";
            this.openKeywordTableButton.UseVisualStyleBackColor = true;
            this.openKeywordTableButton.Click += new System.EventHandler((sender, e) => openKeywordTable());
            // 
            // openSourceFileButton
            // 
            this.openSourceFileButton.Location = new System.Drawing.Point(671, 296);
            this.openSourceFileButton.Name = "openSourceFileButton";
            this.openSourceFileButton.Size = new System.Drawing.Size(75, 24);
            this.openSourceFileButton.TabIndex = 14;
            this.openSourceFileButton.Text = "Browse";
            this.openSourceFileButton.UseVisualStyleBackColor = true;
            this.openSourceFileButton.Click += new System.EventHandler((sender, e) => openSourceFile());
            // 
            // nextTokenButton
            // 
            this.nextTokenButton.Location = new System.Drawing.Point(477, 368);
            this.nextTokenButton.Name = "nextTokenButton";
            this.nextTokenButton.Size = new System.Drawing.Size(75, 24);
            this.nextTokenButton.TabIndex = 15;
            this.nextTokenButton.Text = "Next Token";
            this.nextTokenButton.UseVisualStyleBackColor = true;
            this.nextTokenButton.Click += new System.EventHandler((sender, e) => scanManager());
            // 
            // autoScanButton
            // 
            this.autoScanButton.Location = new System.Drawing.Point(577, 368);
            this.autoScanButton.Name = "autoScanButton";
            this.autoScanButton.Size = new System.Drawing.Size(75, 24);
            this.autoScanButton.TabIndex = 16;
            this.autoScanButton.Text = "Auto Scan";
            this.autoScanButton.UseVisualStyleBackColor = true;
            this.autoScanButton.Click += new System.EventHandler((sender, e) => autoScanManager());
            // 
            // scanControlLabel
            // 
            this.scanControlLabel.AutoSize = true;
            this.scanControlLabel.Location = new System.Drawing.Point(381, 374);
            this.scanControlLabel.Name = "scanControlLabel";
            this.scanControlLabel.Size = new System.Drawing.Size(73, 13);
            this.scanControlLabel.TabIndex = 17;
            this.scanControlLabel.Text = "Scan Controls";
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.scanControlLabel);
            this.Controls.Add(this.autoScanButton);
            this.Controls.Add(this.nextTokenButton);
            this.Controls.Add(this.openSourceFileButton);
            this.Controls.Add(this.openKeywordTableButton);
            this.Controls.Add(this.openTokenTableButton);
            this.Controls.Add(this.openScanTableButton);
            this.Controls.Add(this.sourceFileLabel);
            this.Controls.Add(this.sourceFileText);
            this.Controls.Add(this.keywordTableLabel);
            this.Controls.Add(this.keywordTableText);
            this.Controls.Add(this.tokenTableLabel);
            this.Controls.Add(this.tokenTableText);
            this.Controls.Add(this.scanTextLabel);
            this.Controls.Add(this.scanTableText);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.menuBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Root";
            this.Text = "Lexical Analyzer (C# Ver.)";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScanTableMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTokenTableMenu;
        private System.Windows.Forms.ToolStripMenuItem openKeywordTableMenu;
        private System.Windows.Forms.ToolStripMenuItem openSourceFileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveOutputMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem clearOutputMenu;
        private System.Windows.Forms.ToolStripMenuItem nextTokenMenu;
        private System.Windows.Forms.ToolStripMenuItem autoScanMenu;
        private System.Windows.Forms.ToolStripMenuItem restartScanningMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem copyrightMenu;
        private System.Windows.Forms.TextBox scanTableText;
        private System.Windows.Forms.Label scanTextLabel;
        private System.Windows.Forms.Label tokenTableLabel;
        private System.Windows.Forms.TextBox tokenTableText;
        private System.Windows.Forms.Label keywordTableLabel;
        private System.Windows.Forms.TextBox keywordTableText;
        private System.Windows.Forms.Label sourceFileLabel;
        private System.Windows.Forms.TextBox sourceFileText;
        private System.Windows.Forms.Button openScanTableButton;
        private System.Windows.Forms.Button openTokenTableButton;
        private System.Windows.Forms.Button openKeywordTableButton;
        private System.Windows.Forms.Button openSourceFileButton;
        private System.Windows.Forms.Button nextTokenButton;
        private System.Windows.Forms.Button autoScanButton;
        private System.Windows.Forms.Label scanControlLabel;
    }
}

