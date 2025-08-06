using DevEduManager.Screens;
using System;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmMessageDialog : Form
    {
        private frmMain mainForm;

        public frmMessageDialog(frmMain main)
        {
            InitializeComponent();
            this.mainForm = main;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.DangXuat();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
