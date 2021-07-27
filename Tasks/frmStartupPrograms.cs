using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class frmStartupPrograms : Form
    {
        public frmStartupPrograms()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmStartupManager_Load(object sender, EventArgs e)
        {
            ManagementClass mangnmt = new ManagementClass("Win32_StartupCommand");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            foreach (ManagementObject strt in mcol)
            {
                listView1.Items.Add(strt["Name"].ToString(), 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vistaOpenFileDialog1.ShowDialog();
        }

        private void vistaOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = vistaOpenFileDialog1.FileName;
            string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +"\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";

            listView1.Items.Add(vistaOpenFileDialog1.FileName);
            Directory.Move(fileName, targetPath);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup");
        }
    }
}
