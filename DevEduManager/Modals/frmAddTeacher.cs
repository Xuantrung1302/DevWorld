using BusinessLogic;
using System;
using System.Configuration;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using DocumentFormat.OpenXml.VariantTypes;

namespace DevEduManager.Screens
{
    public partial class frmAddTeacher : Form
    {
        private CallAPI callAPI = new CallAPI();
        private string _courseId;
        private string _classId;
        private readonly string _classIDs = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        private MailService mailService;

        public frmAddTeacher(string courseId, string classId, string programName, string className)
        {
            InitializeComponent();
            _courseId = courseId;
            _classId = classId;
            txtProgramName.Text = programName;
            txtClassName.Text = className;
            mailService = new MailService("ngxuantrung03@gmail.com", "cbvwqfctxhefrzim");
            string email1 = "huymess0610@gmail.com";
            string email2 = "devhuymess11@gmail.com";

        }

        private async void frmAddTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                string url = $"{_classIDs}layGiangVienChoLop?ClassID={_classId}";
                DataTable result = await callAPI.GetAPI(url);
                gridTeachers.AutoGenerateColumns = false;
                gridTeachers.DataSource = result;
                gridTeachers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách giảng viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (gridTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string teacherId = gridTeachers.SelectedRows[0].Cells["TeacherID"].Value?.ToString();
            try
            {
                // Gọi API để thêm giảng viên vào lớp
                string addTeacherUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/themGiangVienVaoLop?classId={_classId}&teacherId={teacherId}";
                bool result = await callAPI.PostAPI(addTeacherUrl, null); // Giả sử API không cần body

                if (result)
                {
                    // Gọi API tự sinh lịch
                    string generateScheduleUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/taoLichHoc?classId={_classId}";
                    bool scheduleResult = await callAPI.PostAPI(generateScheduleUrl, null);

                    if (scheduleResult)
                    {
                        // Gọi API để lấy danh sách học viên theo classID
                        string url = $"{_classIDs}layThongTinHocVienChoEmail?classID={_classId}";

                        // Gọi API và nhận kết quả về dạng DataTable
                        DataTable dt = await callAPI.GetAPI(url);

                        // Chuyển DataTable thành danh sách Student
                        List<Student> students = new List<Student>();
                        foreach (DataRow row in dt.Rows)
                        {
                            students.Add(new Student
                            {
                                FullName = row["FullName"]?.ToString(),
                                Email = row["Email"]?.ToString()
                            });
                        }

                        // Gửi mail
                        SendMail(students);



                        MessageBox.Show("Thêm giảng viên và tạo lịch thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sinh lịch thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm giảng viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm giảng viên hoặc sinh lịch: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void SendMail(List<Student> students)
        {

            string className = txtClassName.Text;
            string teacher = gridTeachers.SelectedRows[0].Cells["FullName"].Value?.ToString(); 

            string subject = $"[Lịch học mới] Lớp {className}";
            string template = File.ReadAllText("EmailTemplate.html");
            string body = template
                .Replace("{ClassName}", className)
                .Replace("{Teacher}", teacher);


            foreach (var student in students)
            {
                try
                {
                    await mailService.SendMailAsync(student.Email, subject, body);
                }
                catch (Exception ex)
                {
                }
            }
        }


    }

    public class Student
    {
        public string FullName { get; set; }
        public string Email { get; set; }
    }

    public class MailService
    {
        private readonly string _fromEmail;
        private readonly string _password;

        public MailService(string fromEmail, string password)
        {
            _fromEmail = fromEmail;
            _password = password;
        }

        public async Task SendMailAsync(string toEmail, string subject, string body)
        {
            using (var smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(_fromEmail, _password);

                var message = new MailMessage(_fromEmail, toEmail, subject, body);
                message.IsBodyHtml = true;

                await smtp.SendMailAsync(message);
            }
        }
    }
}