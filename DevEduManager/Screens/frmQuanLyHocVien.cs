﻿using BusinessLogic;
using DevEduManager.Modals;
using Enity.Models;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyHocVien : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Students/";

        public frmQuanLyHocVien()
        {
            InitializeComponent();
        }

        public void ValidateSearch()
        {
            if (chkMaHV.Checked && string.IsNullOrEmpty(txtMaHV.Text))
                throw new ArgumentException("Mã học viên không được trống.");
            if (chkTenHV.Checked && string.IsNullOrEmpty(txtTenHV.Text))
                throw new ArgumentException("Họ và tên học viên không được trống.");
        }

        private void frmQuanLyHocVien_Load(object sender, EventArgs e)
        {
            //Common.LoadComboBoxLoaiHV(cboLoaiHV);
            LoadDataToGridView();
            //cboLoaiHV.SelectedIndexChanged += new EventHandler(cboLoaiHV_SelectedIndexChanged);
        }

        private async void LoadDataToGridView(string maHV = null, string tenHV = null)
        {
            try
            {
                string url = $"{_url}thongTinHocVien";
                DataTable result = await callAPI.GetAPI(url);

                // Lọc dữ liệu dựa trên tham số tìm kiếm
                var filteredRows = from row in result.AsEnumerable()
                                   //where (string.IsNullOrEmpty(maLoaiHV) || row.Field<string>("StudentID").Contains(maLoaiHV)) &&
                                   where (string.IsNullOrEmpty(maHV) || row.Field<string>("StudentID").Contains(maHV)) &&
                                         (string.IsNullOrEmpty(tenHV) || row.Field<string>("FullName").ToLower().Contains(tenHV.ToLower()))

                                   select row;

                // Nếu có kết quả lọc, hiển thị trên grid
                if (filteredRows.Any())
                {
                    DataTable filteredDataTable = filteredRows.CopyToDataTable();
                    gridDSHV.DataSource = filteredDataTable;
                    gridDSHV.Dock = DockStyle.Fill;

                    // Ẩn các cột cuối nếu cần thiết
                    if (gridDSHV.Rows.Count > 0)
                    {
                        int columnCount = gridDSHV.Columns.Count;
                        if (columnCount >= 3)
                        {
                            gridDSHV.Columns[columnCount - 1].Visible = false; // Cột cuối
                            gridDSHV.Columns[columnCount - 2].Visible = false; // Cột thứ 2 từ cuối
                            gridDSHV.Columns[columnCount - 3].Visible = false; // Cột thứ 3 từ cuối
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            // Hiển thị form thêm học viên mới
            frmHocVienEdit frm = new frmHocVienEdit(null); // Gửi null cho form khi thêm mới
            frm.Text = "Thêm học viên mới";
            frm.ShowDialog();

            // Tải lại danh sách sau khi thêm
            btnXemTatCa_Click(sender, e);
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            // Đặt lại các checkbox và textbox tìm kiếm
            chkMaHV.Checked = true;
            //chkTenHV.Checked = chkGioiTinh.Checked = chkNgayTiepNhan.Checked = false;

            txtMaHV.Text = txtTenHV.Text = string.Empty;
            btnXemTatCa_Click(sender, e);
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            // Tải lại tất cả danh sách học viên
            LoadDataToGridView();
        }

        private void chkMaHV_CheckedChanged(object sender, EventArgs e)
        {
            txtMaHV.Enabled = chkMaHV.Checked;
        }

        private void chkTenHV_CheckedChanged(object sender, EventArgs e)
        {
            txtTenHV.Enabled = chkTenHV.Checked;
        }

        private void chkGioiTinh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkNgayTiepNhan_CheckedChanged(object sender, EventArgs e)
        {
            //dateTuNgay.Enabled = dateDenNgay.Enabled = chkNgayTiepNhan.Checked;
        }

        private void dateDenNgay_ValueChanged(object sender, EventArgs e)
        {
            //dateTuNgay.MaxDate = dateDenNgay.Value;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridDSHV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = gridDSHV.SelectedRows[0];
                    DataTable dt = ((DataTable)gridDSHV.DataSource).Clone(); // Sao chép cấu trúc
                    DataRow row = dt.NewRow();

                    // Gán giá trị dựa trên tên cột trong DataGridView
                    row["StudentID"] = selectedRow.Cells["clmMaHV"].Value;
                    row["FullName"] = selectedRow.Cells["clmTenHV"].Value; // Giả sử cột Họ Tên là clmHoTen
                    row["Gender"] = selectedRow.Cells["clmGioiTinh"].Value; // Giả sử cột Giới Tính là clmGioiTinh
                    row["Address"] = selectedRow.Cells["clmDiaChi"].Value; // Giả sử cột Địa Chỉ là clmDiaChi
                    row["PhoneNumber"] = selectedRow.Cells["clmSdtHV"].Value; // Giả sử cột SĐT là clmSoDienThoai
                    row["Email"] = selectedRow.Cells["clmEmail"].Value; // Giả sử cột Email là clmEmail
                    row["EnrollmentDate"] = selectedRow.Cells["clmNgayTiepNhan"].Value; // Giả sử cột Ngày ĐK là clmNgayDangKy
                    row["BirthDate"] = selectedRow.Cells["clmNgaySinh"].Value; // Giả sử cột Ngày Sinh là clmNgaySinh
                    row["Username"] = selectedRow.Cells["Username"].Value;
                    row["Password"] = selectedRow.Cells["Password"].Value;
                    // Xử lý BirthDate nếu cần
                    if (row["BirthDate"] != DBNull.Value && row["BirthDate"] != null)
                    {
                        if (!DateTime.TryParse(row["BirthDate"].ToString(), out DateTime birthDate))
                        {
                            row["BirthDate"] = DBNull.Value; // Gán null nếu không hợp lệ
                            Console.WriteLine($"Invalid BirthDate: {selectedRow.Cells["clmNgaySinh"].Value}, set to NULL");
                        }
                    }

                    dt.Rows.Add(row);

                    frmHocVienEdit frm = new frmHocVienEdit(dt);
                    frm.Text = "Cập nhật thông tin học viên";
                    frm.ShowDialog();

                    btnXemTatCa_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một học viên để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridDSHV_DoubleClick(object sender, EventArgs e)
        {
            btnSua_Click(sender, e);
        }

        private void cboLoaiHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //if(cboLoaiHV.SelectedValue.ToString() == "LHV00")
            //{
            //    maHocVien = "LHV00";
            //    LoadDataToGridView(null, null, null);
            //}
            //else
            //{
            //    maHocVien = "LHV01";
            //    LoadDataToGridView(null, null, null);
            //}
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSearch();

                string maHV = chkMaHV.Checked ? txtMaHV.Text.Trim() : null;
                string tenHV = chkTenHV.Checked ? txtTenHV.Text.Trim() : null;
                //string gioiTinhText = chkGioiTinh.Checked ? cboGioiTinh.Text : null;

                // Lấy giá trị của DateTimePicker nếu checkbox tương ứng được chọn, nếu không thì null
                //DateTime? dateStart = chkNgayTiepNhan.Checked ? (DateTime?)DateTime.Parse(dateTuNgay.Value.ToString("dd/MM/yyyy")) : null;
                //DateTime? dateEnd = chkNgayTiepNhan.Checked ? (DateTime?)DateTime.Parse(dateDenNgay.Value.ToString("dd/MM/yyyy")) : null;


                // Gọi LoadDataToGridView với tham số cần thiết
                LoadDataToGridView(maHV, tenHV);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridDSHV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên", gridDSHV.Rows.Count);
        }

        private void gridDSHV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên", gridDSHV.Rows.Count);
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HocVien hocVien = new HocVien()
                    {
                        StudentID = txtMaHV.Text,
                    };

                    string jsonData = JsonConvert.SerializeObject(hocVien);

                    string url = $"{_url}xoaThongTinHocVien";
                    bool result = await callAPI.PostAPI(url, jsonData);
                    if (result)
                    {
                        MessageBox.Show("Xóa thông tin học viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnXemTatCa_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin học viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                                      
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
