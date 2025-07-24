namespace DevEduManager.Screens
{
    partial class frmThoiKhoaBieu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnPrevWeek;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.DateTimePicker dtpWeek;
        private System.Windows.Forms.DataGridView dtgvTKB;
        private System.Windows.Forms.Button btnXuatExcel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.btnPrevWeek = new System.Windows.Forms.Button();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.dtpWeek = new System.Windows.Forms.DateTimePicker();
            this.dtgvTKB = new System.Windows.Forms.DataGridView();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.colGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThu3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThu4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThu5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThu6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThu7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỜI KHÓA BIỂU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 6;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelMain.Controls.Add(this.lblChonLop, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.cboLop, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.btnPrevWeek, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.btnNextWeek, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.dtpWeek, 4, 0);
            this.tableLayoutPanelMain.Controls.Add(this.dtgvTKB, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.btnXuatExcel, 5, 2);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1000, 540);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // lblChonLop
            // 
            this.lblChonLop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblChonLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChonLop.Location = new System.Drawing.Point(17, 18);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(100, 23);
            this.lblChonLop.TabIndex = 0;
            this.lblChonLop.Text = "Chọn lớp:";
            // 
            // cboLop
            // 
            this.cboLop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.Location = new System.Drawing.Point(123, 14);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(200, 31);
            this.cboLop.TabIndex = 1;
            // 
            // btnPrevWeek
            // 
            this.btnPrevWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevWeek.Location = new System.Drawing.Point(343, 3);
            this.btnPrevWeek.Name = "btnPrevWeek";
            this.btnPrevWeek.Size = new System.Drawing.Size(54, 54);
            this.btnPrevWeek.TabIndex = 2;
            this.btnPrevWeek.Text = "<";
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextWeek.Location = new System.Drawing.Point(403, 3);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(54, 54);
            this.btnNextWeek.TabIndex = 3;
            this.btnNextWeek.Text = ">";
            // 
            // dtpWeek
            // 
            this.dtpWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpWeek.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeek.Location = new System.Drawing.Point(463, 3);
            this.dtpWeek.Name = "dtpWeek";
            this.dtpWeek.Size = new System.Drawing.Size(354, 22);
            this.dtpWeek.TabIndex = 4;
            // 
            // dtgvTKB
            // 
            this.dtgvTKB.AllowUserToAddRows = false;
            this.dtgvTKB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTKB.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dtgvTKB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTKB.ColumnHeadersHeight = 40;
            this.dtgvTKB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGio,
            this.colThu2,
            this.colThu3,
            this.colThu4,
            this.colThu5,
            this.colThu6,
            this.colThu7,
            this.colCN});
            this.tableLayoutPanelMain.SetColumnSpan(this.dtgvTKB, 6);
            this.dtgvTKB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTKB.Location = new System.Drawing.Point(3, 63);
            this.dtgvTKB.Name = "dtgvTKB";
            this.dtgvTKB.ReadOnly = true;
            this.dtgvTKB.RowHeadersWidth = 51;
            this.dtgvTKB.RowTemplate.Height = 50;
            this.dtgvTKB.Size = new System.Drawing.Size(994, 414);
            this.dtgvTKB.TabIndex = 5;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXuatExcel.BackColor = System.Drawing.Color.Orange;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(835, 489);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(162, 42);
            this.btnXuatExcel.TabIndex = 6;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // colGio
            // 
            this.colGio.HeaderText = "Ca";
            this.colGio.MinimumWidth = 6;
            this.colGio.Name = "colGio";
            this.colGio.ReadOnly = true;
            // 
            // colThu2
            // 
            this.colThu2.HeaderText = "Thứ hai";
            this.colThu2.MinimumWidth = 6;
            this.colThu2.Name = "colThu2";
            this.colThu2.ReadOnly = true;
            // 
            // colThu3
            // 
            this.colThu3.HeaderText = "Thứ ba";
            this.colThu3.MinimumWidth = 6;
            this.colThu3.Name = "colThu3";
            this.colThu3.ReadOnly = true;
            // 
            // colThu4
            // 
            this.colThu4.HeaderText = "Thứ tư";
            this.colThu4.MinimumWidth = 6;
            this.colThu4.Name = "colThu4";
            this.colThu4.ReadOnly = true;
            // 
            // colThu5
            // 
            this.colThu5.HeaderText = "Thứ năm";
            this.colThu5.MinimumWidth = 6;
            this.colThu5.Name = "colThu5";
            this.colThu5.ReadOnly = true;
            // 
            // colThu6
            // 
            this.colThu6.HeaderText = "Thứ sáu";
            this.colThu6.MinimumWidth = 6;
            this.colThu6.Name = "colThu6";
            this.colThu6.ReadOnly = true;
            // 
            // colThu7
            // 
            this.colThu7.HeaderText = "Thứ bảy";
            this.colThu7.MinimumWidth = 6;
            this.colThu7.Name = "colThu7";
            this.colThu7.ReadOnly = true;
            // 
            // colCN
            // 
            this.colCN.HeaderText = "Chủ nhật";
            this.colCN.MinimumWidth = 6;
            this.colCN.Name = "colCN";
            this.colCN.ReadOnly = true;
            // 
            // frmThoiKhoaBieu
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThoiKhoaBieu";
            this.Text = "Thời Khóa Biểu";
            this.panelHeader.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTKB)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThu3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThu4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThu5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThu6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThu7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCN;
    }
}
