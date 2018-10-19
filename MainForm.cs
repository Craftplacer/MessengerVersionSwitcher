using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MessengerVersionSwitcher
{
	public partial class MainForm : Form
	{
		private string CurrentTab = "main";
		private string CurrentBackupName;
		private MsnBackupVersion CurrentBackup;

		public MainForm()
		{
			InitializeComponent();
			this.SwitchButton.Click += (s, e) => SwitchTab("switch");
			this.SaveButton.Click += (s, e) => SwitchTab("save");
			this.DeleteButton.Click += (s, e) => SwitchTab("delete");
			this.InstallButton.Click += (s, e) => SwitchTab("install");
			this.BackgroundWorker.ProgressChanged += (s, e) =>
			{
				if (e.ProgressPercentage == -1)
				{
					ProgressBar.Style = ProgressBarStyle.Marquee;
				}
				else
				{
					ProgressBar.Style = ProgressBarStyle.Continuous;
					ProgressBar.Value = e.ProgressPercentage;
				}
			};
			this.BackgroundWorker.RunWorkerCompleted += (s, e) =>
			{
				ResultTitle.Text = $"Your operation was {(e.Error == null ? String.Empty : "un")}successful";
				ErrorInfoLinkLabel.Visible = e.Error != null;
				if (e.Error != null)
				{
					ErrorTextBox.Text = e.Error.ToString();
				}
				SwitchTab("result");
			};
		}

		public void SwitchTab(string tab)
		{
			switch (tab)
			{
				case "main":
					this.TabControl.SelectTab(nameof(MainTabPage));
					break;

				case "switch":
					SelectTitle.Text = "Select a Messenger version you would like to switch to";
					//SelectDescription.Text = "Switching to another version may take some time.";
					ListAllVersions();
					this.TabControl.SelectTab(nameof(SelectTabPage));
					break;

				case "save":
					SwitchTab("name");
					break;

				case "delete":
					SelectTitle.Text = "Select a Messenger version you would like to delete";
					//SelectDescription.Text = "Deleting to a version may take some time.";
					ListAllVersions();
					this.TabControl.SelectTab(nameof(SelectTabPage));
					break;

				case "progress":
					var job = new BackgroundWorkerJob()
					{
						Action = CurrentTab,
						Backup = CurrentBackup,
					};
					if (CurrentTab == "save")
					{
						var dialog = new OpenFileDialog()
						{
							Title = "Please locate the Windows Live Messenger Version you would like to save",
							CheckFileExists = true,
							CheckPathExists = true,
							Filter = "Messenger (msnmsgr.exe)|msnmsgr.exe"
						};
						if (dialog.ShowDialog() == DialogResult.OK)
						{
							job.SaveMessengerPath = dialog.FileName;
						}
						else
						{
							SwitchTab("main");
							return;
						}
					}
					this.TabControl.SelectTab(nameof(ProgressTabPage));
					ProgressTitle.Text = "Please wait";
					BackgroundWorker.RunWorkerAsync(job);

					break;

				case "name":
					this.TabControl.SelectTab(nameof(NameTabPage));
					break;

				case "result":
					this.TabControl.SelectTab(nameof(ResultTabPage));
					break;

				default: throw new Exception("Unknown Tab Name: " + tab);
			}
			CurrentTab = tab;
		}

		public void ListAllVersions()
		{
			VersionPanel.Controls.Clear();
			var backups = MsnBackup.GetBackups();
			if (backups.Count != 0)
			{
				foreach (MsnBackupVersion backup in backups)
				{
					var button = new Button()
					{
						Text = $"   {backup.Title}\n   Build {backup.BuildVersion}",
						TextImageRelation = TextImageRelation.ImageBeforeText,
						Dock = DockStyle.Top,
						FlatStyle = FlatStyle.Flat,
						Tag = backup,
						Height = 48,
						TextAlign = ContentAlignment.TopLeft,
						ImageAlign = ContentAlignment.TopLeft,
					};
					button.Image = backup.BuildVersion.Major > 8 ? Properties.Resources.messenger14 : Properties.Resources.messenger8;
					button.FlatAppearance.BorderSize = 0;
					button.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
					button.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
					button.FlatAppearance.BorderColor = Color.White;

					button.Click += (s, e) =>
					{
						CurrentBackup = backup;
						SwitchTab("progress");
					};
					VersionPanel.Controls.Add(button);
				}
			}
			else
			{
				var label = new Label()
				{
					Text = "You don't have any saved versions.",
					AutoSize = false,
					TextAlign = ContentAlignment.MiddleCenter,
					ForeColor = SystemColors.GrayText,
					Dock = DockStyle.Fill,
				};
				VersionPanel.Controls.Add(label);
			}
		}

		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			var job = (BackgroundWorkerJob)e.Argument;
			MsnBackup.CheckDirectory();
			switch (job.Action)
			{
				case "save":

					var target = MsnBackup.GetNextAvailableDirectoryPath();
					var directory = Path.GetDirectoryName(job.SaveMessengerPath);
					//Now Create all of the directories
					foreach (string dirPath in Directory.GetDirectories(directory, "*",
						SearchOption.AllDirectories))
						Directory.CreateDirectory(dirPath.Replace(directory, target));
					var files = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);

					for (int i = 0; i < files.Length; i++)
					{
						string newPath = files[i];
						File.Copy(newPath, newPath.Replace(directory, target), true);
						SetProgress(i, files.Length);
					}

					string title;
					if (CurrentBackupName == null)
					{
						title = "No title";
					}
					else if (CurrentBackupName == "#auto")
					{
						var dict = new Dictionary<int, string>()
						{
							{ 1,"MSN Messenger Service"},
							{ 2,"MSN Messenger Service"},
							{ 3,"MSN Messenger Service"},
							{ 4,"MSN Messenger"},
							{ 5,"MSN Messenger"},
							{ 6,"MSN Messenger"},
							{ 7,"MSN Messenger"},
							{ 8,"Windows Live Messenger"},
							{ 14,"Windows Live Messenger"},
							{ 15,"Windows Live Messenger"},
							{ 16,"Windows Live Messenger"},
						};
						var ver = MsnBackup.GetVersion(Path.Combine(directory, "msnmsgr.exe"));
						title = $"{dict[ver.Major]} {ver.Major}.{ver.Minor}";
					}
					else
					{
						title = CurrentBackupName;
					}
					File.WriteAllText(Path.Combine(target, "title.msnbackup"), title);
					break;

				case "delete":
					BackgroundWorker.ReportProgress(-1);
					Directory.Delete(job.Backup.Directory, true);
					BackgroundWorker.ReportProgress(100);
					break;

				case "switch":
					Properties.Settings.Default.CurrentBackup = Path.GetFileName(job.Backup.Directory);
					Properties.Settings.Default.Save();
					Program.CreateShortcut();
					var TypeLib = new Dictionary<string, int>()
					{
						{ @"SOFTWARE\Classes\TypeLib\{53CED51D-432B-45B2-A3E0-0CE2C24235D4}\1.0\0\win32",1 },
						{ @"SOFTWARE\Classes\TypeLib\{15FB1006-158D-4bb9-816A-7B4EC5FDF96B}\1.0\0\win32",8 },
						{ @"SOFTWARE\Classes\TypeLib\{1FA4B99F-3155-4A26-837B-9734C1297A1B}\1.0\0\win32",6 },
						{ @"SOFTWARE\Classes\TypeLib\{36C8B6E8-7013-462A-85B7-298F91FBC783}\1.0\0\win32",5 },
						{ @"SOFTWARE\Classes\TypeLib\{C1637F37-3FC8-4B37-B3B2-6CC5E202390D}\1.0\0\win32",7 },
						{ @"SOFTWARE\Classes\TypeLib\{E02AD29E-80F5-46C6-B416-9B3EBDDF057E}\1.0\0\win32",2 },
					};
					foreach (var item in TypeLib)
					{
                        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, /*Program.Is64Bit ? RegistryView.Registry64 :*/ RegistryView.Registry32))
                        {
							var key = hklm.OpenSubKey(item.Key, true);
							if (key == null)
							{
								hklm.CreateSubKey(item.Key);
								key = hklm.OpenSubKey(item.Key, true);
							}
							if (key != null)
							{
								key.SetValue("", $"{Path.GetFullPath(Path.Combine(job.Backup.Directory, "msnmsgr.exe"))}\\{item.Value}", RegistryValueKind.String);
								key.Close();
							}
						}
                    }
					break;
			}
		}

		private void SetProgress(int val, int max)
		{
			var percentage = (int)(((double)val / (double)max) * 100.0);
			BackgroundWorker.ReportProgress(percentage);
		}

		private void MainMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => SwitchTab("main");

		private void ErrorInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ErrorTextBox.Visible = !ErrorTextBox.Visible;
			HelpLabel.Visible = !ErrorTextBox.Visible;
			ErrorInfoLinkLabel.Text = $"{(ErrorTextBox.Visible ? "Hide" : "Show")} error information";
		}

		private void CustomNameRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			NameTextBox.Enabled = CustomNameRadioButton.Checked;
		}

		private void AboutLabel_Click(object sender, EventArgs e) => MessageBox.Show("Made by Craftplacer(#4006/@outlook.de)");

		private void NameContinueButton_Click(object sender, EventArgs e)
		{
			if (AutoNameRadioButton.Checked)
			{
				CurrentBackupName = "#auto";
			}
			else if (CustomNameRadioButton.Checked)
			{
				CurrentBackupName = NameTextBox.Text;
			}
			CurrentTab = "save";
			SwitchTab("progress");
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}