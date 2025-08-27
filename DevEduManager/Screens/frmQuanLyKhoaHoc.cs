using ClosedXML.Excel;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;
using BusinessLogic;
using System.Linq;
using System;
using System.Configuration;
using Entity.Models;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyKhoaHoc : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Course/";
        private string _url2 = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";

        public frmQuanLyKhoaHoc()
        {
            InitializeComponent();
        }

        private async void frmQuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadComboBoxCourseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load chương trình học: " + ex.Message);
            }
        }

        private async Task LoadComboBoxCourseAsync()
        {
            try
            {
                string url = $"{_url}danhSachKhoaHoc";
                DataTable dt = await callAPI.GetAPI(url);

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboCT.DataSource = dt;
                    cboCT.DisplayMember = "CourseName";
                    cboCT.ValueMember = "CourseID";

                    // Gắn sự kiện sau khi gán DataSource để tránh chạy 2 lần
                    cboCT.SelectedIndexChanged -= cboCT_SelectedIndexChanged;
                    cboCT.SelectedIndexChanged += cboCT_SelectedIndexChanged;

                    // Mặc định chọn dòng đầu và load dữ liệu tương ứng
                    cboCT.SelectedIndex = 0;
                    string selectedCourseID = cboCT.SelectedValue.ToString();
                    await LoadDataToGridView(selectedCourseID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load combobox CT: " + ex.Message);
            }
        }

        private async void cboCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboCT.SelectedValue != null && Guid.TryParse(cboCT.SelectedValue.ToString(), out Guid courseId))
                {
                    await LoadDataToGridView(courseId.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn CT: " + ex.Message);
            }
        }

        private async Task LoadDataToGridView(string courseId)
        {
            try
            {
                string url = $"{_url}chiTietChuongTrinhHoc?CourseID={courseId}";
                DataTable result = await callAPI.GetAPI(url);
                dtgvCT.AutoGenerateColumns = false;
                dtgvCT.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu chi tiết: " + ex.Message);
            }
        }

        private async void btnCT_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                    openFileDialog.Title = "Chọn file Excel chứa danh sách khóa học";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        List<Course> courses = ReadExcelFile(openFileDialog.FileName);

                        if (courses.Count == 0)
                        {
                            MessageBox.Show("File Excel không chứa dữ liệu khóa học hợp lệ.");
                            return;
                        }

                        bool success = await AddCoursesToDatabase(courses);

                        if (success)
                        {
                            MessageBox.Show("Thêm khóa học thành công!");
                            await LoadComboBoxCourseAsync();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi thêm khóa học vào cơ sở dữ liệu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi import file Excel: " + ex.Message);
            }
        }

        private List<Course> ReadExcelFile(string filePath)
        {
            var courses = new List<Course>();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                var rows = worksheet.RowsUsed().Skip(1); // bỏ dòng tiêu đề

                // Gom nhóm theo CourseCode
                var grouped = rows.GroupBy(r => new {
                    CourseCode = r.Cell(2).GetString().Trim(),
                    CourseName = r.Cell(1).GetString().Trim()
                });

                foreach (var g in grouped)
                {
                    var course = new Course
                    {
                        CourseCode = g.Key.CourseCode,
                        CourseName = g.Key.CourseName,
                        Semesters = g.GroupBy(r => r.Cell(5).GetString().Trim())
                                     .Select(s => new Semester
                                     {
                                         SemesterName = s.Key,
                                         Subjects = s.Select(r => new Subject
                                         {
                                             SubjectName = r.Cell(3).GetString().Trim(),
                                             TuitionFee = r.Cell(4).GetValue<decimal>()
                                         }).ToList()
                                     }).ToList()
                    };

                    courses.Add(course);
                }
            }

            return courses;
        }


        private async Task<bool> AddCoursesToDatabase(List<Course> courses)
        {
            try
            {
                string url = $"{_url}themKhoaHoc";
                string json = JsonConvert.SerializeObject(courses);
                bool response = await callAPI.PostAPI(url, json);
                return response;
            }
            catch
            {
                return false;
            }
        }

    }
}