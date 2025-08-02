using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmChiTietLopHoc : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private string _classID;
        private readonly string _classIDs = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";




        public frmChiTietLopHoc(string classID)
        {
            InitializeComponent();
            _classID = classID;
        }

        private void frmChiTietLopHoc_Load(object sender, EventArgs e)
        {
            try
            {
                LoadClassDetail(_classID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadClassDetail(string classID)
        {
            try
            {
                string url = $"{_classIDs}layThongTinLopTheoMaLop?classID={classID}";
                DataTable result = await callAPI.GetAPI(url);

                if (result != null && result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    txtTenLop.Text = row["ClassName"]?.ToString();
                    txtCaHoc.Text = Convert.ToDateTime(row["StartTime"]).ToString("HH:mm")
                                                        + " - " +
                                                        Convert.ToDateTime(row["EndTime"]).ToString("HH:mm");

                    txtPhong.Text = row["Room"]?.ToString();
                    txtGiangVien.Text = row["TeacherName"]?.ToString();

                    string thuString = row["DaysOfWeek"]?.ToString(); // VD: "2,3,5"
                    if (!string.IsNullOrEmpty(thuString))
                    {
                        string[] thuArr = thuString.Split(',').Select(x => x.Trim()).ToArray();

                        foreach (string thu in thuArr)
                        {
                            switch (thu)
                            {
                                case "2": chkThu2.Checked = true; chkThu2.Enabled = false; break;
                                case "3": chkThu3.Checked = true; chkThu3.Enabled = false; break;
                                case "4": chkThu4.Checked = true; chkThu4.Enabled = false; break;
                                case "5": chkThu5.Checked = true; chkThu5.Enabled = false; break;
                                case "6": chkThu6.Checked = true; chkThu6.Enabled = false; break;
                                case "7": chkThu7.Checked = true; chkThu7.Enabled = false; break;
                                case "8":
                                case "1":
                                case "CN":
                                case "Chủ nhật":
                                    chkChuNhat.Checked = true; chkChuNhat.Enabled = false; break;
                            }
                        }
                    }

                    // Disable các control thông tin text
                    txtTenLop.ReadOnly = true;
                    txtCaHoc.ReadOnly = true;
                    txtPhong.ReadOnly = true;
                    txtGiangVien.ReadOnly = true;

                    // Disable toàn bộ checkbox nếu chưa bị disable
                    DisableAllThuCheckboxes();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisableAllThuCheckboxes()
        {
            chkThu2.Enabled = false;
            chkThu3.Enabled = false;
            chkThu4.Enabled = false;
            chkThu5.Enabled = false;
            chkThu6.Enabled = false;
            chkThu7.Enabled = false;
            chkChuNhat.Enabled = false;
        }
    }
}
