﻿using BusinessLogic;
using Enity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevEduManager.Report;
using Microsoft.Reporting.WinForms;

namespace DevEduManager.Screens
{
    public partial class frmThongKeNoHocVien : Form
    {
        public frmThongKeNoHocVien()
        {
            InitializeComponent();
        }

        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Student/";

        /// <summary>
        /// Tính tổng nợ
        /// </summary>
        /// <returns></returns>
        public double TongNo()
        {
            double sum = 0;
            for (int i = 0; i < gridBaoCao.Rows.Count; i++)
                sum += Convert.ToDouble(gridBaoCao.Rows[i].Cells["clmConNo"].Value);
            return sum;
        }

        private void frmThongKeNoHocVien_Load(object sender, EventArgs e)
        {
            gridBaoCao.AutoGenerateColumns = false;

            LoadDataToGridView();
        }

        private async void LoadDataToGridView(string maHv = null)
        {
            string url = $"{_url}laynotheohocvien?maHv={maHv}";
            DataTable result = await callAPI.GetAPI(url);

            //gridLop.Dock = DockStyle.Fill;

            if (result.Rows.Count > 0)
            {
                gridBaoCao.DataSource = result;
            }

        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();

            List<ReportParameter> _params = new List<ReportParameter>()
            {
                //new ReportParameter("CenterName", GlobalSettings.CenterName),
                //new ReportParameter("CenterWebsite", GlobalSettings.CenterWebsite),
                //new ReportParameter("TongCong", gridBaoCao.Rows.Count.ToString()),
                //new ReportParameter("TongNo", TongNo().ToString())
            };

            frm.ReportViewer.LocalReport.ReportEmbeddedResource = "QuanLyHocVien.Reports.rptBaoCaoHocVienNo.rdlc";

            //dsSource.dtBaoCaoNoHocVienDataTable dt = new dsSource.dtBaoCaoNoHocVienDataTable();
            //var query = PhieuGhiDanh.ThongKeDanhSachNoHocPhi();
            //foreach (var i in query)
            //{
            //    dt.Rows.Add(i.MaHV, i.TenHV, i.GioiTinhHV, i.TenKH, i.ConNo);
            //}

            frm.ReportViewer.LocalReport.DataSources.Clear();
            //frm.ReportViewer.LocalReport.DataSources.Add(new ReportDataSource("ds", (DataTable)dt));

            frm.ReportViewer.LocalReport.SetParameters(_params);
            frm.ReportViewer.LocalReport.DisplayName = "Thống kê học viên nợ học phí";
            frm.Text = "Thống kê học viên nợ học phí";

            frm.ShowDialog();
        }

        private void gridBaoCao_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên còn nợ. Tổng nợ: {1:C0}", gridBaoCao.Rows.Count, TongNo());
        }

        private void gridBaoCao_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên còn nợ. Tổng nợ: {1:C0}", gridBaoCao.Rows.Count, TongNo());
        }
    }
}
