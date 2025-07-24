
namespace DevEduManager.Screens
{
    partial class frmXepLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gridDSHV = new System.Windows.Forms.DataGridView();
            this.clmMaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBoKhoiLop = new System.Windows.Forms.Button();
            this.lblTongCongHVLop = new System.Windows.Forms.Label();
            this.btnThemVaoLop = new System.Windows.Forms.Button();
            this.lblTongCongHV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plThoiKhoaBieu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSHV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1464, 30);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "XẾP LỚP";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1411, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // gridDSHV
            // 
            this.gridDSHV.AllowUserToAddRows = false;
            this.gridDSHV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDSHV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDSHV.BackgroundColor = System.Drawing.Color.White;
            this.gridDSHV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSHV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaHV,
            this.clmTenHV,
            this.clmMaPhieu,
            this.clmKhoaHoc});
            this.gridDSHV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDSHV.Location = new System.Drawing.Point(4, 4);
            this.gridDSHV.Margin = new System.Windows.Forms.Padding(4);
            this.gridDSHV.MultiSelect = false;
            this.gridDSHV.Name = "gridDSHV";
            this.gridDSHV.RowHeadersVisible = false;
            this.gridDSHV.RowHeadersWidth = 51;
            this.gridDSHV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDSHV.Size = new System.Drawing.Size(200, 650);
            this.gridDSHV.TabIndex = 13;
            // 
            // clmMaHV
            // 
            this.clmMaHV.DataPropertyName = "MaHV";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.clmMaHV.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmMaHV.HeaderText = "Mã học viên";
            this.clmMaHV.MinimumWidth = 6;
            this.clmMaHV.Name = "clmMaHV";
            // 
            // clmTenHV
            // 
            this.clmTenHV.DataPropertyName = "TenHV";
            this.clmTenHV.HeaderText = "Họ và tên";
            this.clmTenHV.MinimumWidth = 6;
            this.clmTenHV.Name = "clmTenHV";
            // 
            // clmMaPhieu
            // 
            this.clmMaPhieu.DataPropertyName = "MaPhieu";
            this.clmMaPhieu.HeaderText = "Mã phiếu";
            this.clmMaPhieu.MinimumWidth = 6;
            this.clmMaPhieu.Name = "clmMaPhieu";
            // 
            // clmKhoaHoc
            // 
            this.clmKhoaHoc.DataPropertyName = "TenKH";
            this.clmKhoaHoc.HeaderText = "Khóa học";
            this.clmKhoaHoc.MinimumWidth = 6;
            this.clmKhoaHoc.Name = "clmKhoaHoc";
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.btnBoKhoiLop);
            this.splitContainer1.Panel1.Controls.Add(this.lblTongCongHVLop);
            this.splitContainer1.Panel1.Controls.Add(this.btnThemVaoLop);
            this.splitContainer1.Panel1.Controls.Add(this.lblTongCongHV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1464, 872);
            this.splitContainer1.SplitterDistance = 417;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnBoKhoiLop
            // 
            this.btnBoKhoiLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBoKhoiLop.BackColor = System.Drawing.Color.Silver;
            this.btnBoKhoiLop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoKhoiLop.FlatAppearance.BorderSize = 0;
            this.btnBoKhoiLop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBoKhoiLop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBoKhoiLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoKhoiLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBoKhoiLop.Location = new System.Drawing.Point(171, 785);
            this.btnBoKhoiLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoKhoiLop.Name = "btnBoKhoiLop";
            this.btnBoKhoiLop.Size = new System.Drawing.Size(156, 42);
            this.btnBoKhoiLop.TabIndex = 72;
            this.btnBoKhoiLop.Text = "Bỏ khỏi lớp";
            this.btnBoKhoiLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoKhoiLop.UseVisualStyleBackColor = false;
            // 
            // lblTongCongHVLop
            // 
            this.lblTongCongHVLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongCongHVLop.AutoSize = true;
            this.lblTongCongHVLop.Location = new System.Drawing.Point(24, 800);
            this.lblTongCongHVLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongCongHVLop.Name = "lblTongCongHVLop";
            this.lblTongCongHVLop.Size = new System.Drawing.Size(138, 16);
            this.lblTongCongHVLop.TabIndex = 15;
            this.lblTongCongHVLop.Text = "Tổng cộng: 0 học viên";
            // 
            // btnThemVaoLop
            // 
            this.btnThemVaoLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemVaoLop.BackColor = System.Drawing.Color.Silver;
            this.btnThemVaoLop.FlatAppearance.BorderSize = 0;
            this.btnThemVaoLop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnThemVaoLop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemVaoLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoLop.Location = new System.Drawing.Point(220, 785);
            this.btnThemVaoLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemVaoLop.Name = "btnThemVaoLop";
            this.btnThemVaoLop.Size = new System.Drawing.Size(171, 42);
            this.btnThemVaoLop.TabIndex = 30;
            this.btnThemVaoLop.Text = "Thêm vào lớp";
            this.btnThemVaoLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemVaoLop.UseVisualStyleBackColor = false;
            // 
            // lblTongCongHV
            // 
            this.lblTongCongHV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongCongHV.AutoSize = true;
            this.lblTongCongHV.Location = new System.Drawing.Point(24, 842);
            this.lblTongCongHV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongCongHV.Name = "lblTongCongHV";
            this.lblTongCongHV.Size = new System.Drawing.Size(138, 16);
            this.lblTongCongHV.TabIndex = 14;
            this.lblTongCongHV.Text = "Tổng cộng: 0 học viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 872);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.plThoiKhoaBieu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 872);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // plThoiKhoaBieu
            // 
            this.plThoiKhoaBieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plThoiKhoaBieu.Location = new System.Drawing.Point(4, 4);
            this.plThoiKhoaBieu.Margin = new System.Windows.Forms.Padding(4);
            this.plThoiKhoaBieu.Name = "plThoiKhoaBieu";
            this.plThoiKhoaBieu.Size = new System.Drawing.Size(1034, 864);
            this.plThoiKhoaBieu.TabIndex = 73;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gridDSHV, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.45872F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.54128F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(417, 872);
            this.tableLayoutPanel2.TabIndex = 73;
            // 
            // frmXepLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1464, 902);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXepLop";
            this.Text = "frmXepLop";
            this.Load += new System.EventHandler(this.frmXepLop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSHV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnThemVaoLop;
        private System.Windows.Forms.Label lblTongCongHV;
        private System.Windows.Forms.DataGridView gridDSHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKhoaHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBoKhoiLop;
        private System.Windows.Forms.Label lblTongCongHVLop;
        private System.Windows.Forms.Panel plThoiKhoaBieu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}