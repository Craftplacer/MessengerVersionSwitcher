using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace MessengerVersionSwitcher
{
	internal static class Program
	{
        public const string AppName = "Messenger Version Switcher";
        public static bool Is64Bit = !string.IsNullOrEmpty( Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		private static void Main()
		{
            try
            {
                var args = Environment.GetCommandLineArgs();
                if (args.Contains("-s"))
                {
                    CreateShortcut();
                }
                else if (args.Contains("-l"))
                {
                    var cb = Properties.Settings.Default.CurrentBackup;
                    var d = MsnBackup.GetBackups().First(b => Path.GetFileName(b.Directory) == cb).Directory;
                    Process.Start(Path.Combine(d, "msnmsgr.exe"));
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show($"{AppName} has crashed because of {ex.Message}. \nWould you like to copy the crash report?", AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText($"{AppName} Crash Report: \n{ex.ToString()}");
                    MessageBox.Show("The crash report has been copied. You can sent this report to Craftplacer over the MessengerGeek forum.", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
		}

		public static void CreateShortcut()
		{
			string link = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Windows Live Messenger.lnk");
			var shortcut = new WshShell().CreateShortcut(link) as IWshShortcut;
			shortcut.TargetPath = Application.ExecutablePath;
			shortcut.WorkingDirectory = Application.StartupPath;
			shortcut.Arguments = "-l";
			shortcut.WindowStyle = (int)WshWindowStyle.WshNormalFocus;

			var cb = Properties.Settings.Default.CurrentBackup;
			var d = MsnBackup.GetBackups().First(b => Path.GetFileName(b.Directory) == cb).Directory;

			shortcut.IconLocation = Path.GetFullPath(Path.Combine(d, "msnmsgr.exe")) + ",1";
			shortcut.Save();
		}
	}
}