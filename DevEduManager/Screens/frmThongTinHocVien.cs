using BusinessLogic;
using Enity.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmThongTinHocVien : Form
    {
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Course/";
        private string _studentId;
        CallAPI callAPI = new CallAPI();
        private Panel _mainPanel;
        List<StudentCourse> _studentCourses;

        public frmThongTinHocVien(Panel mainPanel, string studentId, string studentName)
        {
            InitializeComponent();
            _mainPanel = mainPanel;
            _studentId = studentId;
            Load += frmThongTinHocVien_Load;
            lblMaHV.Text = studentId;
            lblHoTen.Text = studentName;
        }

        private async void frmThongTinHocVien_Load(object sender, EventArgs e)
        {
            string url = $"{_url}layKhoaHocTheoHocVien?studentID={_studentId}";
            _studentCourses = await callAPI.GetAPI<StudentCourse>(url);

            if (_studentCourses is null || _studentCourses.Count == 0)
            {
                return;
            }

            var uniqueCourses = _studentCourses
                .GroupBy(sc => new { sc.CourseID, sc.CourseName })
                .Select(group => group.First())
                .ToList();

            gridChuongTrinh.DataSource = uniqueCourses.Select(sc => new
            {
                sc.CourseID,
                sc.CourseName
            }).ToList();

            if (uniqueCourses.Any())
            {
                // Tự động chọn chương trình đầu tiên
                gridChuongTrinh.Rows[0].Selected = true;
                string firstCourseID = uniqueCourses.First().CourseID;
                LoadSubjectsForCourse(firstCourseID);
            }
            gridChuongTrinh.AllowUserToResizeRows = false;
            gridMonHoc.AllowUserToResizeRows = false;
        }

        private void LoadSubjectsForCourse(string courseID)
        {
            var subjectsForCourse = _studentCourses
                .Where(sc => sc.CourseID == courseID)
                .Select(sc => new
                {
                    sc.SubjectID,
                    sc.SubjectName
                })
                .ToList();

            gridMonHoc.DataSource = subjectsForCourse;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            var frm = new frmQuanLyHocVien(_mainPanel)
            {
                Dock = DockStyle.Fill,
                TopLevel = false
            };

            _mainPanel.Controls.Clear();
            _mainPanel.Controls.Add(frm);
            frm.Show();
        }

        private void gridChuongTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedCourseID = gridChuongTrinh.Rows[e.RowIndex].Cells["clmCourseID"].Value.ToString();
                LoadSubjectsForCourse(selectedCourseID);
            }
        }
    }
}
