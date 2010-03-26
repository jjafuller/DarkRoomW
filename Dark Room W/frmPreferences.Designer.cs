namespace DarkRoomW
{
    partial class frmPreferences
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
            this.btnOK = new System.Windows.Forms.Button();
            this.tabPreferences = new System.Windows.Forms.TabControl();
            this.tabEnvironment = new System.Windows.Forms.TabPage();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.chkMultipleMonitor = new System.Windows.Forms.CheckBox();
            this.chkNav = new System.Windows.Forms.CheckBox();
            this.trcOpacity = new System.Windows.Forms.TrackBar();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPage = new System.Windows.Forms.GroupBox();
            this.chkPageHeight = new System.Windows.Forms.CheckBox();
            this.chkPageWidth = new System.Windows.Forms.CheckBox();
            this.txtPageMargin = new System.Windows.Forms.TextBox();
            this.txtPageHeight = new System.Windows.Forms.TextBox();
            this.txtPageWidth = new System.Windows.Forms.TextBox();
            this.btnPageColor = new System.Windows.Forms.Button();
            this.lblPageColor = new System.Windows.Forms.Label();
            this.lblPadding = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.chkAudoIndent = new System.Windows.Forms.CheckBox();
            this.chkTabToSpaces = new System.Windows.Forms.CheckBox();
            this.txtTabstoSpaces = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.lblFontColor = new System.Windows.Forms.Label();
            this.tabApplication = new System.Windows.Forms.TabPage();
            this.grpAdvanced = new System.Windows.Forms.GroupBox();
            this.txtCursorBlinkTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkLocalCacheFile = new System.Windows.Forms.CheckBox();
            this.chkContextMenu = new System.Windows.Forms.CheckBox();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.grpDataRecovery = new System.Windows.Forms.GroupBox();
            this.rdoLoadClean = new System.Windows.Forms.RadioButton();
            this.rdoLoadLast = new System.Windows.Forms.RadioButton();
            this.rdoLoadBuffer = new System.Windows.Forms.RadioButton();
            this.chkLaunchFullscreen = new System.Windows.Forms.CheckBox();
            this.chkAutosave = new System.Windows.Forms.CheckBox();
            this.clrPicker = new System.Windows.Forms.ColorDialog();
            this.fntPicker = new System.Windows.Forms.FontDialog();
            this.chkNeutralHighlighting = new System.Windows.Forms.CheckBox();
            this.tabPreferences.SuspendLayout();
            this.tabEnvironment.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcOpacity)).BeginInit();
            this.grpPage.SuspendLayout();
            this.grpFont.SuspendLayout();
            this.tabApplication.SuspendLayout();
            this.grpAdvanced.SuspendLayout();
            this.grpFile.SuspendLayout();
            this.grpDataRecovery.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(305, 423);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabPreferences
            // 
            this.tabPreferences.Controls.Add(this.tabEnvironment);
            this.tabPreferences.Controls.Add(this.tabApplication);
            this.tabPreferences.Location = new System.Drawing.Point(12, 12);
            this.tabPreferences.Name = "tabPreferences";
            this.tabPreferences.SelectedIndex = 0;
            this.tabPreferences.Size = new System.Drawing.Size(368, 405);
            this.tabPreferences.TabIndex = 1;
            // 
            // tabEnvironment
            // 
            this.tabEnvironment.BackColor = System.Drawing.Color.Transparent;
            this.tabEnvironment.Controls.Add(this.grpGeneral);
            this.tabEnvironment.Controls.Add(this.grpPage);
            this.tabEnvironment.Controls.Add(this.grpFont);
            this.tabEnvironment.Location = new System.Drawing.Point(4, 22);
            this.tabEnvironment.Name = "tabEnvironment";
            this.tabEnvironment.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnvironment.Size = new System.Drawing.Size(360, 379);
            this.tabEnvironment.TabIndex = 0;
            this.tabEnvironment.Text = "Environment";
            this.tabEnvironment.UseVisualStyleBackColor = true;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.chkNeutralHighlighting);
            this.grpGeneral.Controls.Add(this.chkMultipleMonitor);
            this.grpGeneral.Controls.Add(this.chkNav);
            this.grpGeneral.Controls.Add(this.trcOpacity);
            this.grpGeneral.Controls.Add(this.btnBackColor);
            this.grpGeneral.Controls.Add(this.label2);
            this.grpGeneral.Controls.Add(this.label1);
            this.grpGeneral.Location = new System.Drawing.Point(6, 270);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(348, 103);
            this.grpGeneral.TabIndex = 2;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General Settings";
            // 
            // chkMultipleMonitor
            // 
            this.chkMultipleMonitor.AutoSize = true;
            this.chkMultipleMonitor.Location = new System.Drawing.Point(188, 23);
            this.chkMultipleMonitor.Name = "chkMultipleMonitor";
            this.chkMultipleMonitor.Size = new System.Drawing.Size(140, 17);
            this.chkMultipleMonitor.TabIndex = 5;
            this.chkMultipleMonitor.Text = "Multiple Monitor Support";
            this.chkMultipleMonitor.UseVisualStyleBackColor = true;
            this.chkMultipleMonitor.CheckedChanged += new System.EventHandler(this.chkMultipleMonitor_CheckedChanged);
            // 
            // chkNav
            // 
            this.chkNav.AutoSize = true;
            this.chkNav.Location = new System.Drawing.Point(188, 47);
            this.chkNav.Name = "chkNav";
            this.chkNav.Size = new System.Drawing.Size(102, 17);
            this.chkNav.TabIndex = 4;
            this.chkNav.Text = "Hide Navigation";
            this.chkNav.UseVisualStyleBackColor = true;
            this.chkNav.CheckedChanged += new System.EventHandler(this.chkNav_CheckedChanged);
            // 
            // trcOpacity
            // 
            this.trcOpacity.BackColor = System.Drawing.SystemColors.Control;
            this.trcOpacity.Location = new System.Drawing.Point(70, 47);
            this.trcOpacity.Maximum = 100;
            this.trcOpacity.Minimum = 50;
            this.trcOpacity.Name = "trcOpacity";
            this.trcOpacity.Size = new System.Drawing.Size(104, 45);
            this.trcOpacity.TabIndex = 3;
            this.trcOpacity.TickFrequency = 10;
            this.trcOpacity.Value = 50;
            this.trcOpacity.Scroll += new System.EventHandler(this.trcOpacity_Scroll);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(80, 22);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(70, 18);
            this.btnBackColor.TabIndex = 2;
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opacity (%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background:";
            // 
            // grpPage
            // 
            this.grpPage.Controls.Add(this.chkPageHeight);
            this.grpPage.Controls.Add(this.chkPageWidth);
            this.grpPage.Controls.Add(this.txtPageMargin);
            this.grpPage.Controls.Add(this.txtPageHeight);
            this.grpPage.Controls.Add(this.txtPageWidth);
            this.grpPage.Controls.Add(this.btnPageColor);
            this.grpPage.Controls.Add(this.lblPageColor);
            this.grpPage.Controls.Add(this.lblPadding);
            this.grpPage.Controls.Add(this.lblHeight);
            this.grpPage.Controls.Add(this.lblWidth);
            this.grpPage.Location = new System.Drawing.Point(6, 143);
            this.grpPage.Name = "grpPage";
            this.grpPage.Size = new System.Drawing.Size(348, 121);
            this.grpPage.TabIndex = 1;
            this.grpPage.TabStop = false;
            this.grpPage.Text = "Page Settings";
            // 
            // chkPageHeight
            // 
            this.chkPageHeight.AutoSize = true;
            this.chkPageHeight.Location = new System.Drawing.Point(188, 47);
            this.chkPageHeight.Name = "chkPageHeight";
            this.chkPageHeight.Size = new System.Drawing.Size(48, 17);
            this.chkPageHeight.TabIndex = 9;
            this.chkPageHeight.Text = "Auto";
            this.chkPageHeight.UseVisualStyleBackColor = true;
            this.chkPageHeight.CheckedChanged += new System.EventHandler(this.chkPageHeight_CheckedChanged);
            // 
            // chkPageWidth
            // 
            this.chkPageWidth.AutoSize = true;
            this.chkPageWidth.Location = new System.Drawing.Point(188, 25);
            this.chkPageWidth.Name = "chkPageWidth";
            this.chkPageWidth.Size = new System.Drawing.Size(48, 17);
            this.chkPageWidth.TabIndex = 8;
            this.chkPageWidth.Text = "Auto";
            this.chkPageWidth.UseVisualStyleBackColor = true;
            this.chkPageWidth.CheckedChanged += new System.EventHandler(this.chkPageWidth_CheckedChanged);
            // 
            // txtPageMargin
            // 
            this.txtPageMargin.Location = new System.Drawing.Point(80, 67);
            this.txtPageMargin.Name = "txtPageMargin";
            this.txtPageMargin.Size = new System.Drawing.Size(102, 20);
            this.txtPageMargin.TabIndex = 7;
            this.txtPageMargin.TextChanged += new System.EventHandler(this.txtPageMargin_TextChanged);
            // 
            // txtPageHeight
            // 
            this.txtPageHeight.Location = new System.Drawing.Point(80, 45);
            this.txtPageHeight.Name = "txtPageHeight";
            this.txtPageHeight.Size = new System.Drawing.Size(102, 20);
            this.txtPageHeight.TabIndex = 6;
            this.txtPageHeight.TextChanged += new System.EventHandler(this.txtPageHeight_TextChanged);
            // 
            // txtPageWidth
            // 
            this.txtPageWidth.Location = new System.Drawing.Point(80, 23);
            this.txtPageWidth.Name = "txtPageWidth";
            this.txtPageWidth.Size = new System.Drawing.Size(102, 20);
            this.txtPageWidth.TabIndex = 5;
            this.txtPageWidth.TextChanged += new System.EventHandler(this.txtPageWidth_TextChanged);
            // 
            // btnPageColor
            // 
            this.btnPageColor.Location = new System.Drawing.Point(80, 93);
            this.btnPageColor.Name = "btnPageColor";
            this.btnPageColor.Size = new System.Drawing.Size(70, 18);
            this.btnPageColor.TabIndex = 4;
            this.btnPageColor.UseVisualStyleBackColor = true;
            this.btnPageColor.Click += new System.EventHandler(this.btnPageColor_Click);
            // 
            // lblPageColor
            // 
            this.lblPageColor.AutoSize = true;
            this.lblPageColor.Location = new System.Drawing.Point(6, 96);
            this.lblPageColor.Name = "lblPageColor";
            this.lblPageColor.Size = new System.Drawing.Size(34, 13);
            this.lblPageColor.TabIndex = 3;
            this.lblPageColor.Text = "Color:";
            // 
            // lblPadding
            // 
            this.lblPadding.AutoSize = true;
            this.lblPadding.Location = new System.Drawing.Point(6, 70);
            this.lblPadding.Name = "lblPadding";
            this.lblPadding.Size = new System.Drawing.Size(42, 13);
            this.lblPadding.TabIndex = 2;
            this.lblPadding.Text = "Margin:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(6, 48);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(6, 26);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width:";
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.chkAudoIndent);
            this.grpFont.Controls.Add(this.chkTabToSpaces);
            this.grpFont.Controls.Add(this.txtTabstoSpaces);
            this.grpFont.Controls.Add(this.btnFont);
            this.grpFont.Controls.Add(this.txtFont);
            this.grpFont.Controls.Add(this.lblFont);
            this.grpFont.Controls.Add(this.btnFontColor);
            this.grpFont.Controls.Add(this.lblFontColor);
            this.grpFont.Location = new System.Drawing.Point(6, 6);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(348, 131);
            this.grpFont.TabIndex = 0;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "Formatting Settings";
            // 
            // chkAudoIndent
            // 
            this.chkAudoIndent.AutoSize = true;
            this.chkAudoIndent.Location = new System.Drawing.Point(9, 99);
            this.chkAudoIndent.Name = "chkAudoIndent";
            this.chkAudoIndent.Size = new System.Drawing.Size(81, 17);
            this.chkAudoIndent.TabIndex = 16;
            this.chkAudoIndent.Text = "Auto Indent";
            this.chkAudoIndent.UseVisualStyleBackColor = true;
            this.chkAudoIndent.CheckedChanged += new System.EventHandler(this.chkAudoIndent_CheckedChanged);
            // 
            // chkTabToSpaces
            // 
            this.chkTabToSpaces.AutoSize = true;
            this.chkTabToSpaces.Location = new System.Drawing.Point(9, 76);
            this.chkTabToSpaces.Name = "chkTabToSpaces";
            this.chkTabToSpaces.Size = new System.Drawing.Size(141, 17);
            this.chkTabToSpaces.TabIndex = 15;
            this.chkTabToSpaces.Text = "Convert Tabs to Spaces";
            this.chkTabToSpaces.UseVisualStyleBackColor = true;
            this.chkTabToSpaces.CheckedChanged += new System.EventHandler(this.chkTabToSpaces_CheckedChanged);
            // 
            // txtTabstoSpaces
            // 
            this.txtTabstoSpaces.Location = new System.Drawing.Point(156, 74);
            this.txtTabstoSpaces.Name = "txtTabstoSpaces";
            this.txtTabstoSpaces.Size = new System.Drawing.Size(35, 20);
            this.txtTabstoSpaces.TabIndex = 14;
            this.txtTabstoSpaces.TextChanged += new System.EventHandler(this.txtTabstoSpaces_TextChanged);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(295, 49);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(26, 20);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // txtFont
            // 
            this.txtFont.BackColor = System.Drawing.SystemColors.Control;
            this.txtFont.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFont.Location = new System.Drawing.Point(80, 53);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(209, 13);
            this.txtFont.TabIndex = 3;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(6, 53);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(31, 13);
            this.lblFont.TabIndex = 2;
            this.lblFont.Text = "Font:";
            // 
            // btnFontColor
            // 
            this.btnFontColor.Location = new System.Drawing.Point(80, 23);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(70, 18);
            this.btnFontColor.TabIndex = 1;
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // lblFontColor
            // 
            this.lblFontColor.AutoSize = true;
            this.lblFontColor.Location = new System.Drawing.Point(6, 26);
            this.lblFontColor.Name = "lblFontColor";
            this.lblFontColor.Size = new System.Drawing.Size(58, 13);
            this.lblFontColor.TabIndex = 0;
            this.lblFontColor.Text = "Font Color:";
            // 
            // tabApplication
            // 
            this.tabApplication.BackColor = System.Drawing.Color.Transparent;
            this.tabApplication.Controls.Add(this.grpAdvanced);
            this.tabApplication.Controls.Add(this.grpFile);
            this.tabApplication.Location = new System.Drawing.Point(4, 22);
            this.tabApplication.Name = "tabApplication";
            this.tabApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplication.Size = new System.Drawing.Size(360, 361);
            this.tabApplication.TabIndex = 1;
            this.tabApplication.Text = "Application";
            this.tabApplication.UseVisualStyleBackColor = true;
            // 
            // grpAdvanced
            // 
            this.grpAdvanced.Controls.Add(this.txtCursorBlinkTime);
            this.grpAdvanced.Controls.Add(this.label3);
            this.grpAdvanced.Controls.Add(this.chkLocalCacheFile);
            this.grpAdvanced.Controls.Add(this.chkContextMenu);
            this.grpAdvanced.Location = new System.Drawing.Point(6, 194);
            this.grpAdvanced.Name = "grpAdvanced";
            this.grpAdvanced.Size = new System.Drawing.Size(348, 161);
            this.grpAdvanced.TabIndex = 1;
            this.grpAdvanced.TabStop = false;
            this.grpAdvanced.Text = "Advanced Settings";
            // 
            // txtCursorBlinkTime
            // 
            this.txtCursorBlinkTime.Location = new System.Drawing.Point(130, 75);
            this.txtCursorBlinkTime.Name = "txtCursorBlinkTime";
            this.txtCursorBlinkTime.Size = new System.Drawing.Size(76, 20);
            this.txtCursorBlinkTime.TabIndex = 9;
            this.txtCursorBlinkTime.TextChanged += new System.EventHandler(this.txtCursorBlinkTime_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cursor Blink Time (ms):";
            // 
            // chkLocalCacheFile
            // 
            this.chkLocalCacheFile.AutoSize = true;
            this.chkLocalCacheFile.Location = new System.Drawing.Point(13, 52);
            this.chkLocalCacheFile.Name = "chkLocalCacheFile";
            this.chkLocalCacheFile.Size = new System.Drawing.Size(204, 17);
            this.chkLocalCacheFile.TabIndex = 1;
            this.chkLocalCacheFile.Text = "Enable Local Cache File for Portability";
            this.chkLocalCacheFile.UseVisualStyleBackColor = true;
            this.chkLocalCacheFile.CheckedChanged += new System.EventHandler(this.chkLocalCacheFile_CheckedChanged);
            // 
            // chkContextMenu
            // 
            this.chkContextMenu.AutoSize = true;
            this.chkContextMenu.Location = new System.Drawing.Point(13, 29);
            this.chkContextMenu.Name = "chkContextMenu";
            this.chkContextMenu.Size = new System.Drawing.Size(266, 17);
            this.chkContextMenu.TabIndex = 0;
            this.chkContextMenu.Text = "\"Open With Dark Room W\" Context Menu Integration";
            this.chkContextMenu.UseVisualStyleBackColor = true;
            this.chkContextMenu.CheckedChanged += new System.EventHandler(this.chkContextMenu_CheckedChanged);
            // 
            // grpFile
            // 
            this.grpFile.Controls.Add(this.grpDataRecovery);
            this.grpFile.Controls.Add(this.chkLaunchFullscreen);
            this.grpFile.Controls.Add(this.chkAutosave);
            this.grpFile.Location = new System.Drawing.Point(6, 6);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(348, 182);
            this.grpFile.TabIndex = 0;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "File Settings";
            // 
            // grpDataRecovery
            // 
            this.grpDataRecovery.Controls.Add(this.rdoLoadClean);
            this.grpDataRecovery.Controls.Add(this.rdoLoadLast);
            this.grpDataRecovery.Controls.Add(this.rdoLoadBuffer);
            this.grpDataRecovery.Location = new System.Drawing.Point(6, 19);
            this.grpDataRecovery.Name = "grpDataRecovery";
            this.grpDataRecovery.Size = new System.Drawing.Size(200, 95);
            this.grpDataRecovery.TabIndex = 4;
            this.grpDataRecovery.TabStop = false;
            this.grpDataRecovery.Text = "Data Recovery";
            // 
            // rdoLoadClean
            // 
            this.rdoLoadClean.AutoSize = true;
            this.rdoLoadClean.Location = new System.Drawing.Point(7, 68);
            this.rdoLoadClean.Name = "rdoLoadClean";
            this.rdoLoadClean.Size = new System.Drawing.Size(132, 17);
            this.rdoLoadClean.TabIndex = 2;
            this.rdoLoadClean.TabStop = true;
            this.rdoLoadClean.Text = "Load Clean Document";
            this.rdoLoadClean.UseVisualStyleBackColor = true;
            this.rdoLoadClean.CheckedChanged += new System.EventHandler(this.rdoLoadClean_CheckedChanged);
            // 
            // rdoLoadLast
            // 
            this.rdoLoadLast.AutoSize = true;
            this.rdoLoadLast.Location = new System.Drawing.Point(7, 44);
            this.rdoLoadLast.Name = "rdoLoadLast";
            this.rdoLoadLast.Size = new System.Drawing.Size(133, 17);
            this.rdoLoadLast.TabIndex = 1;
            this.rdoLoadLast.TabStop = true;
            this.rdoLoadLast.Text = "Load Last Opened File";
            this.rdoLoadLast.UseVisualStyleBackColor = true;
            this.rdoLoadLast.CheckedChanged += new System.EventHandler(this.rdoLoadLast_CheckedChanged);
            // 
            // rdoLoadBuffer
            // 
            this.rdoLoadBuffer.AutoSize = true;
            this.rdoLoadBuffer.Location = new System.Drawing.Point(7, 20);
            this.rdoLoadBuffer.Name = "rdoLoadBuffer";
            this.rdoLoadBuffer.Size = new System.Drawing.Size(139, 17);
            this.rdoLoadBuffer.TabIndex = 0;
            this.rdoLoadBuffer.TabStop = true;
            this.rdoLoadBuffer.Text = "Load Stored Buffer Text";
            this.rdoLoadBuffer.UseVisualStyleBackColor = true;
            this.rdoLoadBuffer.CheckedChanged += new System.EventHandler(this.rdoLoadBuffer_CheckedChanged);
            // 
            // chkLaunchFullscreen
            // 
            this.chkLaunchFullscreen.AutoSize = true;
            this.chkLaunchFullscreen.Location = new System.Drawing.Point(13, 152);
            this.chkLaunchFullscreen.Name = "chkLaunchFullscreen";
            this.chkLaunchFullscreen.Size = new System.Drawing.Size(124, 17);
            this.chkLaunchFullscreen.TabIndex = 1;
            this.chkLaunchFullscreen.Text = "Launch in Fullscreen";
            this.chkLaunchFullscreen.UseVisualStyleBackColor = true;
            this.chkLaunchFullscreen.CheckedChanged += new System.EventHandler(this.chkLaunchFullscreen_CheckedChanged);
            // 
            // chkAutosave
            // 
            this.chkAutosave.AutoSize = true;
            this.chkAutosave.Location = new System.Drawing.Point(13, 129);
            this.chkAutosave.Name = "chkAutosave";
            this.chkAutosave.Size = new System.Drawing.Size(71, 17);
            this.chkAutosave.TabIndex = 0;
            this.chkAutosave.Text = "Autosave";
            this.chkAutosave.UseVisualStyleBackColor = true;
            this.chkAutosave.CheckedChanged += new System.EventHandler(this.chkAutosave_CheckedChanged);
            // 
            // chkNeutralHighlighting
            // 
            this.chkNeutralHighlighting.AutoSize = true;
            this.chkNeutralHighlighting.Location = new System.Drawing.Point(188, 70);
            this.chkNeutralHighlighting.Name = "chkNeutralHighlighting";
            this.chkNeutralHighlighting.Size = new System.Drawing.Size(118, 17);
            this.chkNeutralHighlighting.TabIndex = 6;
            this.chkNeutralHighlighting.Text = "Neutral Highlighting";
            this.chkNeutralHighlighting.UseVisualStyleBackColor = true;
            this.chkNeutralHighlighting.CheckedChanged += new System.EventHandler(this.chkNeutralHighlighting_CheckedChanged);
            // 
            // frmPreferences
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 458);
            this.Controls.Add(this.tabPreferences);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPreferences";
            this.Text = "Dark Room W - Preferences";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.tabPreferences.ResumeLayout(false);
            this.tabEnvironment.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcOpacity)).EndInit();
            this.grpPage.ResumeLayout(false);
            this.grpPage.PerformLayout();
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.tabApplication.ResumeLayout(false);
            this.grpAdvanced.ResumeLayout(false);
            this.grpAdvanced.PerformLayout();
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.grpDataRecovery.ResumeLayout(false);
            this.grpDataRecovery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabPreferences;
        private System.Windows.Forms.TabPage tabEnvironment;
        private System.Windows.Forms.TabPage tabApplication;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Label lblFontColor;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.GroupBox grpPage;
        private System.Windows.Forms.Label lblPageColor;
        private System.Windows.Forms.Label lblPadding;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnPageColor;
        private System.Windows.Forms.TextBox txtPageMargin;
        private System.Windows.Forms.TextBox txtPageHeight;
        private System.Windows.Forms.TextBox txtPageWidth;
        private System.Windows.Forms.CheckBox chkPageHeight;
        private System.Windows.Forms.CheckBox chkPageWidth;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.TrackBar trcOpacity;
        private System.Windows.Forms.CheckBox chkMultipleMonitor;
        private System.Windows.Forms.CheckBox chkNav;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.CheckBox chkLaunchFullscreen;
        private System.Windows.Forms.CheckBox chkAutosave;
        private System.Windows.Forms.GroupBox grpDataRecovery;
        private System.Windows.Forms.RadioButton rdoLoadClean;
        private System.Windows.Forms.RadioButton rdoLoadLast;
        private System.Windows.Forms.RadioButton rdoLoadBuffer;
        private System.Windows.Forms.GroupBox grpAdvanced;
        private System.Windows.Forms.CheckBox chkContextMenu;
        private System.Windows.Forms.ColorDialog clrPicker;
        private System.Windows.Forms.FontDialog fntPicker;
        private System.Windows.Forms.CheckBox chkLocalCacheFile;
        private System.Windows.Forms.CheckBox chkAudoIndent;
        private System.Windows.Forms.CheckBox chkTabToSpaces;
        private System.Windows.Forms.TextBox txtTabstoSpaces;
        private System.Windows.Forms.TextBox txtCursorBlinkTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkNeutralHighlighting;
    }
}