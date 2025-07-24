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
    public partial class frmQuanLyKyHoc : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Semester/";

        public frmQuanLyKyHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLyKiHoc_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
            // Cấu hình giao diện (nếu cần)
            gridKyHoc.AutoGenerateColumns = true; // Tự động tạo cột từ DataTable
        }

        private async void LoadDataToGridView(string tenKH = null, DateTime? dateStart = null, DateTime? dateEnd = null)
        {
            try
            {
                string url = $"{_url}thongTinKyHoc";
                DataTable result = await callAPI.GetAPI(url);

                // Lọc dữ liệu dựa trên tham số tìm kiếm
                var filteredRows = from row in result.AsEnumerable()
                                   where
                                         (string.IsNullOrEmpty(tenKH) || row.Field<string>("SemesterName").ToLower().Contains(tenKH.ToLower())) &&
                                         (dateStart == null || row.Field<DateTime>("StartDate") >= dateStart) &&
                                         (dateEnd == null || row.Field<DateTime>("EndDate") <= dateEnd)
                                   select row;

                // Hiển thị dữ liệu
                if (filteredRows.Any())
                {
                    DataTable filteredDataTable = filteredRows.CopyToDataTable();
                    gridKyHoc.DataSource = filteredDataTable;
                    gridKyHoc.Dock = DockStyle.Fill;

                    //// Ẩn các cột cuối nếu cần thiết
                    //if (gridKyHoc.Columns.Count >= 3)
                    //{
                    //    gridKyHoc.Columns[gridKyHoc.Columns.Count - 1].Visible = false; // Ẩn cột cuối
                    //    gridKyHoc.Columns[gridKyHoc.Columns.Count - 2].Visible = false; // Ẩn cột thứ 2 từ cuối
                    //    gridKyHoc.Columns[gridKyHoc.Columns.Count - 3].Visible = false; // Ẩn cột thứ 3 từ cuối
                    //}
                }
                else
                {
                    gridKyHoc.DataSource = null; // Xóa dữ liệu grid nếu không có kết quả
                    MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        // Chức năng tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        // Chức năng thêm kỳ học
        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(txtSemesterID.Text) || string.IsNullOrEmpty(txtTenKH.Text))
                //{
                //    MessageBox.Show("Vui lòng nhập SemesterID và SemesterName!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                frmKyHocEdit frm = new frmKyHocEdit(null); // Gửi null cho form khi thêm mới
                frm.Text = "Thêm kỳ học mới";
                frm.ShowDialog();

                // Tải lại danh sách sau khi thêm
                btnHienTatCa_Click(sender, e);

                //var semester = new
                //{
                //    //SemesterID = txtSemesterID.Text,
                //    SemesterName = txtTenKH.Text,
                //    StartDate = dateTuNgay.Value,
                //    EndDate = dateDenNgay.Value
                //};

                //string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(semester);
                //string url = $"{_url}themKyHoc";
                //bool result = await callAPI.PostAPI(url, jsonData);

                //if (result)
                //{
                //    MessageBox.Show("Thêm kỳ học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    LoadDataToGridView(); // Tải lại dữ liệu
                //}
                //else
                //{
                //    MessageBox.Show("Thêm kỳ học không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chức năng sửa kỳ học
        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridKyHoc.SelectedRows.Count > 0)
                {
                    // Lấy dữ liệu từ hàng đang được chọn
                    DataGridViewRow selectedRow = gridKyHoc.SelectedRows[0];
                    DataTable dt = ((DataTable)gridKyHoc.DataSource).Clone();  // Tạo bản sao cấu trúc của DataTable
                    DataRow row = dt.NewRow();

                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        row[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(row);

                    // Mở form sửa thông tin giáo viên
                    frmKyHocEdit frm = new frmKyHocEdit(dt);
                    frm.Text = "Cập nhật thông tin kỳ học";
                    frm.ShowDialog();

                    // Tải lại danh sách sau khi chỉnh sửa
                    btnHienTatCa_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một kỳ học để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chức năng xóa kỳ học
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridKyHoc.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một kỳ học để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa kỳ học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                DataGridViewRow selectedRow = gridKyHoc.SelectedRows[0];
                string semesterID = selectedRow.Cells["SemesterID"].Value.ToString();
                string url = $"{_url}xoaKyHoc?semesterId={semesterID}";
                //bool result = await callAPI.DeleteAPI(url); // Giả định có phương thức DeleteAPI

                //if (result)
                //{
                //    MessageBox.Show("Xóa kỳ học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    LoadDataToGridView();
                //}
                //else
                //{
                //    MessageBox.Show("Xóa kỳ học không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridKyHoc_SelectionChanged_1(object sender, EventArgs e)
        {
            //if (gridKyHoc.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = gridKyHoc.SelectedRows[0];
            //    //txtSemesterID.Text = row.Cells["SemesterID"].Value?.ToString() ?? "";
            //    txtTenKH.Text = row.Cells["SemesterName"].Value?.ToString() ?? "";
            //    //dateTuNgay.Value = row.Cells["StartDate"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["StartDate"].Value) : DateTime.Now;
            //    //dateDenNgay.Value = row.Cells["EndDate"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["EndDate"].Value) : DateTime.Now;
            //}
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();

            //DateTime? dateStart = chkKhoangTG.Checked ? (DateTime?)DateTime.Parse(dateTuNgay.Value.ToString("dd/MM/yyyy")) : null;
            //DateTime? dateEnd = chkKhoangTG.Checked ? (DateTime?)DateTime.Parse(dateDenNgay.Value.ToString("dd/MM/yyyy")) : null;

            LoadDataToGridView(tenKH);
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            // Đặt lại các checkbox và textbox tìm kiếm
            chkTenKH.Checked = false;
            //chkKhoangTG.Checked = false;

            txtTenKH.Text = string.Empty;
            btnHienTatCa_Click(sender, e);
        }

        private void chkTenKH_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkTenKH_CheckedChanged(object sender, EventArgs e)
        {
            txtTenKH.Enabled = chkTenKH.Checked;
        }

        private void chkKhoangTG_CheckedChanged(object sender, EventArgs e)
        {
            //dateTuNgay.Enabled = dateDenNgay.Enabled = chkKhoangTG.Checked;
        }

        private void gridKyHoc_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên", gridKyHoc.Rows.Count);
        }

        private void gridKyHoc_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên", gridKyHoc.Rows.Count);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

        }
    }
}