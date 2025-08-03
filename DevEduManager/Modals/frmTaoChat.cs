using BusinessLogic;
using DevEduManager.Screens;
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
    public partial class frmTaoChat : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _userUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/User/";
        private readonly string _messageUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Message/";
        private readonly string _hubUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}signalr"; // URL SignalR


        public frmTaoChat()
        {
            InitializeComponent();

        }

        private void frmTaoChat_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAccountTypes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập mã tác nhân cần tìm kiếm.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtgvAccount.DataSource is DataTable dt)
            {
                // Tạo view lọc theo cột ID
                DataView view = new DataView(dt);
                view.RowFilter = $"ID LIKE '%{searchText}%'"; // hoặc đổi 'ID' thành tên cột đúng

                if (view.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dtgvAccount.DataSource = view;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dtgvAccount.CurrentRow;
                if (selectedRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một tài khoản để tạo cuộc trò chuyện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Lấy hàng được chọn
                //DataGridViewRow selectedRow = dtgvAccount.SelectedRows[0];

                // Tạo bản sao (clone) của hàng
                DataGridViewRow clonedRow = (DataGridViewRow)selectedRow.Clone();
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    clonedRow.Cells[i].Value = selectedRow.Cells[i].Value;
                }


                this.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }


        private async void LoadAccountTypes()
        {
            var accountTypes = new Dictionary<int, string>
            {
                { 1, "Nhân viên" },
                { 2, "Giảng viên" },
                { 3, "Học viên" }
            };
            cboAccountType.DataSource = new BindingSource(accountTypes, null);
            cboAccountType.DisplayMember = "Value";
            cboAccountType.ValueMember = "Key";
            cboAccountType.SelectedIndex = 0;
            await LoadAccountsAsync(cboAccountType.SelectedValue.ToString());
            cboAccountType.SelectedIndexChanged += CboAccountType_SelectedIndexChanged;
        }
        private async void CboAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAccountType.SelectedValue != null)
            {
                await LoadAccountsAsync(cboAccountType.SelectedValue.ToString());
            }
        }

        private async Task LoadAccountsAsync(string accountTypeId)
        {
            try
            {

                string url = $"{_messageUrl}GetAccountsByRole?roleId={accountTypeId}"; // Khớp với route API
                DataTable dt = await callAPI.GetAPI(url);
                //dtgvAccount.Rows.Clear();

                if (dt != null && dt.Rows.Count > 0)
                {
                    dtgvAccount.AutoGenerateColumns = false;
                    dtgvAccount.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnReset_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadAccountsAsync(cboAccountType.SelectedValue.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
