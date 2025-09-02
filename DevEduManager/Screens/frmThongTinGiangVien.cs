using BusinessLogic;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmThongTinGiangVien : Form
    {
        private Panel _mainPanel;
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Teacher/";
        private string _teacherId;
        CallAPI callAPI = new CallAPI();

        public frmThongTinGiangVien(Panel mainPanel, string teacherId, string teacherName, bool showTeacherInfo = true)
        {
            InitializeComponent();
            _teacherId = teacherId;
            _mainPanel = mainPanel;
            Load += frmThongTinHocVien_Load;
            gridLop.CellPainting += gridLop_CellPainting;

            if (!showTeacherInfo)
            {
                splitContainer1.Panel1Collapsed = true;
                return;
            }

            splitContainer1.IsSplitterFixed = true;
            lblMaGV.Text = teacherId;
            lblHoTen.Text = teacherName;
        }

        private async void frmThongTinHocVien_Load(object sender, EventArgs e)
        {
            try
            {
                // Setup columns
                gridLop.AutoGenerateColumns = false;
                string url = $"{_url}thongTinLopDay?teacherID={_teacherId}";
                DataTable result = await callAPI.GetAPI(url);

                gridLop.AutoGenerateColumns = false;
                gridLop.Dock = DockStyle.Fill;
                gridLop.DataSource = result.Rows.Count > 0 ? result : null;

                if (result.Rows.Count > 0)
                {
                    // Nếu chưa có cột StudyTime thì thêm vào
                    if (!result.Columns.Contains("StudyTime"))
                    {
                        result.Columns.Add("StudyTime", typeof(string));
                    }

                    foreach (DataRow row in result.Rows)
                    {
                        if (DateTime.TryParse(row["StartTime"]?.ToString(), out DateTime start) &&
                            DateTime.TryParse(row["EndTime"]?.ToString(), out DateTime end))
                        {
                            row["StudyTime"] = $"{start:HH:mm}-{end:HH:mm}";
                        }
                        else
                        {
                            row["StudyTime"] = "";
                        }
                    }
                }



                // Add rows
                gridLop.RowTemplate.Height = 40;

                gridLop.EnableHeadersVisualStyles = false;
                gridLop.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                gridLop.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gridLop.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                gridLop.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                gridLop.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
                gridLop.DefaultCellStyle.SelectionForeColor = Color.Black;

                gridLop.AllowUserToAddRows = false;
                gridLop.AllowUserToResizeRows = false;
                gridLop.RowHeadersVisible = false;
                gridLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gridLop_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 0) return;

            e.Handled = true;
            e.PaintBackground(e.CellBounds, true);

            string currentValue = e.Value?.ToString();
            string previousValue = e.RowIndex > 0
                ? gridLop.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value?.ToString()
                : null;

            bool isSameAsAbove = currentValue == previousValue;

            if (!isSameAsAbove && !string.IsNullOrEmpty(currentValue))
            {
                // Căn giữa dọc và trái đẹp hơn
                using (SolidBrush brush = new SolidBrush(e.CellStyle.ForeColor))
                {
                    var textSize = TextRenderer.MeasureText(currentValue, e.CellStyle.Font);
                    var location = new Point(e.CellBounds.X + 6, e.CellBounds.Y + (e.CellBounds.Height - textSize.Height) / 2);
                    e.Graphics.DrawString(currentValue, e.CellStyle.Font, brush, location);
                }
            }

            // Vẽ border để ngăn rõ ràng
            using (Pen gridLinePen = new Pen(gridLop.GridColor))
            {
                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            var frm = new frmQuanLyGiangVien(_mainPanel)
            {
                Dock = DockStyle.Fill,
                TopLevel = false
            };

            _mainPanel.Controls.Clear();
            _mainPanel.Controls.Add(frm);
            frm.Show();
        }
    }
}
