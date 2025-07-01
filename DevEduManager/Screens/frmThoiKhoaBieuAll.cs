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
using Entity.Models;
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
            flowLayoutPanel1.Controls.Clear(); // Xóa nếu đã có

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
                group.Width = flowLayoutPanel1.Width - 30;
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
                flowLayoutPanel1.Controls.Add(group);
            }
        }



        private void SetEnableService()
        {
            // Để trống hoặc thêm logic nếu cần
        }

        /// <summary>
        /// When double Click Schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scheduleUctrl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //int values = scheduleUctrl1.scrollbar.Value;
            //if (scheduleUctrl1.SelectedOD_User_Order != null)
            //{
            //    UpdateOrderscheduleUctrl1();
            //}
            //else
            //{
            //    //IsUpdate = false;
            //    Point p = scheduleUctrl1.PointToScreen(Point.Empty);
            //    //Get the row and col.
            //    DateTime? WeekDayNeedSetOrder = scheduleUctrl1.GetTimeAt(MousePosition.X - p.X, MousePosition.Y - p.Y);
            //    //isCheckService code when addnewService                          
            //    if (WeekDayNeedSetOrder != null)
            //    {
            //        //2021.11.01 Rep CuongNH S
            //        //CreateOrderWeekly(WeekDayNeedSetOrder.Value, true, AppInfo.ServiceLogin.UNIQ_KEY);
            //        var idFCOrder = GetIdFCOrder(MousePosition.X - p.X, MousePosition.Y - p.Y);
            //        //2021.12.15 Upd Hau S
            //        Guid guidServiceUniq = new Guid();
            //        var lstT_SCHEDULE_MANAGEMENT_INHOUSE_FC = this.scheduleUctrl1.T_SCHEDULE_MANAGEMENT_INHOUSE_FC as List<T_SCHEDULE_MANAGEMENT_INHOUSE_WEEKLY_Model>;
            //        var recordResult = idFCOrder == new Guid() ? null : (lstT_SCHEDULE_MANAGEMENT_INHOUSE_FC != null ? lstT_SCHEDULE_MANAGEMENT_INHOUSE_FC.FirstOrDefault(r => r.UNIQ_KEY == idFCOrder) : null);
            //        if (recordResult != null)
            //        {
            //            //get service type from FC order 
            //            guidServiceUniq = ListServices.FirstOrDefault(o => o.SERVICE_CODE == recordResult.SERVICE_CODE).UNIQ_KEY;
            //        }
            //        else
            //        {
            //            //get service type from login
            //            guidServiceUniq = AppInfo.ServiceLogin.UNIQ_KEY;
            //        }

            //        if (CurrentPermission != null && CurrentPermission.EDIT_ALLOW_FLG) //2023.06.12 ChinhTN -S
            //            CreateOrderWeekly(WeekDayNeedSetOrder.Value, true, guidServiceUniq, idFCOrder);

            //        //2021.12.15 Upd Hau E
            //        //2021.11.01 Rep CuongNH E
            //    }
            //}
            //if (values >= 0)
            //{
            //    scheduleUctrl1.scrollbar.Value = values;
            //}
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            //this.button_ShowChildForm();
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
                    // Gán giá trị StartDate và EndDate cho DateTimePicker
                    if (dtpkNgayBatDau != null && dtpkNgayKetThuc != null)
                    {
                        dtpkNgayBatDau.Value = selectedRow.Field<DateTime>("StartDate");
                        dtpkNgayKetThuc.Value = selectedRow.Field<DateTime>("EndDate");
                    }
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


        #region " "
        /// <summary>
        /// 
        /// Author: bannt
        /// </summary>
        /// <param name="pCloudCode"></param>
        /// <param name="pUserUniqKey"></param>
        /// <param name="pBeginTime"></param>
        /// <param name="pEndTime"></param>
        /// <returns></returns>
        private async Task GetClassPlan(string maKyHoc)
        {
            try
            {
                string url = $"{_url2}layDanhSachLopKeHoachByMaKy?semesterID ={maKyHoc}";
                DataTable result = await callAPI.GetAPI(url);

            }
            catch (Exception ex)
            {

            }
        }
        #endregion
    }
}