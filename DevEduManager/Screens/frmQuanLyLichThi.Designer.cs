namespace DevEduManager.Screens
{
    partial class frmQuanLyLichThi
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboCT = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.cboLH = new System.Windows.Forms.ComboBox();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.dtgvLichThi = new System.Windows.Forms.DataGridView();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemLich = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichThi)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.cboCT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTK, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboLH, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboKH, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtgvLichThi, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnThemLich, 9, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1431, 794);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cboCT
            // 
            this.cboCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCT.FormattingEnabled = true;
            this.cboCT.Location = new System.Drawing.Point(23, 69);
            this.cboCT.Name = "cboCT";
            this.cboCT.Size = new System.Drawing.Size(194, 24);
            this.cboCT.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 32);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ LỊCH THI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chương trình học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(233, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lớp học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(443, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kỳ học";
            // 
            // btnTK
            // 
            this.btnTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTK.Location = new System.Drawing.Point(653, 69);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(94, 32);
            this.btnTK.TabIndex = 16;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            // 
            // cboLH
            // 
            this.cboLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLH.FormattingEnabled = true;
            this.cboLH.Location = new System.Drawing.Point(233, 69);
            this.cboLH.Name = "cboLH";
            this.cboLH.Size = new System.Drawing.Size(194, 24);
            this.cboLH.TabIndex = 17;
            // 
            // cboKH
            // 
            this.cboKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(443, 69);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(194, 24);
            this.cboKH.TabIndex = 18;
            // 
            // dtgvLichThi
            // 
            this.dtgvLichThi.AllowUserToAddRows = false;
            this.dtgvLichThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLichThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamID,
            this.ExamName,
            this.ExamType,
            this.ExamDateStart,
            this.ExamDateEnd,
            this.Room,
            this.SubjectID,
            this.SubjectName});
            this.tableLayoutPanel1.SetColumnSpan(this.dtgvLichThi, 9);
            this.dtgvLichThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvLichThi.Location = new System.Drawing.Point(23, 150);
            this.dtgvLichThi.Name = "dtgvLichThi";
            this.dtgvLichThi.RowHeadersWidth = 51;
            this.dtgvLichThi.RowTemplate.Height = 24;
            this.dtgvLichThi.Size = new System.Drawing.Size(1385, 631);
            this.dtgvLichThi.TabIndex = 19;
            // 
            // ExamID
            // 
            this.ExamID.HeaderText = "Mã lịch thi";
            this.ExamID.MinimumWidth = 6;
            this.ExamID.Name = "ExamID";
            this.ExamID.Visible = false;
            // 
            // ExamName
            // 
            this.ExamName.HeaderText = "Tên lịch thi";
            this.ExamName.MinimumWidth = 6;
            this.ExamName.Name = "ExamName";
            // 
            // ExamType
            // 
            this.ExamType.HeaderText = "Kì thi";
            this.ExamType.MinimumWidth = 6;
            this.ExamType.Name = "ExamType";
            // 
            // ExamDateStart
            // 
            this.ExamDateStart.HeaderText = "Ngày bắt đầu";
            this.ExamDateStart.MinimumWidth = 6;
            this.ExamDateStart.Name = "ExamDateStart";
            // 
            // ExamDateEnd
            // 
            this.ExamDateEnd.HeaderText = "Ngày kết thúc";
            this.ExamDateEnd.MinimumWidth = 6;
            this.ExamDateEnd.Name = "ExamDateEnd";
            // 
            // Room
            // 
            this.Room.HeaderText = "Phòng thi";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            // 
            // SubjectID
            // 
            this.SubjectID.HeaderText = "Mã môn học";
            this.SubjectID.MinimumWidth = 6;
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.Visible = false;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "Tên môn học";
            this.SubjectName.MinimumWidth = 6;
            this.SubjectName.Name = "SubjectName";
            // 
            // btnThemLich
            // 
            this.btnThemLich.Location = new System.Drawing.Point(1114, 69);
            this.btnThemLich.Name = "btnThemLich";
            this.btnThemLich.Size = new System.Drawing.Size(101, 32);
            this.btnThemLich.TabIndex = 20;
            this.btnThemLich.Text = "Tạo lịch thi";
            this.btnThemLich.UseVisualStyleBackColor = true;
            this.btnThemLich.Click += new System.EventHandler(this.btnThemLich_Click);
            // 
            // frmQuanLyLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 794);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyLichThi";
            this.Text = "frmQuanLyLichThi";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboCT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.ComboBox cboLH;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.DataGridView dtgvLichThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.Button btnThemLich;
    }
}