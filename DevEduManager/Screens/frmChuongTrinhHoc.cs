using BusinessLogic;
using DevEduManager.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmChuongTrinhHoc : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _subjectUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Subject/";
        private string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";

        public frmChuongTrinhHoc()
        {
            InitializeComponent();

        }

        private void frmChuongTrinhHoc_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        private async void LoadSubjects(string subjectID = null, string semesterID = null)
        {
            try
            {
                string url = $"{_subjectUrl}thongTinMonHoc";
                DataTable result = await callAPI.GetAPI(url);

                var filteredRows = from row in result.AsEnumerable()
                                   where (string.IsNullOrEmpty(subjectID) || row.Field<string>("SubjectID").Contains(subjectID)) &&
                                         (string.IsNullOrEmpty(semesterID) || row.Field<string>("FullName").ToLower().Contains(semesterID.ToLower()))
                                   select row;

                if (filteredRows.Any())
                {
                    DataTable filteredDataTable = filteredRows.CopyToDataTable();
                    gridMon.DataSource = filteredDataTable;
                    gridMon.Dock = DockStyle.Fill;

                    // Ẩn các cột không cần thiết (nếu cần)
                    gridMon.AutoGenerateColumns = false;

                    // Chọn dòng đầu tiên nếu có
                    if (gridMon.Rows.Count > 0)
                    {
                        gridMon.Rows[0].Selected = true;
                        string selectedSubjectID = gridMon.Rows[0].Cells["SubjectID"].Value.ToString();
                        LoadClasses(selectedSubjectID);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy môn học nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách môn học: " + ex.Message);
            }
        }

        private async void LoadClasses(string subjectID)
        {
            try
            {
                string url = $"{_classUrl}layLop?subjectID={subjectID}";
                DataTable result = await callAPI.GetAPI(url);

                if (result != null && result.Rows.Count > 0)
                {
                    gridLop.DataSource = result;
                    gridLop.Dock = DockStyle.Fill;
                    HideColumns(gridLop);
                }
                else
                {
                    gridLop.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp: " + ex.Message);
            }
        }

        private void HideColumns(DataGridView grid)
        {
            if (grid.Rows.Count > 0)
            {
                int columnCount = grid.Columns.Count;
                if (columnCount >= 3)
                {
                    grid.Columns[columnCount - 1].Visible = false;
                    grid.Columns[columnCount - 2].Visible = false;
                    grid.Columns[columnCount - 3].Visible = false;
                }
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmMonHocEdit frm = new frmMonHocEdit(null);
            frm.ShowDialog();
            LoadSubjects();
        }

        private void gridMon_SelectionChanged(object sender, EventArgs e)
        {
            if (gridMon.SelectedRows.Count > 0)
            {
                string selectedSubjectID = gridMon.SelectedRows[0].Cells["SubjectID"].Value.ToString();
                LoadClasses(selectedSubjectID);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string subjectID = txtMaMon?.Text.Trim(); // giả sử bạn có textbox tên txtMaMon
            string subjectName = txtTenMon?.Text.Trim(); // giả sử bạn có textbox tên txtMaMon
            string semesterID = cboKy.SelectedValue.ToString(); // giả sử bạn có textbox tên txtHocKy
            LoadSubjects(subjectID, semesterID);
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            //txtHocKy.Clear();
            LoadSubjects();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridMon.SelectedRows.Count > 0)
                {
                    // Lấy dữ liệu từ hàng đang được chọn
                    DataGridViewRow selectedRow = gridMon.SelectedRows[0];
                    DataTable dt = ((DataTable)gridMon.DataSource).Clone();  // Tạo bản sao cấu trúc của DataTable
                    DataRow row = dt.NewRow();

                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        row[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(row);

                    frmMonHocEdit frm = new frmMonHocEdit(dt);
                    frm.Text = "Cập nhật thông tin môn học";
                    frm.ShowDialog();

                    btnHienTatCa_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một môn học để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridMon.SelectedRows.Count > 0)
                {
                    // Lấy dòng đang được chọn
                    DataGridViewRow selectedRow = gridMon.SelectedRows[0];

                    // Lấy subjectID từ cột "SubjectID"
                    string subjectID = selectedRow.Cells["SubjectID"].Value.ToString();

                    // Gọi API để xoá
                    string url = $"{_subjectUrl}xoaMonHoc?subjectID={subjectID}";
                    bool result = await callAPI.PostAPI(url);

                    // Refresh lại danh sách
                    btnHienTatCa_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một môn học để xoá.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xoá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridMon_SelectionChanged_1(object sender, EventArgs e)
        {
            if (gridMon.SelectedRows.Count > 0)
            {
                string selectedSubjectID = gridMon.SelectedRows[0].Cells["SubjectID"].Value.ToString();
                LoadClasses(selectedSubjectID);
            }
        }


        private void btnThemLH_Click(object sender, EventArgs e)
        {
            try
            {
                frmLopHocEdit frm = new frmLopHocEdit(null, null);
                frm.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSuaLH_Click(object sender, EventArgs e)
        {
            try
            {
                string classId = gridLop.SelectedRows[0].Cells["ClassID"].Value?.ToString();

                string className = gridLop.SelectedRows[0].Cells["ClassName"].Value?.ToString();
                //string semesterName = ((DataRowView)cboKy.SelectedItem)["SemesterName"].ToString();
                //string semesterName = cboKy.Text; // Lấy giá trị đang hiển thị (tên học kỳ)
                frmLopHocEdit frm = new frmLopHocEdit(classId, className);
                frm.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
