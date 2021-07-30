using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Tasks
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCleanup Cleanup = new frmCleanup(); // Initialize cleanup form.
            Cleanup.Show(); // Show Form
        }



        private void button3_Click(object sender, EventArgs e)
        {
            frmStartupPrograms StartupPrograms = new frmStartupPrograms(); // Initialize cleanup form.
            StartupPrograms.Show(); // Show Form
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/byronbytes/Tasks/issues/new?assignees=byronbytes&labels=bug&template=bug-report.md&title=");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmChangelog Changelog = new frmChangelog(); // Initialize cleanup form.
            Changelog.Show(); // Show Form
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/byronbytes/Tasks");
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblComputerName.Text = "PC Name: " + Environment.MachineName;
            lblUserName.Text = "User Name: " + Environment.UserName;
            lblRootDirectory.Text = "Root Directory: " + Environment.SystemDirectory;
            lblOSVer.Text = "OS Version: " + Environment.Version;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmTaskManager TaskManager = new frmTaskManager(); // Initialize cleanup form.
            TaskManager.Show(); // Show Form
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSettings Settings = new frmSettings(); // Initialize cleanup form.
            Settings.Show(); // Show Form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/SeESEAaenv");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Lite_Tools");
        }

        private void btnSiteBlocker_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/byronbytes/Tasks");
        }
    }


}
