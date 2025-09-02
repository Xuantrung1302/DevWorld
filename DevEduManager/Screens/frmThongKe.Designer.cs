using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace DevEduManager.Screens
{
    partial class frmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel tableLayoutPanelMain;
        private Label lblTitle;
        private ComboBox cboYear;

        private Panel panelHocSinh;
        private Panel panelGiaoVien;
        private Panel panelNhanVien;
        private Panel panelChuongTrinh;

        private TableLayoutPanel tableLayoutPanelCharts;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartThuChi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTiLeTotNghiep;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChart4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelHocSinh = new System.Windows.Forms.Panel();
            this.panelNhanVien = new System.Windows.Forms.Panel();
            this.panelGiaoVien = new System.Windows.Forms.Panel();
            this.panelChuongTrinh = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCharts = new System.Windows.Forms.TableLayoutPanel();
            this.chartThuChi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTiLeTotNghiep = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartChart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartChart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThuChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiLeTotNghiep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChart4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.cboYear, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelCharts, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1091, 635);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1085, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỐNG KÊ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboYear
            // 
            this.cboYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboYear.Location = new System.Drawing.Point(20, 55);
            this.cboYear.Margin = new System.Windows.Forms.Padding(20, 5, 0, 5);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(150, 31);
            this.cboYear.TabIndex = 1;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panelHocSinh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelNhanVien, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelGiaoVien, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelChuongTrinh, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1085, 94);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelHocSinh
            // 
            this.panelHocSinh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHocSinh.Location = new System.Drawing.Point(3, 3);
            this.panelHocSinh.Name = "panelHocSinh";
            this.panelHocSinh.Padding = new System.Windows.Forms.Padding(10);
            this.panelHocSinh.Size = new System.Drawing.Size(265, 88);
            this.panelHocSinh.TabIndex = 0;
            // 
            // panelNhanVien
            // 
            this.panelNhanVien.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhanVien.Location = new System.Drawing.Point(274, 3);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Padding = new System.Windows.Forms.Padding(10);
            this.panelNhanVien.Size = new System.Drawing.Size(265, 88);
            this.panelNhanVien.TabIndex = 1;
            // 
            // panelGiaoVien
            // 
            this.panelGiaoVien.BackColor = System.Drawing.Color.LightSalmon;
            this.panelGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGiaoVien.Location = new System.Drawing.Point(545, 3);
            this.panelGiaoVien.Name = "panelGiaoVien";
            this.panelGiaoVien.Padding = new System.Windows.Forms.Padding(10);
            this.panelGiaoVien.Size = new System.Drawing.Size(265, 88);
            this.panelGiaoVien.TabIndex = 2;
            // 
            // panelChuongTrinh
            // 
            this.panelChuongTrinh.BackColor = System.Drawing.Color.LightCoral;
            this.panelChuongTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChuongTrinh.Location = new System.Drawing.Point(816, 3);
            this.panelChuongTrinh.Name = "panelChuongTrinh";
            this.panelChuongTrinh.Padding = new System.Windows.Forms.Padding(10);
            this.panelChuongTrinh.Size = new System.Drawing.Size(266, 88);
            this.panelChuongTrinh.TabIndex = 3;
            // 
            // tableLayoutPanelCharts
            // 
            this.tableLayoutPanelCharts.ColumnCount = 2;
            this.tableLayoutPanelCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharts.Controls.Add(this.chartThuChi, 0, 0);
            this.tableLayoutPanelCharts.Controls.Add(this.chartTiLeTotNghiep, 1, 0);
            this.tableLayoutPanelCharts.Controls.Add(this.chartChart3, 0, 1);
            this.tableLayoutPanelCharts.Controls.Add(this.chartChart4, 1, 1);
            this.tableLayoutPanelCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCharts.Location = new System.Drawing.Point(3, 193);
            this.tableLayoutPanelCharts.Name = "tableLayoutPanelCharts";
            this.tableLayoutPanelCharts.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelCharts.RowCount = 2;
            this.tableLayoutPanelCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharts.Size = new System.Drawing.Size(1085, 439);
            this.tableLayoutPanelCharts.TabIndex = 3;
            // 
            // chartThuChi
            // 
            this.chartThuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartThuChi.Location = new System.Drawing.Point(13, 13);
            this.chartThuChi.Name = "chartThuChi";
            this.chartThuChi.Size = new System.Drawing.Size(526, 203);
            this.chartThuChi.TabIndex = 0;
            // 
            // chartTiLeTotNghiep
            // 
            this.chartTiLeTotNghiep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTiLeTotNghiep.Location = new System.Drawing.Point(545, 13);
            this.chartTiLeTotNghiep.Name = "chartTiLeTotNghiep";
            this.chartTiLeTotNghiep.Size = new System.Drawing.Size(527, 203);
            this.chartTiLeTotNghiep.TabIndex = 1;
            // 
            // chartChart3
            // 
            this.chartChart3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartChart3.Location = new System.Drawing.Point(13, 222);
            this.chartChart3.Name = "chartChart3";
            this.chartChart3.Size = new System.Drawing.Size(526, 204);
            this.chartChart3.TabIndex = 2;
            // 
            // chartChart4
            // 
            this.chartChart4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartChart4.Location = new System.Drawing.Point(545, 222);
            this.chartChart4.Name = "chartChart4";
            this.chartChart4.Size = new System.Drawing.Size(527, 204);
            this.chartChart4.TabIndex = 3;
            // 
            // frmThongKe
            // 
            this.ClientSize = new System.Drawing.Size(1091, 635);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThuChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiLeTotNghiep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChart4)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private TableLayoutPanel tableLayoutPanel1;
    }
}
