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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DevEduManager.Screens
{
    public partial class frmDonTu : Form
    {
        public frmDonTu()
        {
            InitializeComponent();
        }
        public static string l1;
        public static string l2;

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDonTuEdit frm = new frmDonTuEdit();
            frm.ShowDialog();
        }
    }
}
