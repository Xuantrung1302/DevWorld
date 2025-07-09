using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmLopHocEdit : Form
    {
        string classID = null;
        string className = null;
        public frmLopHocEdit(string classId, string className)
        {
            InitializeComponent();
            this.classID = classId;
            this.className = className;
        }

        private void frmLopHocEdit_Load(object sender, EventArgs e)
        {
            try
            {
                txtTenLH.Text = className;
                LoadCaHoc();
                LoadDaysOfWeek();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadCaHoc()
        {
            List<string> caHocList = new List<string>
            {
                "08:00-10:00",
                "10:00-12:00",
                "13:00-15:00",
                "15:00-17:00",
                "17:00-19:00",
                "19:00-21:00"
            };

            cboCaHoc.DataSource = caHocList;
        }

        private void LoadDaysOfWeek()
        {
            List<string> daysOfWeek = new List<string>
            {
                "Thứ 2",
                "Thứ 3",
                "Thứ 4",
                "Thứ 5",
                "Thứ 6",
                "Thứ 7",
                "Chủ nhật"
            };

            clbDaysOfWeek.Items.Clear();
            foreach (string day in daysOfWeek)
            {
                clbDaysOfWeek.Items.Add(day);
            }
        }



        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
