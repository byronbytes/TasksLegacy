using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Tasks
{
    public partial class frmTaskManager : Form
    {
        public frmTaskManager()
        {
            InitializeComponent();
        }

        Process[] proc;

        void GetAllProcess()
        {
            proc = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process p in proc)
                listBox1.Items.Add(p.ProcessName);
        }
        private void frmTaskManager_Load(object sender, System.EventArgs e)
        {
            GetAllProcess();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                proc[listBox1.SelectedIndex].Kill();
                GetAllProcess();
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
  
        }

 
    }
}
