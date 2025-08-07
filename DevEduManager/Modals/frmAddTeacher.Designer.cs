namespace DevEduManager.Screens
{
    partial class frmAddTeacher
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.panelTeacherList = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTeacher = new System.Windows.Forms.TableLayoutPanel();
            this.lblTeacherList = new System.Windows.Forms.Label();
            this.gridTeachers = new System.Windows.Forms.DataGridView();
            this.TeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActions = new System.Windows.Forms.Panel();
            this.tableLayoutPanelActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.tableLayoutPanelInfo.SuspendLayout();
            this.panelTeacherList.SuspendLayout();
            this.tableLayoutPanelTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeachers)).BeginInit();
            this.panelActions.SuspendLayout();
            this.tableLayoutPanelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(620, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm Giảng Viên";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelInfo, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelTeacherList, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelActions, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(620, 551);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.tableLayoutPanelInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(3, 2);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(614, 76);
            this.panelInfo.TabIndex = 0;
            // 
            // tableLayoutPanelInfo
            // 
            this.tableLayoutPanelInfo.ColumnCount = 2;
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInfo.Controls.Add(this.lblProgramName, 0, 0);
            this.tableLayoutPanelInfo.Controls.Add(this.txtProgramName, 1, 0);
            this.tableLayoutPanelInfo.Controls.Add(this.lblClassName, 0, 1);
            this.tableLayoutPanelInfo.Controls.Add(this.txtClassName, 1, 1);
            this.tableLayoutPanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInfo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            this.tableLayoutPanelInfo.RowCount = 2;
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInfo.Size = new System.Drawing.Size(614, 76);
            this.tableLayoutPanelInfo.TabIndex = 0;
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProgramName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblProgramName.Location = new System.Drawing.Point(3, 5);
            this.lblProgramName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(144, 23);
            this.lblProgramName.TabIndex = 0;
            this.lblProgramName.Text = "Tên chương trình:";
            // 
            // txtProgramName
            // 
            this.txtProgramName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProgramName.Enabled = false;
            this.txtProgramName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProgramName.Location = new System.Drawing.Point(156, 5);
            this.txtProgramName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.ReadOnly = true;
            this.txtProgramName.Size = new System.Drawing.Size(455, 30);
            this.txtProgramName.TabIndex = 1;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClassName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblClassName.Location = new System.Drawing.Point(3, 43);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(69, 23);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "Tên lớp:";
            // 
            // txtClassName
            // 
            this.txtClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClassName.Enabled = false;
            this.txtClassName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtClassName.Location = new System.Drawing.Point(156, 43);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(455, 30);
            this.txtClassName.TabIndex = 3;
            // 
            // panelTeacherList
            // 
            this.panelTeacherList.BackColor = System.Drawing.Color.White;
            this.panelTeacherList.Controls.Add(this.tableLayoutPanelTeacher);
            this.panelTeacherList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTeacherList.Location = new System.Drawing.Point(3, 82);
            this.panelTeacherList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTeacherList.Name = "panelTeacherList";
            this.panelTeacherList.Size = new System.Drawing.Size(614, 415);
            this.panelTeacherList.TabIndex = 1;
            // 
            // tableLayoutPanelTeacher
            // 
            this.tableLayoutPanelTeacher.ColumnCount = 1;
            this.tableLayoutPanelTeacher.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTeacher.Controls.Add(this.lblTeacherList, 0, 0);
            this.tableLayoutPanelTeacher.Controls.Add(this.gridTeachers, 0, 1);
            this.tableLayoutPanelTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTeacher.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelTeacher.Name = "tableLayoutPanelTeacher";
            this.tableLayoutPanelTeacher.RowCount = 2;
            this.tableLayoutPanelTeacher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTeacher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTeacher.Size = new System.Drawing.Size(614, 415);
            this.tableLayoutPanelTeacher.TabIndex = 0;
            // 
            // lblTeacherList
            // 
            this.lblTeacherList.AutoSize = true;
            this.lblTeacherList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTeacherList.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTeacherList.Location = new System.Drawing.Point(3, 5);
            this.lblTeacherList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblTeacherList.Name = "lblTeacherList";
            this.lblTeacherList.Size = new System.Drawing.Size(119, 20);
            this.lblTeacherList.TabIndex = 0;
            this.lblTeacherList.Text = "Danh sách GV";
            // 
            // gridTeachers
            // 
            this.gridTeachers.AllowUserToAddRows = false;
            this.gridTeachers.AllowUserToResizeRows = false;
            this.gridTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTeachers.BackgroundColor = System.Drawing.Color.White;
            this.gridTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTeachers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTeachers.ColumnHeadersHeight = 30;
            this.gridTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherID,
            this.FullName});
            this.gridTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTeachers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridTeachers.Location = new System.Drawing.Point(3, 32);
            this.gridTeachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridTeachers.MultiSelect = false;
            this.gridTeachers.Name = "gridTeachers";
            this.gridTeachers.ReadOnly = true;
            this.gridTeachers.RowHeadersVisible = false;
            this.gridTeachers.RowHeadersWidth = 51;
            this.gridTeachers.RowTemplate.Height = 28;
            this.gridTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTeachers.Size = new System.Drawing.Size(608, 381);
            this.gridTeachers.TabIndex = 1;
            // 
            // TeacherID
            // 
            this.TeacherID.DataPropertyName = "TeacherID";
            this.TeacherID.HeaderText = "Mã GV";
            this.TeacherID.MinimumWidth = 100;
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Tên GV";
            this.FullName.MinimumWidth = 200;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.White;
            this.panelActions.Controls.Add(this.tableLayoutPanelActions);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActions.Location = new System.Drawing.Point(3, 501);
            this.panelActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(614, 48);
            this.panelActions.TabIndex = 2;
            // 
            // tableLayoutPanelActions
            // 
            this.tableLayoutPanelActions.ColumnCount = 2;
            this.tableLayoutPanelActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActions.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanelActions.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelActions.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelActions.Name = "tableLayoutPanelActions";
            this.tableLayoutPanelActions.RowCount = 1;
            this.tableLayoutPanelActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelActions.Size = new System.Drawing.Size(614, 48);
            this.tableLayoutPanelActions.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(301, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(310, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(301, 44);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmAddTeacher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 601);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Giảng Viên";
            this.Load += new System.EventHandler(this.frmAddTeacher_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.PerformLayout();
            this.panelTeacherList.ResumeLayout(false);
            this.tableLayoutPanelTeacher.ResumeLayout(false);
            this.tableLayoutPanelTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeachers)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.tableLayoutPanelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInfo;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Panel panelTeacherList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTeacher;
        private System.Windows.Forms.Label lblTeacherList;
        private System.Windows.Forms.DataGridView gridTeachers;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    }
}