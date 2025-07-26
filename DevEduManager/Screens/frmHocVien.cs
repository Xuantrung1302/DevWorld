using System;
using System.Data;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmHocVien : Form
    {
        private int currentPage = 1;
        private int totalPage = 1;
        private DataTable dtHocVien;

        public frmHocVien()
        {
            InitializeComponent();
            LoadHocVien();
        }

        private void LoadHocVien()
        {
            // Demo data
            dtHocVien = new DataTable();
            dtHocVien.Columns.Add("MaHV");
            dtHocVien.Columns.Add("TenHV");
            dtHocVien.Columns.Add("NgaySinh");
            dtHocVien.Columns.Add("GioiTinh");
            dtHocVien.Columns.Add("SdtHV");
            dtHocVien.Columns.Add("DiaChi");
            dtHocVien.Columns.Add("NgayTiepNhan");
            dtHocVien.Columns.Add("Email");

            for (int i = 1; i <= 50; i++)
            {
                dtHocVien.Rows.Add("HV" + i, "Học viên " + i, "01/01/2000", "Nam", "0123456789", "Hà Nội", "01/07/2023", "hv" + i + "@gmail.com");
            }

            gridDSHV.DataSource = dtHocVien;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                gridDSHV.DataSource = dtHocVien;
            }
            else
            {
                DataView dv = new DataView(dtHocVien);
                dv.RowFilter = $"MaHV LIKE '%{keyword}%'";
                gridDSHV.DataSource = dv;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Thêm học viên sẽ được triển khai");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridDSHV.SelectedRows.Count > 0)
                MessageBox.Show("Chức năng Sửa học viên sẽ được triển khai");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridDSHV.SelectedRows.Count > 0)
                MessageBox.Show("Chức năng Xóa học viên sẽ được triển khai");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phân trang lùi (demo)");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phân trang tiến (demo)");
        }
    }
}
