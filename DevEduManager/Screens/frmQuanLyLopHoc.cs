using DevEduManager.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyLopHoc : Form
    {
        public frmQuanLyLopHoc()
        {
            InitializeComponent();
        }

        // <summary>
        /// Kiểm tra nhập liệu tìm kiếm có hợp lệ
        /// </summary>
        public void ValidateSearch()
        {
            if (chkTenMon.Checked && txtTenMon.Text == string.Empty)
                throw new ArgumentException("Mã lớp không được trống");
            if (chkTenLop.Checked && txtTenLop.Text == string.Empty)
                throw new ArgumentException("Tên lớp không được trống");
        }

        #region
        private void frmQuanLyLopHoc_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //frmLopHocEdit frm = new frmLopHocEdit();
            //frm.Text = "Thêm lớp mới";
            //frm.ShowDialog();

            //btnHienTatCa_Click(sender, e);
        }

        private void chkMaLop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTenLop_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            frmThemHocVienVaoLop frm = new frmThemHocVienVaoLop();
            frm.ShowDialog();
        }

    }
}
