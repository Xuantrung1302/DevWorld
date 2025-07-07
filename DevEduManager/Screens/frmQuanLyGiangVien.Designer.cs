namespace DevEduManager.Screens
{
    partial class frmQuanLyGiangVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMaGV = new System.Windows.Forms.CheckBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.chkTenGV = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridGV = new System.Windows.Forms.DataGridView();
            this.lblTongCongGV = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridLop = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTongCongLop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.clmMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioiTinhGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSdtGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Study = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 30);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ GIẢNG VIÊN";
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1421, 583);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkMaGV, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTimKiem, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnDatLai, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMaGV, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTenGV, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkTenGV, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 583);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(34, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 43);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tìm kiếm";
            // 
            // chkMaGV
            // 
            this.chkMaGV.AutoSize = true;
            this.chkMaGV.Checked = true;
            this.chkMaGV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMaGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkMaGV.Location = new System.Drawing.Point(34, 47);
            this.chkMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.chkMaGV.Name = "chkMaGV";
            this.chkMaGV.Size = new System.Drawing.Size(149, 29);
            this.chkMaGV.TabIndex = 46;
            this.chkMaGV.Text = "Theo mã giảng viên";
            this.chkMaGV.UseVisualStyleBackColor = true;
            this.chkMaGV.CheckedChanged += new System.EventHandler(this.chkMaGV_CheckedChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Silver;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(34, 523);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(149, 46);
            this.btnTimKiem.TabIndex = 60;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.BackColor = System.Drawing.Color.Silver;
            this.btnDatLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDatLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDatLai.FlatAppearance.BorderSize = 0;
            this.btnDatLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDatLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDatLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDatLai.Location = new System.Drawing.Point(191, 523);
            this.btnDatLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(150, 46);
            this.btnDatLai.TabIndex = 61;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatLai.UseVisualStyleBackColor = false;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(34, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 46);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã giảng viên:";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaGV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaGV.Location = new System.Drawing.Point(191, 84);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(150, 30);
            this.txtMaGV.TabIndex = 48;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenGV.Enabled = false;
            this.txtTenGV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenGV.Location = new System.Drawing.Point(191, 160);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(150, 30);
            this.txtTenGV.TabIndex = 51;
            // 
            // chkTenGV
            // 
            this.chkTenGV.AutoSize = true;
            this.chkTenGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTenGV.Location = new System.Drawing.Point(34, 130);
            this.chkTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.chkTenGV.Name = "chkTenGV";
            this.chkTenGV.Size = new System.Drawing.Size(149, 22);
            this.chkTenGV.TabIndex = 49;
            this.chkTenGV.Text = "Theo tên giảng viên";
            this.chkTenGV.UseVisualStyleBackColor = true;
            this.chkTenGV.CheckedChanged += new System.EventHandler(this.chkTenGV_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(34, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 38);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tên giảng viên:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridGV);
            this.panel5.Controls.Add(this.lblTongCongGV);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 46);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1071, 223);
            this.panel5.TabIndex = 4;
            // 
            // gridGV
            // 
            this.gridGV.AllowUserToAddRows = false;
            this.gridGV.AllowUserToResizeRows = false;
            this.gridGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGV.BackgroundColor = System.Drawing.Color.White;
            this.gridGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaGV,
            this.clmTenGV,
            this.clmGioiTinhGV,
            this.clmSdtGV,
            this.Address,
            this.Degree,
            this.clmEmailGV});
            this.gridGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridGV.Location = new System.Drawing.Point(16, 4);
            this.gridGV.Margin = new System.Windows.Forms.Padding(4);
            this.gridGV.MultiSelect = false;
            this.gridGV.Name = "gridGV";
            this.gridGV.ReadOnly = true;
            this.gridGV.RowHeadersVisible = false;
            this.gridGV.RowHeadersWidth = 51;
            this.gridGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGV.Size = new System.Drawing.Size(1039, 184);
            this.gridGV.TabIndex = 2;
            this.gridGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGV_CellClick);
            this.gridGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridGV_RowsAdded);
            this.gridGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridGV_RowsRemoved);
            this.gridGV.Click += new System.EventHandler(this.gridGV_Click);
            this.gridGV.DoubleClick += new System.EventHandler(this.gridGV_DoubleClick);
            // 
            // lblTongCongGV
            // 
            this.lblTongCongGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongCongGV.AutoSize = true;
            this.lblTongCongGV.Location = new System.Drawing.Point(12, 193);
            this.lblTongCongGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongCongGV.Name = "lblTongCongGV";
            this.lblTongCongGV.Size = new System.Drawing.Size(182, 16);
            this.lblTongCongGV.TabIndex = 12;
            this.lblTongCongGV.Text = "Tổng cộng: <num> giảng viên";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridLop);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 269);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1071, 277);
            this.panel4.TabIndex = 3;
            // 
            // gridLop
            // 
            this.gridLop.AllowUserToAddRows = false;
            this.gridLop.AllowUserToOrderColumns = true;
            this.gridLop.AllowUserToResizeRows = false;
            this.gridLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLop.BackgroundColor = System.Drawing.Color.White;
            this.gridLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.SubjectName,
            this.clmTenKy,
            this.DaysOfWeek,
            this.Study,
            this.Room,
            this.dataGridViewTextBoxColumn5});
            this.gridLop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLop.Location = new System.Drawing.Point(16, 26);
            this.gridLop.Margin = new System.Windows.Forms.Padding(4);
            this.gridLop.MultiSelect = false;
            this.gridLop.Name = "gridLop";
            this.gridLop.ReadOnly = true;
            this.gridLop.RowHeadersVisible = false;
            this.gridLop.RowHeadersWidth = 51;
            this.gridLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLop.Size = new System.Drawing.Size(1039, 243);
            this.gridLop.TabIndex = 3;
            this.gridLop.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridLop_RowsAdded);
            this.gridLop.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridLop_RowsRemoved);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Các lớp dạy";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTongCongLop);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 546);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1071, 37);
            this.panel3.TabIndex = 2;
            // 
            // lblTongCongLop
            // 
            this.lblTongCongLop.AutoSize = true;
            this.lblTongCongLop.Location = new System.Drawing.Point(12, 9);
            this.lblTongCongLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongCongLop.Name = "lblTongCongLop";
            this.lblTongCongLop.Size = new System.Drawing.Size(107, 16);
            this.lblTongCongLop.TabIndex = 11;
            this.lblTongCongLop.Text = "Tổng cộng: 0 lớp";
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
            this.panel2.Size = new System.Drawing.Size(1071, 46);
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
            this.btnHienTatCa.Location = new System.Drawing.Point(904, 7);
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
            this.btnXoa.Location = new System.Drawing.Point(296, 7);
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
            this.btnSua.Location = new System.Drawing.Point(193, 7);
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
            this.btnThem.Size = new System.Drawing.Size(169, 31);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm giảng viên";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // clmMaGV
            // 
            this.clmMaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmMaGV.DataPropertyName = "TeacherID";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            this.clmMaGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmMaGV.FillWeight = 70F;
            this.clmMaGV.HeaderText = "Mã giảng viên";
            this.clmMaGV.MinimumWidth = 30;
            this.clmMaGV.Name = "clmMaGV";
            this.clmMaGV.ReadOnly = true;
            this.clmMaGV.Width = 120;
            // 
            // clmTenGV
            // 
            this.clmTenGV.DataPropertyName = "FullName";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Green;
            this.clmTenGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmTenGV.FillWeight = 93.27411F;
            this.clmTenGV.HeaderText = "Họ và tên";
            this.clmTenGV.MinimumWidth = 6;
            this.clmTenGV.Name = "clmTenGV";
            this.clmTenGV.ReadOnly = true;
            // 
            // clmGioiTinhGV
            // 
            this.clmGioiTinhGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmGioiTinhGV.DataPropertyName = "Gender";
            this.clmGioiTinhGV.HeaderText = "Giới tính";
            this.clmGioiTinhGV.MinimumWidth = 20;
            this.clmGioiTinhGV.Name = "clmGioiTinhGV";
            this.clmGioiTinhGV.ReadOnly = true;
            this.clmGioiTinhGV.Width = 83;
            // 
            // clmSdtGV
            // 
            this.clmSdtGV.DataPropertyName = "PhoneNumber";
            this.clmSdtGV.FillWeight = 93.27411F;
            this.clmSdtGV.HeaderText = "SĐT";
            this.clmSdtGV.MinimumWidth = 150;
            this.clmSdtGV.Name = "clmSdtGV";
            this.clmSdtGV.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Degree
            // 
            this.Degree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Degree.DataPropertyName = "Degree";
            this.Degree.HeaderText = "Bằng cấp";
            this.Degree.MinimumWidth = 30;
            this.Degree.Name = "Degree";
            this.Degree.ReadOnly = true;
            this.Degree.Width = 94;
            // 
            // clmEmailGV
            // 
            this.clmEmailGV.DataPropertyName = "Email";
            this.clmEmailGV.FillWeight = 93.27411F;
            this.clmEmailGV.HeaderText = "Email";
            this.clmEmailGV.MinimumWidth = 6;
            this.clmEmailGV.Name = "clmEmailGV";
            this.clmEmailGV.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClassName";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên lớp";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Môn học";
            this.SubjectName.MinimumWidth = 250;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // clmTenKy
            // 
            this.clmTenKy.DataPropertyName = "SemesterName";
            this.clmTenKy.HeaderText = "Tên kỳ";
            this.clmTenKy.MinimumWidth = 6;
            this.clmTenKy.Name = "clmTenKy";
            this.clmTenKy.ReadOnly = true;
            // 
            // DaysOfWeek
            // 
            this.DaysOfWeek.DataPropertyName = "DaysOfWeek";
            this.DaysOfWeek.HeaderText = "Thứ";
            this.DaysOfWeek.MinimumWidth = 50;
            this.DaysOfWeek.Name = "DaysOfWeek";
            this.DaysOfWeek.ReadOnly = true;
            // 
            // Study
            // 
            this.Study.DataPropertyName = "StudyTime";
            this.Study.HeaderText = "Ca học";
            this.Study.MinimumWidth = 200;
            this.Study.Name = "Study";
            this.Study.ReadOnly = true;
            // 
            // Room
            // 
            this.Room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Phòng";
            this.Room.MinimumWidth = 10;
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StudentCount";
            this.dataGridViewTextBoxColumn5.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Sĩ số";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 68;
            // 
            // frmQuanLyGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1421, 613);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyGiangVien";
            this.Text = "Quản lý giảng viên";
            this.Load += new System.EventHandler(this.frmQuanLyGiangVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView gridGV;
        private System.Windows.Forms.Label lblTongCongGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView gridLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTongCongLop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioiTinhGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSdtGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Study;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}