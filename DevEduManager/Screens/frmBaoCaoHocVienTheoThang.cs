﻿using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Data;
using Enity.Models;
namespace DevEduManager.Screens
{
    public partial class frmBaoCaoHocVienTheoThang : Form
    {
        public frmBaoCaoHocVienTheoThang()
        {
            InitializeComponent();
        }

        private void frmBaoCaoHocVienTheoThang_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            //frmReport frm = new frmReport();

            //List<ReportParameter> _params = new List<ReportParameter>()
            //{
            //    new ReportParameter("CenterName", GlobalSettings.CenterName),
            //    new ReportParameter("CenterWebsite", GlobalSettings.CenterWebsite),
            //    new ReportParameter("Month", dateThang.Value.Month.ToString()),
            //    new ReportParameter("Year", dateThang.Value.Year.ToString())
            //};

            //frm.ReportViewer.LocalReport.ReportEmbeddedResource = "QuanLyHocVien.Reports.rptBaoCaoHocVienGhiDanhTheoThang.rdlc";

            //dsSource.dtBaoCaoHocVienTheoThangDataTable dt = new dsSource.dtBaoCaoHocVienTheoThangDataTable();
            //var query = PhieuGhiDanh.BaoCaoHocVienGhiDanhTheoThang(dateThang.Value.Month, dateThang.Value.Year);
            //foreach (var i in query)
            //{
            //    dt.Rows.Add(i.MaHV, i.TenHV, i.GioiTinhHV, i.NgayGhiDanh, i.TenKH);
            //}

            //frm.ReportViewer.LocalReport.DataSources.Clear();
            //frm.ReportViewer.LocalReport.DataSources.Add(new ReportDataSource("ds", (DataTable)dt));

            //frm.ReportViewer.LocalReport.SetParameters(_params);
            //frm.ReportViewer.LocalReport.DisplayName = "Báo cáo học viên ghi danh theo tháng";
            //frm.Text = "Báo cáo học viên ghi danh theo tháng";



            //frm.ShowDialog();
        }

        private void gridBaoCao_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên", gridBaoCao.Rows.Count);
        }

        private void gridBaoCao_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên", gridBaoCao.Rows.Count);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //Thread th = new Thread(() =>
            //{
            //    object dshv = PhieuGhiDanh.BaoCaoHocVienGhiDanhTheoThang(dateThang.Value.Month, dateThang.Value.Year);

            //    gridBaoCao.Invoke((MethodInvoker)delegate
            //    {
            //        gridBaoCao.DataSource = dshv;
            //    });
            //});

            //th.Start();

            //if (MessageBox.Show("Bạn có muốn tạo báo cáo?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    btnTaoBaoCao_Click(sender, e);
        }
    }
}
