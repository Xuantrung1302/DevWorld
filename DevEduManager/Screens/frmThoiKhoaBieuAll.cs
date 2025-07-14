using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enity.Models; // Kiểm tra lại namespace này, có thể là lỗi đánh máy
using BusinessLogic;
using System.Configuration;

namespace DevEduManager.Screens
{
    public partial class frmThoiKhoaBieuAll : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Semester/";
        private string _url2 = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";

        public frmThoiKhoaBieuAll()
        {
            InitializeComponent();
        }

        private void frmThoiKhoaBieuAll_Load_1(object sender, EventArgs e)
        {
            try
            {
                LoadCboSemester();
                LoadClassGroups();
            }
            catch (Exception ex)
            {
                // Log4Net.Error("Form " + this.Name + " frmAS_D_OD_07_Load; Error:" + ex.Message);
            }
        }
        private void LoadClassGroups()
        {
            flpLich.Controls.Clear(); // Xóa nếu đã có

            // Dữ liệu giả lập
            Dictionary<string, List<LopHoc>> data = new Dictionary<string, List<LopHoc>>
            {
                ["Lập trình Python"] = new List<LopHoc>
        {
            new LopHoc { ClassName = "Python.1", StartTime = "06/06/2025 8:00", EndTime = "06/06/2025 10:00", Room = "B01", Teacher = "Vũ Hoài Nam" },
            new LopHoc { ClassName = "Python.2", StartTime = "07/06/2025 8:00", EndTime = "07/06/2025 10:00", Room = "B01", Teacher = "Nguyễn Văn A" }
        },
                ["Lập trình C#"] = new List<LopHoc>
        {
            new LopHoc { ClassName = "CSharp.1", StartTime = "08/06/2025 9:00", EndTime = "08/06/2025 11:00", Room = "B02", Teacher = "Lê Thị B" },
                        new LopHoc { ClassName = "Python.2", StartTime = "07/06/2025 8:00", EndTime = "07/06/2025 10:00", Room = "B01", Teacher = "Nguyễn Văn A" },

                                    new LopHoc { ClassName = "Python.2", StartTime = "07/06/2025 8:00", EndTime = "07/06/2025 10:00", Room = "B01", Teacher = "Nguyễn Văn A" }

        },
                ["Hệ thống thông tin"] = new List<LopHoc>
        {
            new LopHoc { ClassName = "HTTT.1", StartTime = "09/06/2025 13:00", EndTime = "09/06/2025 15:00", Room = "C01", Teacher = "Trần Văn C" }
        }
            };

            foreach (var subject in data)
            {
                // Tạo GroupBox cho từng môn
                GroupBox group = new GroupBox();
                group.Text = subject.Key;
                group.Width = flpLich.Width - 30;
                group.Height = 200;

                // Tạo DataGridView bên trong GroupBox
                DataGridView dgv = new DataGridView();
                dgv.DataSource = subject.Value;
                dgv.Dock = DockStyle.Fill;
                dgv.ReadOnly = true;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AllowUserToAddRows = false;
                dgv.RowHeadersVisible = false;

                // Thêm DataGridView vào GroupBox
                group.Controls.Add(dgv);

                // Thêm GroupBox vào FlowLayoutPanel
                flpLich.Controls.Add(group);
            }
        }





        private async void LoadCboSemester()
        {
            try
            {
                string url = $"{_url}maKyHoc";
                DataTable result = await callAPI.GetAPI(url);

                if (result != null && result.Rows.Count > 0)
                {
                    cboKyHoc.DataSource = result;
                    cboKyHoc.DisplayMember = "SemesterName"; // Tên hiển thị
                    cboKyHoc.ValueMember = "SemesterID";     // Giá trị thực tế
                }
                else
                {
                    cboKyHoc.DataSource = null;
                    cboKyHoc.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải kỳ học: " + ex.Message);
            }
        }

        private void cboKyHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKyHoc.SelectedItem != null && cboKyHoc.DataSource != null)
            {
                // Lấy DataRowView từ SelectedItem
                var selectedRow = (cboKyHoc.SelectedItem as DataRowView)?.Row;

                if (selectedRow != null)
                {

                }
            }
        }

        private void cboKyHoc_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private async void frmThoiKhoaBieuAll_Shown(object sender, EventArgs e)
        {
            string maKyHoc = cboKyHoc.ValueMember = "SemesterID";
            //await GetClassPlan(maKyHoc);
        }



    }
}