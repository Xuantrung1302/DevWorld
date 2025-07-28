namespace DevEduManager.Screens
{
    partial class frmThongTinGiangVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gridHocVien = new System.Windows.Forms.DataGridView();

            this.tableLayoutPanelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHocVien)).BeginInit();
            this.SuspendLayout();

            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelThongTin, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelGrid, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));  // Header
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));  // Info section
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));  // Grid
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));  // Bottom margin
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1000, 600);
            this.tableLayoutPanelMain.TabIndex = 0;

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.btnQuayLai);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 60);
            this.panelHeader.TabIndex = 0;

            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(850, 0);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(150, 60);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "THÔNG TIN HỌC VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panelThongTin
            // 
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.panelThongTin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelThongTin.Controls.Add(this.lblThongTin);
            this.panelThongTin.Location = new System.Drawing.Point(0, 60);
            this.panelThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(1000, 80);
            this.panelThongTin.TabIndex = 1;

            // 
            // lblThongTin
            // 
            this.lblThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblThongTin.Text = "Tên học viên: Nguyễn Văn A - Mã số: HV001";
            this.lblThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // panelGrid
            // 
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Padding = new System.Windows.Forms.Padding(10);
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Controls.Add(this.gridHocVien);
            this.panelGrid.Location = new System.Drawing.Point(0, 140);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1000, 450);
            this.panelGrid.TabIndex = 2;

            // 
            // gridHocVien
            // 
            this.gridHocVien.AllowUserToAddRows = false;
            this.gridHocVien.AllowUserToDeleteRows = false;
            this.gridHocVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHocVien.BackgroundColor = System.Drawing.Color.White;
            this.gridHocVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridHocVien.ColumnHeadersHeight = 40;
            this.gridHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHocVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridHocVien.Location = new System.Drawing.Point(10, 10);
            this.gridHocVien.MultiSelect = false;
            this.gridHocVien.Name = "gridHocVien";
            this.gridHocVien.ReadOnly = true;
            this.gridHocVien.RowHeadersVisible = false;
            this.gridHocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHocVien.Size = new System.Drawing.Size(980, 430);
            this.gridHocVien.TabIndex = 0;

            // 
            // frmThongTinHocVien
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongTinHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin học viên";

            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelThongTin.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHocVien)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView gridHocVien;
    }
}
