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
            List<Course> courses = new List<Course>();
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                var rows = worksheet.RowsUsed().Skip(1);

                foreach (var row in rows)
                {
                    try
                    {
                        Course course = new Course
                        {
                            CourseCode = row.Cell(1).GetString()?.Trim(),
                            CourseName = row.Cell(2).GetString()?.Trim(),
                            IsActive = row.Cell(3).IsEmpty() ? true : row.Cell(3).GetBoolean(),
                            Semester1 = new Semester
                            {
                                SemesterID = row.Cell(4).GetString()?.Trim(),
                                SemesterName = row.Cell(5).GetString()?.Trim(),
                                StartDate = row.Cell(6).GetValue<DateTime>(),
                                EndDate = row.Cell(7).GetValue<DateTime>(),
                                Subjects = new List<Subject>
                                {
                                    new Subject
                                    {
                                        SubjectID = row.Cell(8).GetString()?.Trim(),
                                        SubjectName = row.Cell(9).GetString()?.Trim(),
                                        TuitionFee = row.Cell(10).IsEmpty() ? 0 : row.Cell(10).GetValue<decimal>()
                                    },
                                    new Subject
                                    {
                                        SubjectID = row.Cell(11).GetString()?.Trim(),
                                        SubjectName = row.Cell(12).GetString()?.Trim(),
                                        TuitionFee = row.Cell(13).IsEmpty() ? 0 : row.Cell(13).GetValue<decimal>()
                                    }
                                }
                            },
                            Semester2 = new Semester
                            {
                                SemesterID = row.Cell(14).GetString()?.Trim(),
                                SemesterName = row.Cell(15).GetString()?.Trim(),
                                StartDate = row.Cell(16).GetValue<DateTime>(),
                                EndDate = row.Cell(17).GetValue<DateTime>(),
                                Subjects = new List<Subject>
                                {
                                    new Subject
                                    {
                                        SubjectID = row.Cell(18).GetString()?.Trim(),
                                        SubjectName = row.Cell(19).GetString()?.Trim(),
                                        TuitionFee = row.Cell(20).IsEmpty() ? 0 : row.Cell(20).GetValue<decimal>()
                                    },
                                    new Subject
                                    {
                                        SubjectID = row.Cell(21).GetString()?.Trim(),
                                        SubjectName = row.Cell(22).GetString()?.Trim(),
                                        TuitionFee = row.Cell(23).IsEmpty() ? 0 : row.Cell(23).GetValue<decimal>()
                                    }
                                }
                            }
                        };

                        if (!string.IsNullOrEmpty(course.CourseCode) && !string.IsNullOrEmpty(course.CourseName) &&
                            !string.IsNullOrEmpty(course.Semester1.SemesterID) && !string.IsNullOrEmpty(course.Semester2.SemesterID))
                        {
                            courses.Add(course);
                        }
                    }
                    catch
                    {
                        continue;
                    }
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