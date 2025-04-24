using BusinessLogic;
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

namespace DevEduManager.Screens
{
    public partial class frmXepLop : Form
    {
        public frmXepLop()
        {
            InitializeComponent();
        }
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Students/";
        private void frmXepLop_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private async void LoadDataGridView()
        {
            string url = $"{_url}thongTinHocVien";
            DataTable result = await callAPI.GetAPI(url);
            if (result != null)
            {
                gridDSHV.DataSource = result;
            }
        }
    }
}
