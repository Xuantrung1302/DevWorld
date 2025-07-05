using BusinessLogic;
using DevEduManager.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmChuongTrinhHoc : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Subject/";
        public frmChuongTrinhHoc()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {

        }

        private void frmChuongTrinhHoc_Load(object sender, EventArgs e)
        {

        }
        private async void LoadDataToGridView(string subjectID = null, string semesterID = null)
        {
            try
            {
                string url = $"{_url}thongTinMonHoc";
                DataTable result = await callAPI.GetAPI(url);

                // Lọc dữ liệu dựa trên tham số tìm kiếm
                var filteredRows = from row in result.AsEnumerable()
                                       //where (string.IsNullOrEmpty(maLoaiHV) || row.Field<string>("StudentID").Contains(maLoaiHV)) &&
                                   where (string.IsNullOrEmpty(subjectID) || row.Field<string>("SubjectID").Contains(subjectID)) &&
                                         (string.IsNullOrEmpty(semesterID) || row.Field<string>("FullName").ToLower().Contains(semesterID.ToLower()))

                                   select row;

                // Nếu có kết quả lọc, hiển thị trên grid
                if (filteredRows.Any())
                {
                    DataTable filteredDataTable = filteredRows.CopyToDataTable();
                    gridMon.DataSource = filteredDataTable;
                    gridMon.Dock = DockStyle.Fill;

                    // Ẩn các cột cuối nếu cần thiết
                    if (gridMon.Rows.Count > 0)
                    {
                        int columnCount = gridMon.Columns.Count;
                        if (columnCount >= 3)
                        {
                            gridMon.Columns[columnCount - 1].Visible = false; // Cột cuối
                            gridMon.Columns[columnCount - 2].Visible = false; // Cột thứ 2 từ cuối
                            gridMon.Columns[columnCount - 3].Visible = false; // Cột thứ 3 từ cuối
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmMonHocEdit frm = new frmMonHocEdit();
            frm.ShowDialog();

            btnHienTatCa_Click(sender, e);
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
    }
}
