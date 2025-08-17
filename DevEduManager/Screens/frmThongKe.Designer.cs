using System.Windows.Forms;
using System.Drawing;

namespace DevEduManager.Screens
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel tableLayoutPanelMain;
        private Label lblTitle;
        private ComboBox cboYear;

        private Panel panelHocSinh;
        private Panel panelGiaoVien;
        private Panel panelNhanVien;
        private Panel panelChuongTrinh;

        private TableLayoutPanel tableLayoutPanelCharts;

        // Khai báo Chart ở đây, không khởi tạo (để ở file .cs)
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThuChi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTiLeTotNghiep;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChart4;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Initialize UI components.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelCharts = new System.Windows.Forms.TableLayoutPanel();
            this.panelHocSinh = new System.Windows.Forms.Panel();
            this.panelChuongTrinh = new System.Windows.Forms.Panel();
            this.panelGiaoVien = new System.Windows.Forms.Panel();
            this.panelNhanVien = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.cboYear, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelCharts, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
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
            // 
            // tableLayoutPanelCharts
            // 
            this.tableLayoutPanelCharts.ColumnCount = 2;
            this.tableLayoutPanelCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCharts.Location = new System.Drawing.Point(3, 193);
            this.tableLayoutPanelCharts.Name = "tableLayoutPanelCharts";
            this.tableLayoutPanelCharts.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanelCharts.RowCount = 2;
            this.tableLayoutPanelCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharts.Size = new System.Drawing.Size(1085, 439);
            this.tableLayoutPanelCharts.TabIndex = 3;
            // 
            // panelHocSinh
            // 
            this.panelHocSinh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelHocSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHocSinh.Location = new System.Drawing.Point(10, 10);
            this.panelHocSinh.Margin = new System.Windows.Forms.Padding(10);
            this.panelHocSinh.Name = "panelHocSinh";
            this.panelHocSinh.Padding = new System.Windows.Forms.Padding(10);
            this.panelHocSinh.Size = new System.Drawing.Size(251, 74);
            this.panelHocSinh.TabIndex = 0;
            // 
            // panelChuongTrinh
            // 
            this.panelChuongTrinh.BackColor = System.Drawing.Color.LightCoral;
            this.panelChuongTrinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChuongTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChuongTrinh.Location = new System.Drawing.Point(823, 10);
            this.panelChuongTrinh.Margin = new System.Windows.Forms.Padding(10);
            this.panelChuongTrinh.Name = "panelChuongTrinh";
            this.panelChuongTrinh.Padding = new System.Windows.Forms.Padding(10);
            this.panelChuongTrinh.Size = new System.Drawing.Size(252, 74);
            this.panelChuongTrinh.TabIndex = 3;
            // 
            // panelGiaoVien
            // 
            this.panelGiaoVien.BackColor = System.Drawing.Color.LightSalmon;
            this.panelGiaoVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGiaoVien.Location = new System.Drawing.Point(552, 10);
            this.panelGiaoVien.Margin = new System.Windows.Forms.Padding(10);
            this.panelGiaoVien.Name = "panelGiaoVien";
            this.panelGiaoVien.Padding = new System.Windows.Forms.Padding(10);
            this.panelGiaoVien.Size = new System.Drawing.Size(251, 74);
            this.panelGiaoVien.TabIndex = 1;
            // 
            // panelNhanVien
            // 
            this.panelNhanVien.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhanVien.Location = new System.Drawing.Point(281, 10);
            this.panelNhanVien.Margin = new System.Windows.Forms.Padding(10);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Padding = new System.Windows.Forms.Padding(10);
            this.panelNhanVien.Size = new System.Drawing.Size(251, 74);
            this.panelNhanVien.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panelChuongTrinh, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelHocSinh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelGiaoVien, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelNhanVien, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1085, 94);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 635);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
    }
}
