namespace DevEduManager.Screens
{
    partial class frmQuanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTenNV = new System.Windows.Forms.CheckBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMaNV = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridNV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.clmMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSdtNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmailNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNV)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1472, 30);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::DevEduManager.Properties.Resources.icon_Close_9dp;
            this.btnClose.Location = new System.Drawing.Point(1419, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnDatLai);
            this.splitContainer1.Panel1.Controls.Add(this.btnTimKiem);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenNV);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.chkTenNV);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaNV);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.chkMaNV);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.gridNV);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1472, 588);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 6;
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
            this.btnDatLai.Location = new System.Drawing.Point(210, 335);
            this.btnDatLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(109, 36);
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
            this.btnTimKiem.Location = new System.Drawing.Point(70, 335);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(132, 36);
            this.btnTimKiem.TabIndex = 60;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenNV.Location = new System.Drawing.Point(185, 172);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(133, 30);
            this.txtTenNV.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tên nhân viên:";
            // 
            // chkTenNV
            // 
            this.chkTenNV.AutoSize = true;
            this.chkTenNV.Location = new System.Drawing.Point(31, 142);
            this.chkTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.chkTenNV.Name = "chkTenNV";
            this.chkTenNV.Size = new System.Drawing.Size(142, 20);
            this.chkTenNV.TabIndex = 49;
            this.chkTenNV.Text = "Theo tên nhân viên";
            this.chkTenNV.UseVisualStyleBackColor = true;
            this.chkTenNV.CheckedChanged += new System.EventHandler(this.chkTenNV_CheckedChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaNV.Location = new System.Drawing.Point(185, 95);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(133, 30);
            this.txtMaNV.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã nhân viên:";
            // 
            // chkMaNV
            // 
            this.chkMaNV.AutoSize = true;
            this.chkMaNV.Location = new System.Drawing.Point(31, 64);
            this.chkMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.chkMaNV.Name = "chkMaNV";
            this.chkMaNV.Size = new System.Drawing.Size(143, 20);
            this.chkMaNV.TabIndex = 46;
            this.chkMaNV.Text = "Theo mã nhân viên";
            this.chkMaNV.UseVisualStyleBackColor = true;
            this.chkMaNV.CheckedChanged += new System.EventHandler(this.chkMaNV_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tìm kiếm nhân viên";
            // 
            // gridNV
            // 
            this.gridNV.AllowUserToAddRows = false;
            this.gridNV.AllowUserToResizeRows = false;
            this.gridNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNV.BackgroundColor = System.Drawing.Color.White;
            this.gridNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaNV,
            this.clmTenNV,
            this.Gender,
            this.Address,
            this.clmSdtNV,
            this.clmEmailNV});
            this.gridNV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridNV.Location = new System.Drawing.Point(16, 47);
            this.gridNV.Margin = new System.Windows.Forms.Padding(4);
            this.gridNV.MultiSelect = false;
            this.gridNV.Name = "gridNV";
            this.gridNV.RowHeadersVisible = false;
            this.gridNV.RowHeadersWidth = 51;
            this.gridNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNV.Size = new System.Drawing.Size(1088, 498);
            this.gridNV.TabIndex = 1;
            this.gridNV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridNV_RowsAdded);
            this.gridNV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridNV_RowsRemoved);
            this.gridNV.DoubleClick += new System.EventHandler(this.gridNV_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTongCong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 551);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1122, 37);
            this.panel3.TabIndex = 2;
            // 
            // lblTongCong
            // 
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Location = new System.Drawing.Point(12, 9);
            this.lblTongCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(145, 16);
            this.lblTongCong.TabIndex = 11;
            this.lblTongCong.Text = "Tổng cộng: 0 nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHienTatCa);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 46);
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
            this.btnHienTatCa.Location = new System.Drawing.Point(955, 7);
            this.btnHienTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(151, 31);
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
            this.btnXoa.Location = new System.Drawing.Point(292, 7);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 31);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Silver;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.Location = new System.Drawing.Point(189, 7);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 31);
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
            this.btnThem.Location = new System.Drawing.Point(16, 7);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 31);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm nhân viên";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // clmMaNV
            // 
            this.clmMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmMaNV.DataPropertyName = "EmployeeID";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.clmMaNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmMaNV.FillWeight = 5.028477F;
            this.clmMaNV.HeaderText = "Mã nhân viên";
            this.clmMaNV.MinimumWidth = 50;
            this.clmMaNV.Name = "clmMaNV";
            this.clmMaNV.Width = 115;
            // 
            // clmTenNV
            // 
            this.clmTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTenNV.DataPropertyName = "FullName";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clmTenNV.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmTenNV.FillWeight = 85.37589F;
            this.clmTenNV.HeaderText = "Họ và tên";
            this.clmTenNV.MinimumWidth = 300;
            this.clmTenNV.Name = "clmTenNV";
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.MinimumWidth = 40;
            this.Gender.Name = "Gender";
            this.Gender.Width = 83;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 346.0172F;
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 200;
            this.Address.Name = "Address";
            // 
            // clmSdtNV
            // 
            this.clmSdtNV.DataPropertyName = "PhoneNumber";
            this.clmSdtNV.FillWeight = 6.700381F;
            this.clmSdtNV.HeaderText = "SĐT";
            this.clmSdtNV.MinimumWidth = 200;
            this.clmSdtNV.Name = "clmSdtNV";
            // 
            // clmEmailNV
            // 
            this.clmEmailNV.DataPropertyName = "Email";
            this.clmEmailNV.FillWeight = 6.700381F;
            this.clmEmailNV.HeaderText = "Email";
            this.clmEmailNV.MinimumWidth = 300;
            this.clmEmailNV.Name = "clmEmailNV";
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 618);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridNV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSdtNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmailNV;
    }
}