using BusinessLogic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmMonHocEdit : Form
    {
        private DataTable _subject;
        private bool isInsert = true;
        CallAPI callAPI = new CallAPI();

        private string _subjectUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Subject/";
        private string _semesterUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Semester/";
        private string _serviceUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";

        public frmMonHocEdit(DataTable subject)
        {
            InitializeComponent();
            _subject = subject;
            isInsert = _subject == null;
            Load += frmMonHocEdit_Load;
        }

        private async void frmMonHocEdit_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadSemesterToComboBox();

                if (isInsert)
                {
                    await GenerateSubjectID();
                    txtTenLH.Text = "";
                    txtHocPhi.Text = "";
                    cboKyHoc.SelectedIndex = -1;
                }
                else if (_subject != null && _subject.Rows.Count > 0)
                {
                    FillData(_subject.Rows[0]);
                }

                txtMaLH.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        private async Task LoadSemesterToComboBox()
        {
            try
            {
                string url = $"{_semesterUrl}thongTinKyHoc";
                DataTable dt = await callAPI.GetAPI(url);
                if (dt != null)
                {
                    cboKyHoc.DataSource = dt;
                    cboKyHoc.DisplayMember = "SemesterName";
                    cboKyHoc.ValueMember = "SemesterID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load kỳ học: " + ex.Message);
            }
        }

        private async Task GenerateSubjectID()
        {
            try
            {
                string url = $"{_serviceUrl}taoIdTuDong?ngay={DateTime.Now:dd/MM/yyyy}&prefix=MH";
                string result = await callAPI.CallApiAsync(url);
                txtMaLH.Text = result.Trim('\"');
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã môn học: " + ex.Message);
            }
        }

        private void FillData(DataRow row)
        {
            try
            {
                txtMaLH.Text = row["SubjectID"].ToString();
                txtTenLH.Text = row["SubjectName"].ToString();
                txtHocPhi.Text = row["TuitionFee"].ToString();

                string semesterID = row["SemesterID"].ToString();
                cboKyHoc.SelectedValue = semesterID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi điền dữ liệu: " + ex.Message);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenLH.Text))
            {
                errorProvider1.SetError(txtTenLH, "Bạn chưa nhập tên môn học");
                txtTenLH.Focus();
                return false;
            }

            if (cboKyHoc.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboKyHoc, "Bạn chưa chọn kỳ học");
                cboKyHoc.Focus();
                return false;
            }

            if (!decimal.TryParse(txtHocPhi.Text, out _))
            {
                errorProvider1.SetError(txtHocPhi, "Học phí không hợp lệ");
                txtHocPhi.Focus();
                return false;
            }

            return true;
        }

        private  void btnLuuThongTin_Click(object sender, EventArgs e)
        {
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLuuThongTin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var monHoc = new
                {
                    SubjectID = txtMaLH.Text,
                    SubjectName = txtTenLH.Text,
                    SemesterID = cboKyHoc.SelectedValue.ToString(),
                    TuitionFee = decimal.Parse(txtHocPhi.Text)
                };

                string jsonData = JsonConvert.SerializeObject(monHoc);

                string url = isInsert ? $"{_subjectUrl}themMonHoc" : $"{_subjectUrl}suaThongTinMonHoc";

                bool result = await callAPI.PostAPI(url, jsonData);

                if (result)
                {
                    MessageBox.Show($"{(isInsert ? "Thêm" : "Cập nhật")} môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"{(isInsert ? "Thêm" : "Cập nhật")} môn học không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu môn học: " + ex.Message);
            }

        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
