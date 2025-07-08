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

namespace DevEduManager.Modals
{
    public partial class frmThemHocVienVaoLop : Form
    {

        CallAPI callAPI = new CallAPI();
        private string _studentUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Student/";
        private string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        string classID = null;
        public frmThemHocVienVaoLop(string classId)
        {
            InitializeComponent();
            classID = classId;
        }

        private void frmThemHocVienVaoLop_Load(object sender, EventArgs e)
        {
            //string url = 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
