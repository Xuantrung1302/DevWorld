using DevEduManager.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmThoiKhoaBieu : Form
    {
        public frmThoiKhoaBieu()
        {
            InitializeComponent();
            LoadUserControl();
        }

        private void LoadUserControl()
        {
            // Giả lập dữ liệu lớp học
            var tkbData = new Dictionary<DateTime, int>
        {
            { new DateTime(2025, 6, 5), 1 },
            { new DateTime(2025, 6, 10), 2 },
            { new DateTime(2025, 7, 6), 3 }
        };

            var uc = new ucThoiKhoaBieuThang(tkbData, txtCalendar, btnPrev, btnNext);
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void frmThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            LoadUserControl();
        }
    }

}
