namespace DevEduManager.Screens
{
    partial class frmQuanLyKyHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.chkKhoangTG = new System.Windows.Forms.CheckBox();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTenKH = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridKyHoc = new System.Windows.Forms.DataGridView();
            this.SemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemesterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKyHoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 24);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ KỲ HỌC";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.dateDenNgay);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.dateTuNgay);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.chkKhoangTG);
            this.splitContainer1.Panel1.Controls.Add(this.btnDatLai);
            this.splitContainer1.Panel1.Controls.Add(this.btnTimKiem);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenKH);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.chkTenKH);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 458);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 9;
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDenNgay.Enabled = false;
            this.dateDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateDenNgay.Location = new System.Drawing.Point(139, 216);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(185, 25);
            this.dateDenNgay.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Đến ngày:";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTuNgay.Enabled = false;
            this.dateTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTuNgay.Location = new System.Drawing.Point(139, 169);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(185, 25);
            this.dateTuNgay.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Từ ngày:";
            // 
            // chkKhoangTG
            // 
            this.chkKhoangTG.AutoSize = true;
            this.chkKhoangTG.Location = new System.Drawing.Point(21, 141);
            this.chkKhoangTG.Name = "chkKhoangTG";
            this.chkKhoangTG.Size = new System.Drawing.Size(133, 17);
            this.chkKhoangTG.TabIndex = 65;
            this.chkKhoangTG.Text = "Theo khoảng thời gian";
            this.chkKhoangTG.UseVisualStyleBackColor = true;
            this.chkKhoangTG.CheckedChanged += new System.EventHandler(this.chkKhoangTG_CheckedChanged);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatLai.BackColor = System.Drawing.Color.Silver;
            this.btnDatLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDatLai.FlatAppearance.BorderSize = 0;
            this.btnDatLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDatLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDatLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDatLai.Location = new System.Drawing.Point(244, 414);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(82, 29);
            this.btnDatLai.TabIndex = 61;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatLai.UseVisualStyleBackColor = false;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.Silver;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(139, 414);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 29);
            this.btnTimKiem.TabIndex = 60;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenKH.Location = new System.Drawing.Point(139, 87);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(187, 25);
            this.txtTenKH.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tên kỳ:";
            // 
            // chkTenKH
            // 
            this.chkTenKH.AutoSize = true;
            this.chkTenKH.Location = new System.Drawing.Point(21, 62);
            this.chkTenKH.Name = "chkTenKH";
            this.chkTenKH.Size = new System.Drawing.Size(83, 17);
            this.chkTenKH.TabIndex = 49;
            this.chkTenKH.Text = "Theo tên kỳ";
            this.chkTenKH.UseVisualStyleBackColor = true;
            this.chkTenKH.CheckedChanged += new System.EventHandler(this.chkTenKH_CheckedChanged);
            this.chkTenKH.CheckStateChanged += new System.EventHandler(this.chkTenKH_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tìm kiếm kỳ học";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridKyHoc);
            this.panel5.Controls.Add(this.lblTongCong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(741, 421);
            this.panel5.TabIndex = 4;
            // 
            // gridKyHoc
            // 
            this.gridKyHoc.AllowUserToAddRows = false;
            this.gridKyHoc.AllowUserToResizeRows = false;
            this.gridKyHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKyHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKyHoc.BackgroundColor = System.Drawing.Color.White;
            this.gridKyHoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridKyHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridKyHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKyHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SemesterID,
            this.SemesterName,
            this.StartDate,
            this.EndDate});
            this.gridKyHoc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridKyHoc.Location = new System.Drawing.Point(13, 5);
            this.gridKyHoc.MultiSelect = false;
            this.gridKyHoc.Name = "gridKyHoc";
            this.gridKyHoc.ReadOnly = true;
            this.gridKyHoc.RowHeadersVisible = false;
            this.gridKyHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKyHoc.Size = new System.Drawing.Size(717, 388);
            this.gridKyHoc.TabIndex = 12;
            this.gridKyHoc.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridKyHoc_RowsAdded);
            this.gridKyHoc.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridKyHoc_RowsRemoved);
            this.gridKyHoc.SelectionChanged += new System.EventHandler(this.gridKyHoc_SelectionChanged_1);
            // 
            // SemesterID
            // 
            this.SemesterID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SemesterID.DataPropertyName = "SemesterID";
            this.SemesterID.Frozen = true;
            this.SemesterID.HeaderText = "Mã kỳ học";
            this.SemesterID.Name = "SemesterID";
            this.SemesterID.ReadOnly = true;
            // 
            // SemesterName
            // 
            this.SemesterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SemesterName.DataPropertyName = "SemesterName";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Green;
            this.SemesterName.DefaultCellStyle = dataGridViewCellStyle8;
            this.SemesterName.FillWeight = 93.27411F;
            this.SemesterName.Frozen = true;
            this.SemesterName.HeaderText = "Tên kỳ học";
            this.SemesterName.Name = "SemesterName";
            this.SemesterName.ReadOnly = true;
            this.SemesterName.Width = 232;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Ngày bắt đầu";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.FillWeight = 93.27411F;
            this.EndDate.HeaderText = "Ngày kết thúc";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // lblTongCong
            // 
            this.lblTongCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Location = new System.Drawing.Point(10, 396);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(85, 13);
            this.lblTongCong.TabIndex = 13;
            this.lblTongCong.Text = "Tổng cộng: 0 kỳ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHienTatCa);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 37);
            this.panel2.TabIndex = 0;
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHienTatCa.BackColor = System.Drawing.Color.Silver;
            this.btnHienTatCa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHienTatCa.FlatAppearance.BorderSize = 0;
            this.btnHienTatCa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHienTatCa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHienTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienTatCa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHienTatCa.Location = new System.Drawing.Point(616, 6);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(113, 25);
            this.btnHienTatCa.TabIndex = 46;
            this.btnHienTatCa.Text = "Hiện tất cả";
            this.btnHienTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienTatCa.UseVisualStyleBackColor = false;
            this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.Location = new System.Drawing.Point(210, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 25);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Silver;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.Location = new System.Drawing.Point(133, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 25);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.Location = new System.Drawing.Point(12, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 25);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm kỳ học";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanLyKyHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 482);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyKyHoc";
            this.Text = "frmQuanLyKiHoc";
            this.Load += new System.EventHandler(this.frmQuanLyKiHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKyHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTuNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkKhoangTG;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView gridKyHoc;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemesterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemesterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
    }
}