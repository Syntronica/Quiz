using System;
using System.Windows.Forms;

namespace Quiz
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        // 
        private void FrmInfo_Load(object sender, EventArgs e)
        {
        }

        private void picWebseite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://d-sch.com/");
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
