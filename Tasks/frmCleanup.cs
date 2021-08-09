﻿using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Security;
namespace Tasks
{
    public partial class FrmCleanup : Form
    {
        public FrmCleanup() => InitializeComponent();

        [DllImport("Shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);
        enum RecycleFlag : int
        {
            SHERB_NOCONFIRMATION = 0x00000001, // No confirmation, when emptying
            SHERB_NOPROGRESSUI = 0x00000001, // No progress tracking window during the emptying of the recycle bin
            SHERB_NOSOUND = 0x00000004 // No sound when the emptying of the recycle bin is complete
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            {
                taskDialog1.Show();
                CleanupLogsLBox.Items.Add("Error: Did not select anything to clean.");
                return;
            }

            if (checkBox1.Checked)
            {
                SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlag.SHERB_NOSOUND | RecycleFlag.SHERB_NOCONFIRMATION);
                CleanupLogsLBox.Items.Add("Recycle Bin Cleaned.");
            }

            if (checkBox2.Checked)
            {
                var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads");
                if (DeleteAllFiles(directory)) CleanupLogsLBox.Items.Add("Downloads Folder Cleaned.");
            }

            if (checkBox3.Checked)
            {
                var directory = new DirectoryInfo("C:\\Windows\\Temp");
                if (DeleteAllFiles(directory)) CleanupLogsLBox.Items.Add("Windows Temp Folder Cleaned.");

                directory = new DirectoryInfo(Path.GetTempPath());
                if (DeleteAllFiles(directory)) CleanupLogsLBox.Items.Add("AppData Temp Folder Cleaned.");
            }

            if (checkBox4.Checked)
            {
                var directory = new DirectoryInfo("C:\\Windows\\Prefetch");
                if (DeleteAllFiles(directory)) CleanupLogsLBox.Items.Add("Prefetch Cleaned.");
            }

            if (CleanupLogsLBox.Items.Count > 1) CopyLogsBtn.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CleanupLogsLBox.Items.Add("Debug log copied to clipboard.");
            Clipboard.SetText(string.Join("\n", CleanupLogsLBox.Items.Cast<string>()));
        }

        private bool DeleteAllFiles(DirectoryInfo directoryInfo)
        {
            try
            {
                foreach (var file in directoryInfo.GetFiles())
                {
                    file.Delete();
                    CleanupLogsLBox.Items.Add("Deleted " + file.FullName);
                }

                foreach (var directory in directoryInfo.GetDirectories())
                {
                    directory.Delete(true);
                    CleanupLogsLBox.Items.Add("Deleted " + directory.FullName);
                }

                return true;
            }
            catch (Exception ex) when (ex is IOException || ex is DirectoryNotFoundException || ex is UnauthorizedAccessException || ex is SecurityException)
            {
                CleanupLogsLBox.Items.Add("Exception Error: " + ex.Message);
            }

            return false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


