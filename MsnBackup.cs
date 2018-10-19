using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerVersionSwitcher
{
	public static class MsnBackup
	{
		public static string BackupPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "backups");

		public static List<MsnBackupVersion> GetBackups()
		{
			var list = new List<MsnBackupVersion>();
			if (!CheckDirectory())
			{
				return list;
			}
			foreach (string dir in Directory.GetDirectories(BackupPath))
			{
				var backup = new MsnBackupVersion();

				var titlePath = Path.Combine(dir, "title.msnbackup");
				if (File.Exists(titlePath))
				{
					backup.Title = File.ReadAllText(titlePath);
				}
				else
				{
					backup.Title = "No Title";
				}

				var msgrPath = Path.Combine(dir, "msnmsgr.exe");
				if (!File.Exists(msgrPath))
				{
					throw new Exception("Backup is invalid: Directory does exists but WLM (msnmsgr.exe) couldn't be found");
				}
				backup.BuildVersion = GetVersion(msgrPath);
				backup.Directory = dir;

				list.Add(backup);
			}
			return list;
		}

		public static Version GetVersion(string filePath) => Version.Parse(FileVersionInfo.GetVersionInfo(filePath).FileVersion);

		public static bool CheckDirectory()
		{
			if (!Directory.Exists(BackupPath))
			{
				Directory.CreateDirectory(BackupPath);
				return false;
			}
			return true;
		}

		public static string GetNextAvailableDirectoryPath()
		{
			var n = 0;
			while (Directory.Exists(Path.Combine(BackupPath, n.ToString())))
			{
				n++;
			}
			return Path.GetFullPath(Path.Combine(BackupPath, n.ToString()));
		}
	}

	public class MsnBackupVersion
	{
		public string Directory { get; set; }
		public string Title { get; set; }
		public Version BuildVersion { get; set; }
	}

	public class BackgroundWorkerJob
	{
		public MsnBackupVersion Backup { get; set; }
		public string Action { get; set; }
		public string SaveMessengerPath { get; set; }
	}
}