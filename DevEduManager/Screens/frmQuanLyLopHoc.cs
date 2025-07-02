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
            if (chkMaLop.Checked && txtMaLop.Text == string.Empty)
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

        private void chkKhoa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkKhoangTG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTinhTrang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void rdDong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdMo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTongCong_Click(object sender, EventArgs e)
        {

        }

        private void lblSiSo_Click(object sender, EventArgs e)
        {

        }

        private void lblNgayKetThuc_Click(object sender, EventArgs e)
        {

        }

        private void lblNgayBatDau_Click(object sender, EventArgs e)
        {

        }

        private void lblKhoa_Click(object sender, EventArgs e)
        {

        }

        private void lblMaLop_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void lblTenLop_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
