﻿namespace DevEduManager.Screens
{
    partial class frmQuanLyKhoaHoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvCT = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCT = new System.Windows.Forms.ComboBox();
            this.btnCT = new System.Windows.Forms.Button();
            this.courseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemesterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 25);
            this.panel1.TabIndex = 6;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.41252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.58748F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtgvCT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboCT, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCT, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.896552F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.10345F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1427, 617);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // dtgvCT
            // 
            this.dtgvCT.AllowUserToAddRows = false;
            this.dtgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseid,
            this.coursename,
            this.coursecode,
            this.SubjectName,
            this.SemesterName,
            this.Fee});
            this.tableLayoutPanel1.SetColumnSpan(this.dtgvCT, 2);
            this.dtgvCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCT.Location = new System.Drawing.Point(3, 113);
            this.dtgvCT.Name = "dtgvCT";
            this.dtgvCT.RowHeadersVisible = false;
            this.dtgvCT.RowHeadersWidth = 51;
            this.dtgvCT.RowTemplate.Height = 24;
            this.dtgvCT.Size = new System.Drawing.Size(1421, 480);
            this.dtgvCT.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn chương trình học";
            // 
            // cboCT
            // 
            this.cboCT.FormattingEnabled = true;
            this.cboCT.Location = new System.Drawing.Point(3, 77);
            this.cboCT.Name = "cboCT";
            this.cboCT.Size = new System.Drawing.Size(279, 24);
            this.cboCT.TabIndex = 9;
            // 
            // btnCT
            // 
            this.btnCT.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCT.Location = new System.Drawing.Point(1289, 77);
            this.btnCT.Name = "btnCT";
            this.btnCT.Size = new System.Drawing.Size(135, 30);
            this.btnCT.TabIndex = 10;
            this.btnCT.Text = "Thêm chương trình";
            this.btnCT.UseVisualStyleBackColor = true;
            // 
            // courseid
            // 
            this.courseid.DataPropertyName = "course_id";
            this.courseid.HeaderText = "ID chương trình";
            this.courseid.MinimumWidth = 6;
            this.courseid.Name = "courseid";
            this.courseid.Visible = false;
            // 
            // coursename
            // 
            this.coursename.DataPropertyName = "CourseName";
            this.coursename.HeaderText = "Tên chương trình";
            this.coursename.MinimumWidth = 6;
            this.coursename.Name = "coursename";
            this.coursename.Visible = false;
            // 
            // coursecode
            // 
            this.coursecode.DataPropertyName = "course_code";
            this.coursecode.HeaderText = "Mã chương trình";
            this.coursecode.MinimumWidth = 6;
            this.coursecode.Name = "coursecode";
            this.coursecode.Visible = false;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Tên môn học";
            this.SubjectName.MinimumWidth = 6;
            this.SubjectName.Name = "SubjectName";
            // 
            // SemesterName
            // 
            this.SemesterName.DataPropertyName = "SemesterName";
            this.SemesterName.HeaderText = "Tên học kỳ";
            this.SemesterName.MinimumWidth = 6;
            this.SemesterName.Name = "SemesterName";
            // 
            // Fee
            // 
            this.Fee.DataPropertyName = "TuitionFee";
            this.Fee.HeaderText = "Học phí";
            this.Fee.MinimumWidth = 6;
            this.Fee.Name = "Fee";
            // 
            // frmQuanLyKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1427, 617);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyKhoaHoc";
            this.Text = "Quản lý khóa học";
            this.Load += new System.EventHandler(this.frmQuanLyKhoaHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgvCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCT;
        private System.Windows.Forms.Button btnCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursename;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemesterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee;
    }
}