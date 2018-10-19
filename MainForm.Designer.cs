namespace MessengerVersionSwitcher
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.AboutLabel = new System.Windows.Forms.Label();
			this.TabControl = new MessengerVersionSwitcher.WizardPages();
			this.MainTabPage = new System.Windows.Forms.TabPage();
			this.InstallButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SwitchButton = new System.Windows.Forms.Button();
			this.MainTitle = new System.Windows.Forms.Label();
			this.ProgressTabPage = new System.Windows.Forms.TabPage();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.ProgressTitle = new System.Windows.Forms.Label();
			this.SelectTabPage = new System.Windows.Forms.TabPage();
			this.VersionPanel = new System.Windows.Forms.Panel();
			this.SelectDescription = new System.Windows.Forms.Label();
			this.SelectTitle = new System.Windows.Forms.Label();
			this.MainMenuLinkLabel2 = new System.Windows.Forms.LinkLabel();
			this.NameTabPage = new System.Windows.Forms.TabPage();
			this.CustomNameRadioButton = new System.Windows.Forms.RadioButton();
			this.NameContinueButton = new System.Windows.Forms.Button();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.AutoNameRadioButton = new System.Windows.Forms.RadioButton();
			this.NameTitle = new System.Windows.Forms.Label();
			this.ResultTabPage = new System.Windows.Forms.TabPage();
			this.HelpLabel = new System.Windows.Forms.Label();
			this.ErrorTextBox = new System.Windows.Forms.TextBox();
			this.ErrorInfoLinkLabel = new System.Windows.Forms.LinkLabel();
			this.MainMenuLinkLabel = new System.Windows.Forms.LinkLabel();
			this.ResultTitle = new System.Windows.Forms.Label();
			this.MethodTabPage = new System.Windows.Forms.TabPage();
			this.DeleteWarningLabel = new System.Windows.Forms.Label();
			this.CopyFilesLabel = new System.Windows.Forms.Label();
			this.FileCopyRadioButton = new System.Windows.Forms.RadioButton();
			this.ChangeLabel = new System.Windows.Forms.Label();
			this.ChangeRadioButton = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.TabControl.SuspendLayout();
			this.MainTabPage.SuspendLayout();
			this.ProgressTabPage.SuspendLayout();
			this.SelectTabPage.SuspendLayout();
			this.NameTabPage.SuspendLayout();
			this.ResultTabPage.SuspendLayout();
			this.MethodTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// BackgroundWorker
			// 
			this.BackgroundWorker.WorkerReportsProgress = true;
			this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			// 
			// AboutLabel
			// 
			this.AboutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AboutLabel.BackColor = System.Drawing.Color.Transparent;
			this.AboutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
			this.AboutLabel.Location = new System.Drawing.Point(12, 362);
			this.AboutLabel.Name = "AboutLabel";
			this.AboutLabel.Size = new System.Drawing.Size(536, 13);
			this.AboutLabel.TabIndex = 3;
			this.AboutLabel.Text = "Messenger Version Switcher 1.0";
			this.AboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AboutLabel.Click += new System.EventHandler(this.AboutLabel_Click);
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.MainTabPage);
			this.TabControl.Controls.Add(this.ProgressTabPage);
			this.TabControl.Controls.Add(this.SelectTabPage);
			this.TabControl.Controls.Add(this.NameTabPage);
			this.TabControl.Controls.Add(this.ResultTabPage);
			this.TabControl.Controls.Add(this.MethodTabPage);
			this.TabControl.Location = new System.Drawing.Point(12, 47);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(539, 250);
			this.TabControl.TabIndex = 2;
			// 
			// MainTabPage
			// 
			this.MainTabPage.Controls.Add(this.InstallButton);
			this.MainTabPage.Controls.Add(this.DeleteButton);
			this.MainTabPage.Controls.Add(this.SaveButton);
			this.MainTabPage.Controls.Add(this.SwitchButton);
			this.MainTabPage.Controls.Add(this.MainTitle);
			this.MainTabPage.Location = new System.Drawing.Point(4, 22);
			this.MainTabPage.Name = "MainTabPage";
			this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.MainTabPage.Size = new System.Drawing.Size(531, 224);
			this.MainTabPage.TabIndex = 0;
			this.MainTabPage.Text = "Main";
			this.MainTabPage.UseVisualStyleBackColor = true;
			// 
			// InstallButton
			// 
			this.InstallButton.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.InstallButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.InstallButton.Enabled = false;
			this.InstallButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.InstallButton.FlatAppearance.BorderSize = 0;
			this.InstallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
			this.InstallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.InstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.InstallButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InstallButton.ForeColor = System.Drawing.Color.Black;
			this.InstallButton.Image = global::MessengerVersionSwitcher.Properties.Resources.install;
			this.InstallButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.InstallButton.Location = new System.Drawing.Point(3, 178);
			this.InstallButton.Name = "InstallButton";
			this.InstallButton.Size = new System.Drawing.Size(525, 48);
			this.InstallButton.TabIndex = 13;
			this.InstallButton.Text = "   Install patched version\r\n   Installs the latest patched version of WLM to get " +
    "you connected to Escargot.";
			this.InstallButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.InstallButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.InstallButton.UseVisualStyleBackColor = true;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.DeleteButton.FlatAppearance.BorderSize = 0;
			this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
			this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.ForeColor = System.Drawing.Color.Black;
			this.DeleteButton.Image = global::MessengerVersionSwitcher.Properties.Resources.delete;
			this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.DeleteButton.Location = new System.Drawing.Point(3, 130);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(525, 48);
			this.DeleteButton.TabIndex = 11;
			this.DeleteButton.Text = "   Delete a version\r\n   Deletes a version if you don\'t need it anymore";
			this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.DeleteButton.UseVisualStyleBackColor = true;
			// 
			// SaveButton
			// 
			this.SaveButton.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.SaveButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.SaveButton.FlatAppearance.BorderSize = 0;
			this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
			this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveButton.ForeColor = System.Drawing.Color.Black;
			this.SaveButton.Image = global::MessengerVersionSwitcher.Properties.Resources.save;
			this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.SaveButton.Location = new System.Drawing.Point(3, 82);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(525, 48);
			this.SaveButton.TabIndex = 10;
			this.SaveButton.Text = "   Save a version\r\n   Saves your currently installed version for later use";
			this.SaveButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.SaveButton.UseVisualStyleBackColor = true;
			// 
			// SwitchButton
			// 
			this.SwitchButton.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.SwitchButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.SwitchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.SwitchButton.FlatAppearance.BorderSize = 0;
			this.SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
			this.SwitchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SwitchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SwitchButton.ForeColor = System.Drawing.Color.Black;
			this.SwitchButton.Image = global::MessengerVersionSwitcher.Properties.Resources.restore;
			this.SwitchButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.SwitchButton.Location = new System.Drawing.Point(3, 34);
			this.SwitchButton.Name = "SwitchButton";
			this.SwitchButton.Size = new System.Drawing.Size(525, 48);
			this.SwitchButton.TabIndex = 0;
			this.SwitchButton.Text = "   Switch to another version\r\n   Sets another version as your default for Windows" +
    " Live Messenger";
			this.SwitchButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.SwitchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.SwitchButton.UseVisualStyleBackColor = true;
			// 
			// MainTitle
			// 
			this.MainTitle.AutoSize = true;
			this.MainTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
			this.MainTitle.Location = new System.Drawing.Point(3, 3);
			this.MainTitle.Name = "MainTitle";
			this.MainTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.MainTitle.Size = new System.Drawing.Size(199, 31);
			this.MainTitle.TabIndex = 9;
			this.MainTitle.Text = "What would you like to do?";
			// 
			// ProgressTabPage
			// 
			this.ProgressTabPage.Controls.Add(this.ProgressBar);
			this.ProgressTabPage.Controls.Add(this.ProgressTitle);
			this.ProgressTabPage.Location = new System.Drawing.Point(4, 22);
			this.ProgressTabPage.Name = "ProgressTabPage";
			this.ProgressTabPage.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
			this.ProgressTabPage.Size = new System.Drawing.Size(531, 224);
			this.ProgressTabPage.TabIndex = 2;
			this.ProgressTabPage.Text = "Progress";
			this.ProgressTabPage.UseVisualStyleBackColor = true;
			// 
			// ProgressBar
			// 
			this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.ProgressBar.Location = new System.Drawing.Point(9, 34);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(513, 23);
			this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.ProgressBar.TabIndex = 10;
			// 
			// ProgressTitle
			// 
			this.ProgressTitle.AutoSize = true;
			this.ProgressTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.ProgressTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProgressTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
			this.ProgressTitle.Location = new System.Drawing.Point(9, 3);
			this.ProgressTitle.Name = "ProgressTitle";
			this.ProgressTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.ProgressTitle.Size = new System.Drawing.Size(199, 31);
			this.ProgressTitle.TabIndex = 12;
			this.ProgressTitle.Text = "What would you like to do?";
			// 
			// SelectTabPage
			// 
			this.SelectTabPage.Controls.Add(this.VersionPanel);
			this.SelectTabPage.Controls.Add(this.SelectDescription);
			this.SelectTabPage.Controls.Add(this.SelectTitle);
			this.SelectTabPage.Controls.Add(this.MainMenuLinkLabel2);
			this.SelectTabPage.Location = new System.Drawing.Point(4, 22);
			this.SelectTabPage.Name = "SelectTabPage";
			this.SelectTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.SelectTabPage.Size = new System.Drawing.Size(531, 224);
			this.SelectTabPage.TabIndex = 1;
			this.SelectTabPage.Text = "Select";
			this.SelectTabPage.UseVisualStyleBackColor = true;
			// 
			// VersionPanel
			// 
			this.VersionPanel.AutoScroll = true;
			this.VersionPanel.BackColor = System.Drawing.Color.Transparent;
			this.VersionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VersionPanel.Location = new System.Drawing.Point(3, 59);
			this.VersionPanel.Name = "VersionPanel";
			this.VersionPanel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.VersionPanel.Size = new System.Drawing.Size(525, 141);
			this.VersionPanel.TabIndex = 9;
			// 
			// SelectDescription
			// 
			this.SelectDescription.AutoSize = true;
			this.SelectDescription.BackColor = System.Drawing.Color.Transparent;
			this.SelectDescription.Dock = System.Windows.Forms.DockStyle.Top;
			this.SelectDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectDescription.ForeColor = System.Drawing.SystemColors.GrayText;
			this.SelectDescription.Location = new System.Drawing.Point(3, 34);
			this.SelectDescription.Name = "SelectDescription";
			this.SelectDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.SelectDescription.Size = new System.Drawing.Size(424, 25);
			this.SelectDescription.TabIndex = 10;
			this.SelectDescription.Text = "Switching to another version of Windows Live Messenger may take some time. ";
			this.SelectDescription.Visible = false;
			// 
			// SelectTitle
			// 
			this.SelectTitle.AutoSize = true;
			this.SelectTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.SelectTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
			this.SelectTitle.Location = new System.Drawing.Point(3, 3);
			this.SelectTitle.Name = "SelectTitle";
			this.SelectTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.SelectTitle.Size = new System.Drawing.Size(282, 31);
			this.SelectTitle.TabIndex = 8;
			this.SelectTitle.Text = "Select a Messenger version to switch to";
			// 
			// MainMenuLinkLabel2
			// 
			this.MainMenuLinkLabel2.AutoSize = true;
			this.MainMenuLinkLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.MainMenuLinkLabel2.Location = new System.Drawing.Point(3, 200);
			this.MainMenuLinkLabel2.Name = "MainMenuLinkLabel2";
			this.MainMenuLinkLabel2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
			this.MainMenuLinkLabel2.Size = new System.Drawing.Size(143, 21);
			this.MainMenuLinkLabel2.TabIndex = 17;
			this.MainMenuLinkLabel2.TabStop = true;
			this.MainMenuLinkLabel2.Text = "Return back to main menu";
			this.MainMenuLinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MainMenuLinkLabel_LinkClicked);
			// 
			// NameTabPage
			// 
			this.NameTabPage.Controls.Add(this.CustomNameRadioButton);
			this.NameTabPage.Controls.Add(this.NameContinueButton);
			this.NameTabPage.Controls.Add(this.NameTextBox);
			this.NameTabPage.Controls.Add(this.AutoNameRadioButton);
			this.NameTabPage.Controls.Add(this.NameTitle);
			this.NameTabPage.Location = new System.Drawing.Point(4, 22);
			this.NameTabPage.Name = "NameTabPage";
			this.NameTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.NameTabPage.Size = new System.Drawing.Size(531, 224);
			this.NameTabPage.TabIndex = 3;
			this.NameTabPage.Text = "Name";
			this.NameTabPage.UseVisualStyleBackColor = true;
			// 
			// CustomNameRadioButton
			// 
			this.CustomNameRadioButton.AutoSize = true;
			this.CustomNameRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.CustomNameRadioButton.Location = new System.Drawing.Point(3, 53);
			this.CustomNameRadioButton.Name = "CustomNameRadioButton";
			this.CustomNameRadioButton.Padding = new System.Windows.Forms.Padding(5, 15, 0, 0);
			this.CustomNameRadioButton.Size = new System.Drawing.Size(525, 32);
			this.CustomNameRadioButton.TabIndex = 15;
			this.CustomNameRadioButton.Text = "Name my backup the following:";
			this.CustomNameRadioButton.UseVisualStyleBackColor = true;
			this.CustomNameRadioButton.CheckedChanged += new System.EventHandler(this.CustomNameRadioButton_CheckedChanged);
			// 
			// NameContinueButton
			// 
			this.NameContinueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NameContinueButton.Location = new System.Drawing.Point(450, 195);
			this.NameContinueButton.Name = "NameContinueButton";
			this.NameContinueButton.Size = new System.Drawing.Size(75, 23);
			this.NameContinueButton.TabIndex = 17;
			this.NameContinueButton.Text = "&Continue";
			this.NameContinueButton.UseVisualStyleBackColor = true;
			this.NameContinueButton.Click += new System.EventHandler(this.NameContinueButton_Click);
			// 
			// NameTextBox
			// 
			this.NameTextBox.Enabled = false;
			this.NameTextBox.Location = new System.Drawing.Point(27, 91);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(210, 22);
			this.NameTextBox.TabIndex = 16;
			// 
			// AutoNameRadioButton
			// 
			this.AutoNameRadioButton.AutoSize = true;
			this.AutoNameRadioButton.Checked = true;
			this.AutoNameRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.AutoNameRadioButton.Location = new System.Drawing.Point(3, 34);
			this.AutoNameRadioButton.Name = "AutoNameRadioButton";
			this.AutoNameRadioButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
			this.AutoNameRadioButton.Size = new System.Drawing.Size(525, 19);
			this.AutoNameRadioButton.TabIndex = 14;
			this.AutoNameRadioButton.TabStop = true;
			this.AutoNameRadioButton.Text = "Do it automatically based on my version";
			this.AutoNameRadioButton.UseVisualStyleBackColor = true;
			// 
			// NameTitle
			// 
			this.NameTitle.AutoSize = true;
			this.NameTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.NameTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
			this.NameTitle.Location = new System.Drawing.Point(3, 3);
			this.NameTitle.Name = "NameTitle";
			this.NameTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.NameTitle.Size = new System.Drawing.Size(306, 31);
			this.NameTitle.TabIndex = 13;
			this.NameTitle.Text = "How would you like to name your version?";
			// 
			// ResultTabPage
			// 
			this.ResultTabPage.Controls.Add(this.HelpLabel);
			this.ResultTabPage.Controls.Add(this.ErrorTextBox);
			this.ResultTabPage.Controls.Add(this.ErrorInfoLinkLabel);
			this.ResultTabPage.Controls.Add(this.MainMenuLinkLabel);
			this.ResultTabPage.Controls.Add(this.ResultTitle);
			this.ResultTabPage.Location = new System.Drawing.Point(4, 22);
			this.ResultTabPage.Name = "ResultTabPage";
			this.ResultTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ResultTabPage.Size = new System.Drawing.Size(531, 224);
			this.ResultTabPage.TabIndex = 4;
			this.ResultTabPage.Text = "Result";
			this.ResultTabPage.UseVisualStyleBackColor = true;
			// 
			// HelpLabel
			// 
			this.HelpLabel.AutoSize = true;
			this.HelpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HelpLabel.Location = new System.Drawing.Point(3, 76);
			this.HelpLabel.Name = "HelpLabel";
			this.HelpLabel.Size = new System.Drawing.Size(200, 39);
			this.HelpLabel.TabIndex = 18;
			this.HelpLabel.Text = "Things you can try:\r\n   - Restart MVS as administrator\r\n   - Check if Messenger i" +
    "s not running";
			// 
			// ErrorTextBox
			// 
			this.ErrorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ErrorTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ErrorTextBox.Location = new System.Drawing.Point(3, 76);
			this.ErrorTextBox.Multiline = true;
			this.ErrorTextBox.Name = "ErrorTextBox";
			this.ErrorTextBox.ReadOnly = true;
			this.ErrorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ErrorTextBox.Size = new System.Drawing.Size(525, 145);
			this.ErrorTextBox.TabIndex = 15;
			this.ErrorTextBox.Visible = false;
			this.ErrorTextBox.WordWrap = false;
			// 
			// ErrorInfoLinkLabel
			// 
			this.ErrorInfoLinkLabel.AutoSize = true;
			this.ErrorInfoLinkLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ErrorInfoLinkLabel.Location = new System.Drawing.Point(3, 55);
			this.ErrorInfoLinkLabel.Name = "ErrorInfoLinkLabel";
			this.ErrorInfoLinkLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.ErrorInfoLinkLabel.Size = new System.Drawing.Size(128, 21);
			this.ErrorInfoLinkLabel.TabIndex = 17;
			this.ErrorInfoLinkLabel.TabStop = true;
			this.ErrorInfoLinkLabel.Text = "Show error information";
			this.ErrorInfoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ErrorInfoLinkLabel_LinkClicked);
			// 
			// MainMenuLinkLabel
			// 
			this.MainMenuLinkLabel.AutoSize = true;
			this.MainMenuLinkLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.MainMenuLinkLabel.Location = new System.Drawing.Point(3, 34);
			this.MainMenuLinkLabel.Name = "MainMenuLinkLabel";
			this.MainMenuLinkLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.MainMenuLinkLabel.Size = new System.Drawing.Size(143, 21);
			this.MainMenuLinkLabel.TabIndex = 16;
			this.MainMenuLinkLabel.TabStop = true;
			this.MainMenuLinkLabel.Text = "Return back to main menu";
			this.MainMenuLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MainMenuLinkLabel_LinkClicked);
			// 
			// ResultTitle
			// 
			this.ResultTitle.AutoSize = true;
			this.ResultTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.ResultTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResultTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
			this.ResultTitle.Location = new System.Drawing.Point(3, 3);
			this.ResultTitle.Name = "ResultTitle";
			this.ResultTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.ResultTitle.Size = new System.Drawing.Size(219, 31);
			this.ResultTitle.TabIndex = 14;
			this.ResultTitle.Text = "Your operation was successful";
			// 
			// MethodTabPage
			// 
			this.MethodTabPage.Controls.Add(this.DeleteWarningLabel);
			this.MethodTabPage.Controls.Add(this.CopyFilesLabel);
			this.MethodTabPage.Controls.Add(this.FileCopyRadioButton);
			this.MethodTabPage.Controls.Add(this.ChangeLabel);
			this.MethodTabPage.Controls.Add(this.ChangeRadioButton);
			this.MethodTabPage.Controls.Add(this.label1);
			this.MethodTabPage.Location = new System.Drawing.Point(4, 22);
			this.MethodTabPage.Name = "MethodTabPage";
			this.MethodTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.MethodTabPage.Size = new System.Drawing.Size(531, 224);
			this.MethodTabPage.TabIndex = 5;
			this.MethodTabPage.Text = "Method";
			this.MethodTabPage.UseVisualStyleBackColor = true;
			// 
			// DeleteWarningLabel
			// 
			this.DeleteWarningLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.DeleteWarningLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteWarningLabel.ForeColor = System.Drawing.Color.Red;
			this.DeleteWarningLabel.Location = new System.Drawing.Point(3, 154);
			this.DeleteWarningLabel.Name = "DeleteWarningLabel";
			this.DeleteWarningLabel.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
			this.DeleteWarningLabel.Size = new System.Drawing.Size(525, 14);
			this.DeleteWarningLabel.TabIndex = 21;
			this.DeleteWarningLabel.Text = "All old files inside the installation folder will be deleted. Make sure you saved" +
    " the old version.";
			// 
			// CopyFilesLabel
			// 
			this.CopyFilesLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.CopyFilesLabel.Location = new System.Drawing.Point(3, 123);
			this.CopyFilesLabel.Name = "CopyFilesLabel";
			this.CopyFilesLabel.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
			this.CopyFilesLabel.Size = new System.Drawing.Size(525, 31);
			this.CopyFilesLabel.TabIndex = 20;
			this.CopyFilesLabel.Text = "All files inside the installation folder of Messenger will be replaced. This meth" +
    "od might break less things.";
			// 
			// FileCopyRadioButton
			// 
			this.FileCopyRadioButton.AutoSize = true;
			this.FileCopyRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.FileCopyRadioButton.Location = new System.Drawing.Point(3, 96);
			this.FileCopyRadioButton.Name = "FileCopyRadioButton";
			this.FileCopyRadioButton.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
			this.FileCopyRadioButton.Size = new System.Drawing.Size(525, 27);
			this.FileCopyRadioButton.TabIndex = 18;
			this.FileCopyRadioButton.Text = "Don\'t change anything except for the files (recommended)";
			this.FileCopyRadioButton.UseVisualStyleBackColor = true;
			// 
			// ChangeLabel
			// 
			this.ChangeLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ChangeLabel.Location = new System.Drawing.Point(3, 53);
			this.ChangeLabel.Name = "ChangeLabel";
			this.ChangeLabel.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
			this.ChangeLabel.Size = new System.Drawing.Size(525, 43);
			this.ChangeLabel.TabIndex = 19;
			this.ChangeLabel.Text = "Registry entries pointing to the installation folder will be changed to MVS, also" +
    " a new shortcut will be created on your desktop linking to MVS. When opened MVS " +
    "will launch the right version.";
			// 
			// ChangeRadioButton
			// 
			this.ChangeRadioButton.AutoSize = true;
			this.ChangeRadioButton.Checked = true;
			this.ChangeRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.ChangeRadioButton.Location = new System.Drawing.Point(3, 34);
			this.ChangeRadioButton.Name = "ChangeRadioButton";
			this.ChangeRadioButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
			this.ChangeRadioButton.Size = new System.Drawing.Size(525, 19);
			this.ChangeRadioButton.TabIndex = 17;
			this.ChangeRadioButton.TabStop = true;
			this.ChangeRadioButton.Text = "Change system entries to make them link to MVS";
			this.ChangeRadioButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.label1.Size = new System.Drawing.Size(329, 31);
			this.label1.TabIndex = 16;
			this.label1.Text = "How would you like to switch to your version?";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(563, 384);
			this.Controls.Add(this.AboutLabel);
			this.Controls.Add(this.TabControl);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Messenger Version Switcher";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.TabControl.ResumeLayout(false);
			this.MainTabPage.ResumeLayout(false);
			this.MainTabPage.PerformLayout();
			this.ProgressTabPage.ResumeLayout(false);
			this.ProgressTabPage.PerformLayout();
			this.SelectTabPage.ResumeLayout(false);
			this.SelectTabPage.PerformLayout();
			this.NameTabPage.ResumeLayout(false);
			this.NameTabPage.PerformLayout();
			this.ResultTabPage.ResumeLayout(false);
			this.ResultTabPage.PerformLayout();
			this.MethodTabPage.ResumeLayout(false);
			this.MethodTabPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private WizardPages TabControl;
		private System.Windows.Forms.TabPage MainTabPage;
		private System.Windows.Forms.Button SwitchButton;
		private System.Windows.Forms.TabPage SelectTabPage;
		private System.Windows.Forms.Panel VersionPanel;
		private System.Windows.Forms.Label SelectDescription;
		private System.Windows.Forms.Label SelectTitle;
		private System.Windows.Forms.TabPage ProgressTabPage;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Label MainTitle;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button InstallButton;
		private System.Windows.Forms.Label ProgressTitle;
		private System.ComponentModel.BackgroundWorker BackgroundWorker;
		private System.Windows.Forms.TabPage NameTabPage;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.RadioButton CustomNameRadioButton;
		private System.Windows.Forms.RadioButton AutoNameRadioButton;
		private System.Windows.Forms.Label NameTitle;
		private System.Windows.Forms.TabPage ResultTabPage;
		private System.Windows.Forms.TextBox ErrorTextBox;
		private System.Windows.Forms.LinkLabel MainMenuLinkLabel;
		private System.Windows.Forms.Label ResultTitle;
		private System.Windows.Forms.LinkLabel MainMenuLinkLabel2;
		private System.Windows.Forms.LinkLabel ErrorInfoLinkLabel;
		private System.Windows.Forms.Button NameContinueButton;
		private System.Windows.Forms.Label AboutLabel;
		private System.Windows.Forms.Label HelpLabel;
		private System.Windows.Forms.TabPage MethodTabPage;
		private System.Windows.Forms.Label DeleteWarningLabel;
		private System.Windows.Forms.Label CopyFilesLabel;
		private System.Windows.Forms.RadioButton FileCopyRadioButton;
		private System.Windows.Forms.Label ChangeLabel;
		private System.Windows.Forms.RadioButton ChangeRadioButton;
		private System.Windows.Forms.Label label1;
	}
}

