namespace DevEduManager.Screens
{
    partial class frmChuongTrinhHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdDong = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.chkTinhTrang = new System.Windows.Forms.CheckBox();
            this.rdMo = new System.Windows.Forms.RadioButton();
            this.cboKy = new System.Windows.Forms.ComboBox();
            this.chkMaMon = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkKy = new System.Windows.Forms.CheckBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.chkTenMon = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridMon = new System.Windows.Forms.DataGridView();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridLop = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCacNgayTrongTuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuitionFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMon)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1445, 30);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ CHƯƠNG TRÌNH HỌC";
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
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1445, 558);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rdDong, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTimKiem, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnDatLai, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.chkTinhTrang, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.rdMo, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cboKy, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.chkMaMon, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkKy, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtMaMon, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTenMon, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkTenMon, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 558);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // rdDong
            // 
            this.rdDong.AutoSize = true;
            this.rdDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdDong.Enabled = false;
            this.rdDong.Location = new System.Drawing.Point(191, 259);
            this.rdDong.Margin = new System.Windows.Forms.Padding(4);
            this.rdDong.Name = "rdDong";
            this.rdDong.Size = new System.Drawing.Size(150, 21);
            this.rdDong.TabIndex = 72;
            this.rdDong.Text = "Đã đóng";
            this.rdDong.UseVisualStyleBackColor = true;
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
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tìm kiếm môn học";
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
            this.btnTimKiem.Location = new System.Drawing.Point(34, 508);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(149, 36);
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
            this.btnDatLai.Location = new System.Drawing.Point(191, 508);
            this.btnDatLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(150, 36);
            this.btnDatLai.TabIndex = 61;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatLai.UseVisualStyleBackColor = false;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // chkTinhTrang
            // 
            this.chkTinhTrang.AutoSize = true;
            this.chkTinhTrang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTinhTrang.Location = new System.Drawing.Point(34, 219);
            this.chkTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.chkTinhTrang.Name = "chkTinhTrang";
            this.chkTinhTrang.Size = new System.Drawing.Size(149, 32);
            this.chkTinhTrang.TabIndex = 70;
            this.chkTinhTrang.Text = "Theo tình trạng";
            this.chkTinhTrang.UseVisualStyleBackColor = true;
            // 
            // rdMo
            // 
            this.rdMo.AutoSize = true;
            this.rdMo.Checked = true;
            this.rdMo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdMo.Enabled = false;
            this.rdMo.Location = new System.Drawing.Point(34, 259);
            this.rdMo.Margin = new System.Windows.Forms.Padding(4);
            this.rdMo.Name = "rdMo";
            this.rdMo.Size = new System.Drawing.Size(149, 21);
            this.rdMo.TabIndex = 71;
            this.rdMo.TabStop = true;
            this.rdMo.Text = "Đang mở";
            this.rdMo.UseVisualStyleBackColor = true;
            // 
            // cboKy
            // 
            this.cboKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKy.Enabled = false;
            this.cboKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKy.FormattingEnabled = true;
            this.cboKy.Location = new System.Drawing.Point(191, 183);
            this.cboKy.Margin = new System.Windows.Forms.Padding(4);
            this.cboKy.Name = "cboKy";
            this.cboKy.Size = new System.Drawing.Size(150, 31);
            this.cboKy.TabIndex = 64;
            // 
            // chkMaMon
            // 
            this.chkMaMon.AutoSize = true;
            this.chkMaMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkMaMon.Location = new System.Drawing.Point(34, 34);
            this.chkMaMon.Margin = new System.Windows.Forms.Padding(4);
            this.chkMaMon.Name = "chkMaMon";
            this.chkMaMon.Size = new System.Drawing.Size(149, 22);
            this.chkMaMon.TabIndex = 46;
            this.chkMaMon.Text = "Theo mã môn:";
            this.chkMaMon.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(34, 179);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 36);
            this.label9.TabIndex = 63;
            this.label9.Text = "Kỳ học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(34, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã môn:";
            // 
            // chkKy
            // 
            this.chkKy.AutoSize = true;
            this.chkKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkKy.Location = new System.Drawing.Point(34, 155);
            this.chkKy.Margin = new System.Windows.Forms.Padding(4);
            this.chkKy.Name = "chkKy";
            this.chkKy.Size = new System.Drawing.Size(149, 20);
            this.chkKy.TabIndex = 62;
            this.chkKy.Text = "Theo kỳ";
            this.chkKy.UseVisualStyleBackColor = true;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaMon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaMon.Location = new System.Drawing.Point(191, 64);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(150, 30);
            this.txtMaMon.TabIndex = 48;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenMon.Enabled = false;
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenMon.Location = new System.Drawing.Point(191, 119);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(150, 30);
            this.txtTenMon.TabIndex = 51;
            // 
            // chkTenMon
            // 
            this.chkTenMon.AutoSize = true;
            this.chkTenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTenMon.Location = new System.Drawing.Point(34, 93);
            this.chkTenMon.Margin = new System.Windows.Forms.Padding(4);
            this.chkTenMon.Name = "chkTenMon";
            this.chkTenMon.Size = new System.Drawing.Size(149, 18);
            this.chkTenMon.TabIndex = 49;
            this.chkTenMon.Text = "Theo tên môn";
            this.chkTenMon.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(34, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 36);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tên môn:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridMon);
            this.panel5.Controls.Add(this.lblTongCong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 46);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1095, 292);
            this.panel5.TabIndex = 4;
            // 
            // gridMon
            // 
            this.gridMon.AllowUserToAddRows = false;
            this.gridMon.AllowUserToResizeRows = false;
            this.gridMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMon.BackgroundColor = System.Drawing.Color.White;
            this.gridMon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectID,
            this.SubjectName,
            this.clmKy,
            this.TuitionFee});
            this.gridMon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridMon.Location = new System.Drawing.Point(16, 6);
            this.gridMon.Margin = new System.Windows.Forms.Padding(4);
            this.gridMon.MultiSelect = false;
            this.gridMon.Name = "gridMon";
            this.gridMon.ReadOnly = true;
            this.gridMon.RowHeadersVisible = false;
            this.gridMon.RowHeadersWidth = 51;
            this.gridMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMon.Size = new System.Drawing.Size(1063, 251);
            this.gridMon.TabIndex = 12;
            // 
            // lblTongCong
            // 
            this.lblTongCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Location = new System.Drawing.Point(13, 261);
            this.lblTongCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(114, 16);
            this.lblTongCong.TabIndex = 13;
            this.lblTongCong.Text = "Tổng cộng: 0 môn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridLop);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 338);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1095, 220);
            this.panel4.TabIndex = 3;
            // 
            // gridLop
            // 
            this.gridLop.AllowUserToAddRows = false;
            this.gridLop.AllowUserToResizeRows = false;
            this.gridLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLop.BackgroundColor = System.Drawing.Color.White;
            this.gridLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.clmGioBD,
            this.clmGioKT,
            this.clmCacNgayTrongTuan,
            this.clmPhong,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.gridLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLop.Location = new System.Drawing.Point(0, 0);
            this.gridLop.Margin = new System.Windows.Forms.Padding(4);
            this.gridLop.MultiSelect = false;
            this.gridLop.Name = "gridLop";
            this.gridLop.ReadOnly = true;
            this.gridLop.RowHeadersVisible = false;
            this.gridLop.RowHeadersWidth = 51;
            this.gridLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLop.Size = new System.Drawing.Size(1095, 220);
            this.gridLop.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenLop";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.FillWeight = 300F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên lớp";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 300;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // clmGioBD
            // 
            this.clmGioBD.FillWeight = 7.725676F;
            this.clmGioBD.HeaderText = "Giờ bắt đầu";
            this.clmGioBD.MinimumWidth = 175;
            this.clmGioBD.Name = "clmGioBD";
            this.clmGioBD.ReadOnly = true;
            // 
            // clmGioKT
            // 
            this.clmGioKT.FillWeight = 15.38493F;
            this.clmGioKT.HeaderText = "Giờ kết thúc";
            this.clmGioKT.MinimumWidth = 175;
            this.clmGioKT.Name = "clmGioKT";
            this.clmGioKT.ReadOnly = true;
            // 
            // clmCacNgayTrongTuan
            // 
            this.clmCacNgayTrongTuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmCacNgayTrongTuan.FillWeight = 5.294462F;
            this.clmCacNgayTrongTuan.HeaderText = "Các ngày trong tuần";
            this.clmCacNgayTrongTuan.MinimumWidth = 6;
            this.clmCacNgayTrongTuan.Name = "clmCacNgayTrongTuan";
            this.clmCacNgayTrongTuan.ReadOnly = true;
            this.clmCacNgayTrongTuan.Width = 119;
            // 
            // clmPhong
            // 
            this.clmPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmPhong.DataPropertyName = "Room";
            this.clmPhong.FillWeight = 5.542107F;
            this.clmPhong.HeaderText = "Phòng học";
            this.clmPhong.MinimumWidth = 6;
            this.clmPhong.Name = "clmPhong";
            this.clmPhong.ReadOnly = true;
            this.clmPhong.Width = 92;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaxSeats";
            this.dataGridViewTextBoxColumn5.FillWeight = 6.455397F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Chỗ ngồi";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 83;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "DangMo";
            this.dataGridViewCheckBoxColumn1.FillWeight = 7.520319F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Đang mở";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 60;
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
            this.panel2.Size = new System.Drawing.Size(1095, 46);
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
            this.btnHienTatCa.Location = new System.Drawing.Point(928, 7);
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
            this.btnXoa.Location = new System.Drawing.Point(280, 7);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 31);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Silver;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.Location = new System.Drawing.Point(177, 7);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 31);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
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
            this.btnThem.Size = new System.Drawing.Size(153, 31);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm môn";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "SubjectID";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.SubjectID.DefaultCellStyle = dataGridViewCellStyle1;
            this.SubjectID.FillWeight = 81.09281F;
            this.SubjectID.HeaderText = "Mã môn";
            this.SubjectID.MinimumWidth = 6;
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            this.SubjectName.DefaultCellStyle = dataGridViewCellStyle2;
            this.SubjectName.FillWeight = 108.0551F;
            this.SubjectName.HeaderText = "Tên môn";
            this.SubjectName.MinimumWidth = 6;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // clmKy
            // 
            this.clmKy.DataPropertyName = "SemesterName";
            this.clmKy.FillWeight = 115.8469F;
            this.clmKy.HeaderText = "Tên học kỳ";
            this.clmKy.MinimumWidth = 6;
            this.clmKy.Name = "clmKy";
            this.clmKy.ReadOnly = true;
            this.clmKy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmKy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TuitionFee
            // 
            this.TuitionFee.FillWeight = 58.27927F;
            this.TuitionFee.HeaderText = "Học phí";
            this.TuitionFee.MinimumWidth = 30;
            this.TuitionFee.Name = "TuitionFee";
            this.TuitionFee.ReadOnly = true;
            // 
            // frmChuongTrinhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 588);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChuongTrinhHoc";
            this.Text = "frmChuongTrinhHoc";
            this.Load += new System.EventHandler(this.frmChuongTrinhHoc_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridMon)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rdDong;
        private System.Windows.Forms.RadioButton rdMo;
        private System.Windows.Forms.CheckBox chkTinhTrang;
        private System.Windows.Forms.ComboBox cboKy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkKy;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMaMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView gridMon;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView gridLop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCacNgayTrongTuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuitionFee;
    }
}