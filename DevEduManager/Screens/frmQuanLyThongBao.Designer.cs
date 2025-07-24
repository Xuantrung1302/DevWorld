namespace DevEduManager.Screens
{
    partial class frmQuanLyThongBao
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgvThongBao = new System.Windows.Forms.DataGridView();
            this.NewsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnThem);
            this.panelHeader.Controls.Add(this.btnSua);
            this.panelHeader.Controls.Add(this.btnXoa);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(862, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THÔNG BÁO";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(350, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Khaki;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(450, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Salmon;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(550, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtgvThongBao
            // 
            this.dtgvThongBao.AllowUserToAddRows = false;
            this.dtgvThongBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThongBao.BackgroundColor = System.Drawing.Color.White;
            this.dtgvThongBao.ColumnHeadersHeight = 29;
            this.dtgvThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NewsID,
            this.Title,
            this.Content,
            this.PostDate,
            this.PostedBy});
            this.dtgvThongBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvThongBao.Location = new System.Drawing.Point(0, 60);
            this.dtgvThongBao.MultiSelect = false;
            this.dtgvThongBao.Name = "dtgvThongBao";
            this.dtgvThongBao.ReadOnly = true;
            this.dtgvThongBao.RowHeadersVisible = false;
            this.dtgvThongBao.RowHeadersWidth = 51;
            this.dtgvThongBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvThongBao.Size = new System.Drawing.Size(862, 540);
            this.dtgvThongBao.TabIndex = 0;
            // 
            // NewsID
            // 
            this.NewsID.DataPropertyName = "NewsID";
            this.NewsID.HeaderText = "NewsID";
            this.NewsID.MinimumWidth = 6;
            this.NewsID.Name = "NewsID";
            this.NewsID.ReadOnly = true;
            this.NewsID.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Tiêu đề";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.HeaderText = "Nội dung";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // PostDate
            // 
            this.PostDate.DataPropertyName = "PostDate";
            this.PostDate.HeaderText = "Ngày đăng";
            this.PostDate.MinimumWidth = 6;
            this.PostDate.Name = "PostDate";
            this.PostDate.ReadOnly = true;
            // 
            // PostedBy
            // 
            this.PostedBy.DataPropertyName = "PostedBy";
            this.PostedBy.HeaderText = "Người đăng";
            this.PostedBy.MinimumWidth = 6;
            this.PostedBy.Name = "PostedBy";
            this.PostedBy.ReadOnly = true;
            // 
            // frmQuanLyThongBao
            // 
            this.ClientSize = new System.Drawing.Size(862, 600);
            this.Controls.Add(this.dtgvThongBao);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Báo";
            this.Load += new System.EventHandler(this.frmQuanLyThongBao_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtgvThongBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostedBy;
    }
}
