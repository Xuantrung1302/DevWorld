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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboChuongTrinhHoc = new System.Windows.Forms.ComboBox();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.cboNgayHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvHV = new System.Windows.Forms.DataGridView();
            this.ColMaHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiemDanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvHV, 0, 2);
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
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 30);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐIỂM DANH";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLuu.Location = new System.Drawing.Point(1338, 523);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 35);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cboChuongTrinhHoc, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cboLopHoc, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.cboMonHoc, 1, 5);
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
            // cboChuongTrinhHoc
            // 
            this.cboChuongTrinhHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChuongTrinhHoc.FormattingEnabled = true;
            this.cboChuongTrinhHoc.Location = new System.Drawing.Point(412, 28);
            this.cboChuongTrinhHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChuongTrinhHoc.Name = "cboChuongTrinhHoc";
            this.cboChuongTrinhHoc.Size = new System.Drawing.Size(303, 24);
            this.cboChuongTrinhHoc.TabIndex = 0;
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLopHoc.Enabled = false;
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(741, 28);
            this.cboLopHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(293, 24);
            this.cboLopHoc.TabIndex = 1;
            this.cboLopHoc.SelectedIndexChanged += new System.EventHandler(this.cboLopHoc_SelectedIndexChanged);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMonHoc.Enabled = false;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(412, 97);
            this.cboMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(303, 24);
            this.cboMonHoc.TabIndex = 2;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMon_SelectedIndexChanged);
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
            this.cboNgayHoc.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboNgayHoc_Format);
            this.cboNgayHoc.EnabledChanged += new System.EventHandler(this.cboNgayHoc_EnabledChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(412, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn chương trình học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(412, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(741, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn lớp học";
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
            this.btnSearch.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Enabled = false;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(959, 146);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvHV
            // 
            this.dgvHV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaHocVien,
            this.ColTen,
            this.ColDiemDanh,
            this.ColGhiChu});
            this.dgvHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHV.Location = new System.Drawing.Point(3, 234);
            this.dgvHV.Name = "dgvHV";
            this.dgvHV.RowHeadersWidth = 51;
            this.dgvHV.RowTemplate.Height = 24;
            this.dgvHV.Size = new System.Drawing.Size(1447, 284);
            this.dgvHV.TabIndex = 18;
            // 
            // ColMaHocVien
            // 
            this.ColMaHocVien.DataPropertyName = "StudentID";
            this.ColMaHocVien.HeaderText = "Mã học viên";
            this.ColMaHocVien.MinimumWidth = 6;
            this.ColMaHocVien.Name = "ColMaHocVien";
            this.ColMaHocVien.ReadOnly = true;
            // 
            // ColTen
            // 
            this.ColTen.DataPropertyName = "StudentName";
            this.ColTen.HeaderText = "Họ và tên";
            this.ColTen.MinimumWidth = 6;
            this.ColTen.Name = "ColTen";
            this.ColTen.ReadOnly = true;
            // 
            // ColDiemDanh
            // 
            this.ColDiemDanh.DataPropertyName = "Status";
            this.ColDiemDanh.HeaderText = "Điểm danh";
            this.ColDiemDanh.MinimumWidth = 6;
            this.ColDiemDanh.Name = "ColDiemDanh";
            // 
            // ColGhiChu
            // 
            this.ColGhiChu.DataPropertyName = "Notes";
            this.ColGhiChu.HeaderText = "Ghi Chú";
            this.ColGhiChu.MinimumWidth = 6;
            this.ColGhiChu.Name = "ColGhiChu";
            this.ColGhiChu.ReadOnly = true;
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cboChuongTrinhHoc;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.ComboBox cboNgayHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaHocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGhiChu;
    }
}