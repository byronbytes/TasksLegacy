using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
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
            frmStartupManager StartupManager = new frmStartupManager(); // Initialize cleanup form.
            StartupManager.Show(); // Show Form
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
    }
}
