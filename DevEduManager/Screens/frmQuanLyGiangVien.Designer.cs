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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.gridGV = new System.Windows.Forms.DataGridView();
            this.clmMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioiTinhGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSdtGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelPaging = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelPaging.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.gridGV, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelActions, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelPaging, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1421, 613);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // gridGV
            // 
            this.gridGV.AllowUserToAddRows = false;
            this.gridGV.AllowUserToResizeRows = false;
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
            this.gridGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridGV.Location = new System.Drawing.Point(4, 149);
            this.gridGV.Margin = new System.Windows.Forms.Padding(4);
            this.gridGV.MultiSelect = false;
            this.gridGV.Name = "gridGV";
            this.gridGV.ReadOnly = true;
            this.gridGV.RowHeadersVisible = false;
            this.gridGV.RowHeadersWidth = 51;
            this.gridGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGV.Size = new System.Drawing.Size(1413, 410);
            this.gridGV.TabIndex = 4;
            this.gridGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGV_CellDoubleClick);
            // 
            // clmMaGV
            // 
            this.clmMaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmMaGV.DataPropertyName = "TeacherID";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.clmMaGV.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            this.clmTenGV.DefaultCellStyle = dataGridViewCellStyle2;
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
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1421, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1421, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ GIẢNG VIÊN";
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
            this.panelActions.Controls.Add(this.btnSearch);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActions.Location = new System.Drawing.Point(0, 60);
            this.panelActions.Margin = new System.Windows.Forms.Padding(0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1421, 85);
            this.panelActions.TabIndex = 1;
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHienTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienTatCa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHienTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHienTatCa.Location = new System.Drawing.Point(1234, 14);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(161, 36);
            this.btnHienTatCa.TabIndex = 5;
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
            this.btnThem.Size = new System.Drawing.Size(100, 50);
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
            this.btnSua.Size = new System.Drawing.Size(100, 50);
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
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(280, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 50);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panelPaging
            // 
            this.panelPaging.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPaging.Controls.Add(this.btnPrev);
            this.panelPaging.Controls.Add(this.lblPageInfo);
            this.panelPaging.Controls.Add(this.btnNext);
            this.panelPaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaging.Location = new System.Drawing.Point(3, 566);
            this.panelPaging.Name = "panelPaging";
            this.panelPaging.Size = new System.Drawing.Size(1415, 44);
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
            this.lblPageInfo.Location = new System.Drawing.Point(639, 0);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(178, 40);
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
            this.btnNext.Location = new System.Drawing.Point(1330, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 44);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Sau >>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmQuanLyGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1421, 613);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyGiangVien";
            this.Text = "Quản lý giảng viên";
            this.Load += new System.EventHandler(this.frmQuanLyGiangVien_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.panelPaging.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView gridGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioiTinhGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSdtGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmailGV;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelPaging;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnHienTatCa;
    }
}