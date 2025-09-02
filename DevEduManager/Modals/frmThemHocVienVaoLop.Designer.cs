using System.Windows.Forms;

namespace DevEduManager.Modals
{
    partial class frmThemHocVienVaoLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridListStudent = new System.Windows.Forms.DataGridView();
            this.MultiSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStuCur = new System.Windows.Forms.Label();
            this.lblAddStu = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListStudent)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridListStudent, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtCT, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtClass, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 800);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chương trình học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(405, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // gridListStudent
            // 
            this.gridListStudent.AllowUserToAddRows = false;
            this.gridListStudent.BackgroundColor = System.Drawing.Color.White;
            this.gridListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MultiSelect,
            this.StudentID,
            this.Fullname});
            this.tableLayoutPanel1.SetColumnSpan(this.gridListStudent, 3);
            this.gridListStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListStudent.GridColor = System.Drawing.Color.LightSalmon;
            this.gridListStudent.Location = new System.Drawing.Point(3, 168);
            this.gridListStudent.Name = "gridListStudent";
            this.gridListStudent.RowHeadersVisible = false;
            this.gridListStudent.RowHeadersWidth = 51;
            this.gridListStudent.RowTemplate.Height = 30;
            this.gridListStudent.Size = new System.Drawing.Size(794, 569);
            this.gridListStudent.TabIndex = 3;
            // 
            // MultiSelect
            // 
            this.MultiSelect.HeaderText = "";
            this.MultiSelect.MinimumWidth = 35;
            this.MultiSelect.Name = "MultiSelect";
            this.MultiSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MultiSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MultiSelect.Width = 35;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.StudentID.DefaultCellStyle = dataGridViewCellStyle9;
            this.StudentID.HeaderText = "Mã học viên";
            this.StudentID.MinimumWidth = 250;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 250;
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fullname.DataPropertyName = "Fullname";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.Fullname.DefaultCellStyle = dataGridViewCellStyle10;
            this.Fullname.HeaderText = "Họ và tên";
            this.Fullname.MinimumWidth = 500;
            this.Fullname.Name = "Fullname";
            // 
            // txtCT
            // 
            this.txtCT.BackColor = System.Drawing.Color.White;
            this.txtCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCT.Enabled = false;
            this.txtCT.Location = new System.Drawing.Point(3, 38);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(391, 22);
            this.txtCT.TabIndex = 4;
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.White;
            this.txtClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClass.Location = new System.Drawing.Point(405, 38);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(392, 22);
            this.txtClass.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightCoral;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.23755F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.76245F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStuCur, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAddStu, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 64);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số học sinh hiện tại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số học sinh cần thêm:";
            // 
            // lblStuCur
            // 
            this.lblStuCur.AutoSize = true;
            this.lblStuCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblStuCur.ForeColor = System.Drawing.Color.White;
            this.lblStuCur.Location = new System.Drawing.Point(230, 0);
            this.lblStuCur.Name = "lblStuCur";
            this.lblStuCur.Size = new System.Drawing.Size(65, 25);
            this.lblStuCur.TabIndex = 2;
            this.lblStuCur.Text = "num1";
            // 
            // lblAddStu
            // 
            this.lblAddStu.AutoSize = true;
            this.lblAddStu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAddStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddStu.ForeColor = System.Drawing.Color.White;
            this.lblAddStu.Location = new System.Drawing.Point(230, 32);
            this.lblAddStu.Name = "lblAddStu";
            this.lblAddStu.Size = new System.Drawing.Size(65, 25);
            this.lblAddStu.TabIndex = 3;
            this.lblAddStu.Text = "num2";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(715, 743);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 44);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmThemHocVienVaoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThemHocVienVaoLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm học viên vào lớp";
            this.Load += new System.EventHandler(this.frmThemHocVienVaoLop_Load);
            this.Shown += new System.EventHandler(this.frmThemHocVienVaoLop_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListStudent)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridListStudent;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStuCur;
        private System.Windows.Forms.Label lblAddStu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MultiSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
    }
}