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
    public partial class frmBangTinEdit : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Notice/";
        public frmBangTinEdit()
        {
            InitializeComponent();
        }

        private void frmBangTinEdit_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        private async void LoadDataToGridView()
        {
            try
            {
                string url = $"{_url}danhSachThongBao";
                DataTable result = await callAPI.GetAPI(url);
                gridTB.DataSource = result;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
