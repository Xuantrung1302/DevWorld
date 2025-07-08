using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmThemHocVienVaoLop : Form
    {

        CallAPI callAPI = new CallAPI();
        private string _studentUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Student/";
        private string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        string classID = null;
        string _semesterName = null;
        public frmThemHocVienVaoLop(string classId, string semesterName)
        {
            InitializeComponent();
            classID = classId;
            _semesterName = semesterName;
        }

        private void frmThemHocVienVaoLop_Load(object sender, EventArgs e)
        {
            txtKyHoc.Text = _semesterName;
            LoadDataToGridView(classID);
        }

        private async void LoadDataToGridView(string classID)
        {
            try
            {
                string url = $"{_classUrl}layDanhSachHVDuocThemVaoLop?classID={classID}";
                DataTable result = await callAPI.GetAPI(url);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void gridListStudent_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 && e.ColumnIndex == 0)
                {
                    e.PaintBackground(e.CellBounds, true);
                    CheckBox checkBox = new CheckBox
                    {
                        Size = new Size(15, 15),
                        Location = new Point(
                            e.CellBounds.Left + (e.CellBounds.Width - 15) / 2,
                            e.CellBounds.Top + (e.CellBounds.Height - 15) / 2
                        )
                    };

                    checkBox.CheckedChanged += (s, ev) =>
                    {
                        foreach (DataGridViewRow row in gridListStudent.Rows)
                        {
                            row.Cells[0].Value = checkBox.Checked;
                        }
                        gridListStudent.Invalidate(); // Vẽ lại
                    };

                    gridListStudent.Controls.Add(checkBox);
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CheckRowsUntilLabel(bool check)
        {
            // Xác định vị trí kết thúc dựa trên giá trị hoặc nhãn cụ thể
            int stopRowIndex = -1;

            foreach (DataGridViewRow row in gridListStudent.Rows)
            {
                // Giả sử bạn dừng ở hàng chứa một giá trị cụ thể trong cột "TenLop"
                if (row.Cells["TenLop"].Value != null &&
                    row.Cells["TenLop"].Value.ToString() == lblAddStu.Text)
                {
                    stopRowIndex = row.Index;
                    break;
                }
            }

            if (stopRowIndex == -1)
            {
                MessageBox.Show("Không tìm thấy dòng chứa lblAddStu.", "Thông báo");
                return;
            }

            for (int i = 0; i <= stopRowIndex; i++)
            {
                gridListStudent.Rows[i].Cells[0].Value = check; // cột checkbox ở index 0
            }
        }

        private async void frmThemHocVienVaoLop_Shown(object sender, EventArgs e)
        {
            try
            {
                string url = $"{_classUrl}laySoLuongHienTaiVaThieuCuaLop?classID={classID}";
                DataTable result = await callAPI.GetAPI(url);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
