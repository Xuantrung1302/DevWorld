using DevEduManager.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmMessageDialog : Form
    {
        public frmMessageDialog()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Option 2: Đóng frmMain và quay về frmDangNhap
            frmDangNhap frmDangNhap = new frmDangNhap();
            this.Hide(); // Ẩn frmMain trước khi mở frmDangNhap
            frmDangNhap.ShowDialog();
            this.Close(); // Đóng frmMain sau khi frmDangNhap được mở
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
