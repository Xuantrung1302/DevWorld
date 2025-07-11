namespace DevEduManager.Screens
{
    partial class frmDiemDanhGiaoVien
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvHV = new System.Windows.Forms.DataGridView();
            this.clmMaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiemDanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboKyHoc = new System.Windows.Forms.ComboBox();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboNgayHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHV)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvHV, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1453, 571);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 30);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐIỂM DANH";
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLuu.Location = new System.Drawing.Point(1375, 523);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 35);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvHV
            // 
            this.dgvHV.AllowUserToAddRows = false;
            this.dgvHV.AllowUserToOrderColumns = true;
            this.dgvHV.AllowUserToResizeRows = false;
            this.dgvHV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHV.BackgroundColor = System.Drawing.Color.White;
            this.dgvHV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaHV,
            this.clmMaDiemDanh,
            this.clmTenHV,
            this.clmDiemDanh,
            this.clmNote});
            this.dgvHV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHV.Location = new System.Drawing.Point(4, 235);
            this.dgvHV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHV.MultiSelect = false;
            this.dgvHV.Name = "dgvHV";
            this.dgvHV.RowHeadersVisible = false;
            this.dgvHV.RowHeadersWidth = 51;
            this.dgvHV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHV.Size = new System.Drawing.Size(1445, 282);
            this.dgvHV.TabIndex = 2;
            this.dgvHV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHV_CellValueChanged);
            this.dgvHV.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvHV_CurrentCellDirtyStateChanged);
            // 
            // clmMaHV
            // 
            this.clmMaHV.DataPropertyName = "StudentID";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.clmMaHV.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmMaHV.FillWeight = 75F;
            this.clmMaHV.HeaderText = "Mã học viên";
            this.clmMaHV.MinimumWidth = 6;
            this.clmMaHV.Name = "clmMaHV";
            // 
            // clmMaDiemDanh
            // 
            this.clmMaDiemDanh.DataPropertyName = "AttendanceID";
            this.clmMaDiemDanh.HeaderText = "Mã điểm danh";
            this.clmMaDiemDanh.MinimumWidth = 6;
            this.clmMaDiemDanh.Name = "clmMaDiemDanh";
            this.clmMaDiemDanh.Visible = false;
            // 
            // clmTenHV
            // 
            this.clmTenHV.DataPropertyName = "StudentName";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            this.clmTenHV.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmTenHV.FillWeight = 110F;
            this.clmTenHV.HeaderText = "Họ và tên";
            this.clmTenHV.MinimumWidth = 6;
            this.clmTenHV.Name = "clmTenHV";
            // 
            // clmDiemDanh
            // 
            this.clmDiemDanh.DataPropertyName = "IsChecked";
            this.clmDiemDanh.HeaderText = "Điểm danh";
            this.clmDiemDanh.MinimumWidth = 6;
            this.clmDiemDanh.Name = "clmDiemDanh";
            this.clmDiemDanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmDiemDanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmNote
            // 
            this.clmNote.DataPropertyName = "Notes";
            this.clmNote.HeaderText = "Ghi chú";
            this.clmNote.MinimumWidth = 6;
            this.clmNote.Name = "clmNote";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cboKyHoc, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cboMonHoc, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.cboLop, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.cboNgayHoc, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 3, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1447, 189);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // cboKyHoc
            // 
            this.cboKyHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboKyHoc.FormattingEnabled = true;
            this.cboKyHoc.Location = new System.Drawing.Point(412, 28);
            this.cboKyHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboKyHoc.Name = "cboKyHoc";
            this.cboKyHoc.Size = new System.Drawing.Size(303, 24);
            this.cboKyHoc.TabIndex = 0;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMonHoc.Enabled = false;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(741, 28);
            this.cboMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(293, 24);
            this.cboMonHoc.TabIndex = 1;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // cboLop
            // 
            this.cboLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLop.Enabled = false;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(412, 97);
            this.cboLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(303, 24);
            this.cboLop.TabIndex = 2;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // cboNgayHoc
            // 
            this.cboNgayHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNgayHoc.Enabled = false;
            this.cboNgayHoc.FormattingEnabled = true;
            this.cboNgayHoc.Location = new System.Drawing.Point(741, 97);
            this.cboNgayHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNgayHoc.Name = "cboNgayHoc";
            this.cboNgayHoc.Size = new System.Drawing.Size(293, 24);
            this.cboNgayHoc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(412, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn kỳ học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(412, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn lớp thành phần";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(741, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(741, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chọn ngày học";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(959, 146);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmDiemDanhGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDiemDanhGiaoVien";
            this.Text = "frmDiemDanhGiaoVien";
            this.Load += new System.EventHandler(this.frmDiemDanhGiaoVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHV)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvHV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cboKyHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboNgayHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenHV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNote;
    }
}