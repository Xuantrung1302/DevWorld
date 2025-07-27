namespace DevEduManager.Screens
{
    partial class frmQuanLyHocVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.gridDSHV = new System.Windows.Forms.DataGridView();
            this.clmMaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSdtHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayTiepNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panelPaging = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSHV)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelPaging.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.gridDSHV, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelActions, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelPaging, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1477, 639);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // gridDSHV
            // 
            this.gridDSHV.AllowUserToAddRows = false;
            this.gridDSHV.AllowUserToOrderColumns = true;
            this.gridDSHV.AllowUserToResizeRows = false;
            this.gridDSHV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDSHV.BackgroundColor = System.Drawing.Color.White;
            this.gridDSHV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSHV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaHV,
            this.clmTenHV,
            this.clmNgaySinh,
            this.clmGioiTinh,
            this.clmSdtHV,
            this.clmDiaChi,
            this.clmNgayTiepNhan,
            this.clmEmail});
            this.gridDSHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSHV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDSHV.Location = new System.Drawing.Point(4, 124);
            this.gridDSHV.Margin = new System.Windows.Forms.Padding(4);
            this.gridDSHV.MultiSelect = false;
            this.gridDSHV.Name = "gridDSHV";
            this.gridDSHV.ReadOnly = true;
            this.gridDSHV.RowHeadersVisible = false;
            this.gridDSHV.RowHeadersWidth = 51;
            this.gridDSHV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDSHV.Size = new System.Drawing.Size(1469, 461);
            this.gridDSHV.TabIndex = 4;
            this.gridDSHV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDSHV_DoubleClick);
            // 
            // clmMaHV
            // 
            this.clmMaHV.DataPropertyName = "StudentID";
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Blue;
            this.clmMaHV.DefaultCellStyle = dataGridViewCellStyle11;
            this.clmMaHV.FillWeight = 75F;
            this.clmMaHV.HeaderText = "Mã học viên";
            this.clmMaHV.MinimumWidth = 6;
            this.clmMaHV.Name = "clmMaHV";
            this.clmMaHV.ReadOnly = true;
            // 
            // clmTenHV
            // 
            this.clmTenHV.DataPropertyName = "FullName";
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Green;
            this.clmTenHV.DefaultCellStyle = dataGridViewCellStyle12;
            this.clmTenHV.FillWeight = 110F;
            this.clmTenHV.HeaderText = "Họ và tên";
            this.clmTenHV.MinimumWidth = 6;
            this.clmTenHV.Name = "clmTenHV";
            this.clmTenHV.ReadOnly = true;
            // 
            // clmNgaySinh
            // 
            this.clmNgaySinh.DataPropertyName = "BirthDate";
            this.clmNgaySinh.HeaderText = "Ngày sinh";
            this.clmNgaySinh.MinimumWidth = 6;
            this.clmNgaySinh.Name = "clmNgaySinh";
            this.clmNgaySinh.ReadOnly = true;
            // 
            // clmGioiTinh
            // 
            this.clmGioiTinh.DataPropertyName = "Gender";
            this.clmGioiTinh.FillWeight = 70F;
            this.clmGioiTinh.HeaderText = "Giới tính";
            this.clmGioiTinh.MinimumWidth = 6;
            this.clmGioiTinh.Name = "clmGioiTinh";
            this.clmGioiTinh.ReadOnly = true;
            // 
            // clmSdtHV
            // 
            this.clmSdtHV.DataPropertyName = "PhoneNumber";
            this.clmSdtHV.HeaderText = "SĐT";
            this.clmSdtHV.MinimumWidth = 6;
            this.clmSdtHV.Name = "clmSdtHV";
            this.clmSdtHV.ReadOnly = true;
            // 
            // clmDiaChi
            // 
            this.clmDiaChi.DataPropertyName = "Address";
            this.clmDiaChi.HeaderText = "Địa chỉ";
            this.clmDiaChi.MinimumWidth = 6;
            this.clmDiaChi.Name = "clmDiaChi";
            this.clmDiaChi.ReadOnly = true;
            // 
            // clmNgayTiepNhan
            // 
            this.clmNgayTiepNhan.DataPropertyName = "EnrollmentDate";
            this.clmNgayTiepNhan.HeaderText = "Ngày tiếp nhận";
            this.clmNgayTiepNhan.MinimumWidth = 6;
            this.clmNgayTiepNhan.Name = "clmNgayTiepNhan";
            this.clmNgayTiepNhan.ReadOnly = true;
            // 
            // clmEmail
            // 
            this.clmEmail.DataPropertyName = "Email";
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.MinimumWidth = 6;
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1477, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1477, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ HỌC VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelActions.Controls.Add(this.btnHienTatCa);
            this.panelActions.Controls.Add(this.btnThem);
            this.panelActions.Controls.Add(this.btnSua);
            this.panelActions.Controls.Add(this.btnXoa);
            this.panelActions.Controls.Add(this.txtSearch);
            this.panelActions.Controls.Add(this.btnTimKiem);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActions.Location = new System.Drawing.Point(0, 60);
            this.panelActions.Margin = new System.Windows.Forms.Padding(0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1477, 60);
            this.panelActions.TabIndex = 1;
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHienTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienTatCa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHienTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHienTatCa.Location = new System.Drawing.Point(1304, 15);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(161, 36);
            this.btnHienTatCa.TabIndex = 4;
            this.btnHienTatCa.Text = "Hiện tất cả";
            this.btnHienTatCa.UseVisualStyleBackColor = false;
            this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(500, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(610, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 36);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(720, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(20, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 34);
            this.txtSearch.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(280, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(142, 36);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panelPaging
            // 
            this.panelPaging.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPaging.Controls.Add(this.btnPrev);
            this.panelPaging.Controls.Add(this.lblPageInfo);
            this.panelPaging.Controls.Add(this.btnNext);
            this.panelPaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaging.Location = new System.Drawing.Point(3, 592);
            this.panelPaging.Name = "panelPaging";
            this.panelPaging.Size = new System.Drawing.Size(1471, 44);
            this.panelPaging.TabIndex = 3;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(0, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(89, 44);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<< Trước";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPageInfo.Location = new System.Drawing.Point(551, 4);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(126, 34);
            this.lblPageInfo.TabIndex = 1;
            this.lblPageInfo.Text = "Trang 1/1";
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1386, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 44);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Sau >>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmQuanLyHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1477, 639);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyHocVien";
            this.Text = "Quản lý học viên";
            this.Load += new System.EventHandler(this.frmQuanLyHocVien_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSHV)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.panelPaging.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView gridDSHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSdtHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayTiepNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panelPaging;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnHienTatCa;
    }
}