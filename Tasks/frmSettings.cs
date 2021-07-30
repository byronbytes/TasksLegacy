using System.Drawing;
using System.Windows.Forms;

namespace Tasks
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.BackColor = Color.FromArgb(235, 230, 235);
            frmMain Main = new frmMain(); // Initialize form
            Main.BackColor = Color.FromArgb(235, 230, 235);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.BackColor = Color.FromArgb(48, 48, 48);
        }
    }
}
