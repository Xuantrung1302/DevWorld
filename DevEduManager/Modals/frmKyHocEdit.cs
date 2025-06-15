using BusinessLogic;
using Enity.Models;
using Newtonsoft.Json;
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

namespace DevEduManager.Modals
{
    public partial class frmKyHocEdit : Form
    {
        private DataTable _kh;
        private bool isInsert = true;
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Semester/";

        public frmKyHocEdit(DataTable kh)
        {
            InitializeComponent();
            _kh = kh;
            isInsert = _kh == null;
            Load += frmKyHocEdit_Load; // Đăng ký sự kiện Load
        }

        private bool ValidateLuu()
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                errorProvider1.SetError(txtMaKH, "Bạn chưa nhập mã kỳ học");
                txtMaKH.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtTenKyHoc.Text))
            {
                errorProvider1.SetError(txtTenKyHoc, "Bạn chưa nhập tên kỳ học");
                txtTenKyHoc.Focus();
                return false;
            }
            else if (dateStart.Value > dateEnd.Value)
            {
                errorProvider1.SetError(dateEnd, "Ngày kết thúc phải lớn hơn ngày bắt đầu");
                dateEnd.Focus();
                return false;
            }
            return true;
        }

        private void frmKyHocEdit_Load(object sender, EventArgs e)
        {
            if (!isInsert && _kh.Rows.Count > 0)
            {
                FillData(_kh.Rows[0]);
            }
        }

        private void FillData(DataRow kh)
        {
            try
            {
                txtMaKH.Text = kh["SemesterID"].ToString();
                txtTenKyHoc.Text = kh["SemesterName"].ToString();

                if (kh["StartDate"] != DBNull.Value)
                    dateStart.Value = Convert.ToDateTime(kh["StartDate"]);

                if (kh["EndDate"] != DBNull.Value)
                    dateEnd.Value = Convert.ToDateTime(kh["EndDate"]);

                txtMaKH.ReadOnly = !isInsert; // Chỉ cho phép sửa mã khi thêm mới
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi điền dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateLuu())
                {
                    var semester = new
                    {
                        SemesterID = txtMaKH.Text,
                        SemesterName = txtTenKyHoc.Text,
                        StartDate = dateStart.Value,
                        EndDate = dateEnd.Value
                    };

                    string jsonData = JsonConvert.SerializeObject(semester, new JsonSerializerSettings
                    {
                        DateFormatHandling = DateFormatHandling.IsoDateFormat,
                        DateTimeZoneHandling = DateTimeZoneHandling.Utc
                    });

                    string url = isInsert ? $"{_url}themKyHoc" : $"{_url}suaKyHoc";
                    bool result = callAPI.PostAPI(url, jsonData).Result; // Sử dụng .Result để đồng bộ

                    if (result)
                    {
                        MessageBox.Show($"{(isInsert ? "Thêm" : "Cập nhật")} kỳ học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"{(isInsert ? "Thêm" : "Cập nhật")} kỳ học không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi {(isInsert ? "thêm" : "cập nhật")}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}