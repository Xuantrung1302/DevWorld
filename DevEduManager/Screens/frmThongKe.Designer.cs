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
        private ComboBox cboNam;
        private FlowLayoutPanel flowPanelThongKe;

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
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.flowPanelThongKe = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHocSinh = new System.Windows.Forms.Panel();
            this.panelGiaoVien = new System.Windows.Forms.Panel();
            this.panelNhanVien = new System.Windows.Forms.Panel();
            this.panelChuongTrinh = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCharts = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain.SuspendLayout();
            this.flowPanelThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.cboNam, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.flowPanelThongKe, 0, 2);
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
            // cboNam
            // 
            this.cboNam.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNam.Location = new System.Drawing.Point(20, 55);
            this.cboNam.Margin = new System.Windows.Forms.Padding(20, 5, 0, 5);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(150, 31);
            this.cboNam.TabIndex = 1;
            // 
            // flowPanelThongKe
            // 
            this.flowPanelThongKe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowPanelThongKe.Controls.Add(this.panelHocSinh);
            this.flowPanelThongKe.Controls.Add(this.panelGiaoVien);
            this.flowPanelThongKe.Controls.Add(this.panelNhanVien);
            this.flowPanelThongKe.Controls.Add(this.panelChuongTrinh);
            this.flowPanelThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelThongKe.Location = new System.Drawing.Point(3, 93);
            this.flowPanelThongKe.Name = "flowPanelThongKe";
            this.flowPanelThongKe.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.flowPanelThongKe.Size = new System.Drawing.Size(1085, 94);
            this.flowPanelThongKe.TabIndex = 2;
            // 
            // panelHocSinh
            // 
            this.panelHocSinh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelHocSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHocSinh.Location = new System.Drawing.Point(30, 20);
            this.panelHocSinh.Margin = new System.Windows.Forms.Padding(10);
            this.panelHocSinh.Name = "panelHocSinh";
            this.panelHocSinh.Padding = new System.Windows.Forms.Padding(10);
            this.panelHocSinh.Size = new System.Drawing.Size(200, 80);
            this.panelHocSinh.TabIndex = 0;
            // 
            // panelGiaoVien
            // 
            this.panelGiaoVien.BackColor = System.Drawing.Color.LightSalmon;
            this.panelGiaoVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGiaoVien.Location = new System.Drawing.Point(250, 20);
            this.panelGiaoVien.Margin = new System.Windows.Forms.Padding(10);
            this.panelGiaoVien.Name = "panelGiaoVien";
            this.panelGiaoVien.Padding = new System.Windows.Forms.Padding(10);
            this.panelGiaoVien.Size = new System.Drawing.Size(200, 80);
            this.panelGiaoVien.TabIndex = 1;
            // 
            // panelNhanVien
            // 
            this.panelNhanVien.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNhanVien.Location = new System.Drawing.Point(470, 20);
            this.panelNhanVien.Margin = new System.Windows.Forms.Padding(10);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Padding = new System.Windows.Forms.Padding(10);
            this.panelNhanVien.Size = new System.Drawing.Size(200, 80);
            this.panelNhanVien.TabIndex = 2;
            // 
            // panelChuongTrinh
            // 
            this.panelChuongTrinh.BackColor = System.Drawing.Color.LightCoral;
            this.panelChuongTrinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChuongTrinh.Location = new System.Drawing.Point(690, 20);
            this.panelChuongTrinh.Margin = new System.Windows.Forms.Padding(10);
            this.panelChuongTrinh.Name = "panelChuongTrinh";
            this.panelChuongTrinh.Padding = new System.Windows.Forms.Padding(10);
            this.panelChuongTrinh.Size = new System.Drawing.Size(200, 80);
            this.panelChuongTrinh.TabIndex = 3;
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
            this.flowPanelThongKe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
