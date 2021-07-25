using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class frmStartupManager : Form
    {
        public frmStartupManager()
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
    }
}
