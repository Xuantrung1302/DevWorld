namespace DevEduManager.Screens
{
    partial class frmQuanLyLopHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.tableLayoutPanelSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridLop = new System.Windows.Forms.DataGridView();
            this.panelStudentList = new System.Windows.Forms.Panel();
            this.tableLayoutPanelStudents = new System.Windows.Forms.TableLayoutPanel();
            this.lblStudentListTitle = new System.Windows.Forms.Label();
            this.gridListStudent = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActions = new System.Windows.Forms.Panel();
            this.tableLayoutPanelActions = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCT = new System.Windows.Forms.ComboBox();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.tableLayoutPanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).BeginInit();
            this.panelStudentList.SuspendLayout();
            this.tableLayoutPanelStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListStudent)).BeginInit();
            this.panelActions.SuspendLayout();
            this.tableLayoutPanelActions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(1200, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelSearch, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelStudentList, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelActions, 1, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1200, 600);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.tableLayoutPanelSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(3, 2);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(394, 536);
            this.panelSearch.TabIndex = 0;
            // 
            // tableLayoutPanelSearch
            // 
            this.tableLayoutPanelSearch.ColumnCount = 2;
            this.tableLayoutPanelSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearch.Controls.Add(this.gridLop, 0, 3);
            this.tableLayoutPanelSearch.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelSearch.Controls.Add(this.btnSearch, 0, 2);
            this.tableLayoutPanelSearch.Controls.Add(this.lblTotalStudents, 1, 2);
            this.tableLayoutPanelSearch.Controls.Add(this.txtTenMon, 1, 1);
            this.tableLayoutPanelSearch.Controls.Add(this.lblClassName, 0, 1);
            this.tableLayoutPanelSearch.Controls.Add(this.cboCT, 1, 0);
            this.tableLayoutPanelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearch.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelSearch.Name = "tableLayoutPanelSearch";
            this.tableLayoutPanelSearch.RowCount = 4;
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelSearch.Size = new System.Drawing.Size(394, 536);
            this.tableLayoutPanelSearch.TabIndex = 0;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClassName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblClassName.Location = new System.Drawing.Point(3, 55);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(69, 23);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "Tên lớp:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenMon.Location = new System.Drawing.Point(123, 55);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(268, 30);
            this.txtTenMon.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(3, 102);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gridLop
            // 
            this.gridLop.AllowUserToAddRows = false;
            this.gridLop.AllowUserToResizeRows = false;
            this.gridLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLop.BackgroundColor = System.Drawing.Color.White;
            this.gridLop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLop.ColumnHeadersHeight = 30;
            this.gridLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.ClassName,
            this.Status,
            this.StatusText});
            this.tableLayoutPanelSearch.SetColumnSpan(this.gridLop, 2);
            this.gridLop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLop.Location = new System.Drawing.Point(3, 152);
            this.gridLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridLop.MultiSelect = false;
            this.gridLop.Name = "gridLop";
            this.gridLop.ReadOnly = true;
            this.gridLop.RowHeadersVisible = false;
            this.gridLop.RowHeadersWidth = 51;
            this.gridLop.RowTemplate.Height = 28;
            this.gridLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLop.Size = new System.Drawing.Size(388, 382);
            this.gridLop.TabIndex = 4;
            this.gridLop.SelectionChanged += new System.EventHandler(this.gridLop_SelectionChanged);
            // 
            // panelStudentList
            // 
            this.panelStudentList.BackColor = System.Drawing.Color.White;
            this.panelStudentList.Controls.Add(this.tableLayoutPanelStudents);
            this.panelStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudentList.Location = new System.Drawing.Point(403, 2);
            this.panelStudentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelStudentList.Name = "panelStudentList";
            this.panelStudentList.Size = new System.Drawing.Size(794, 536);
            this.panelStudentList.TabIndex = 1;
            // 
            // tableLayoutPanelStudents
            // 
            this.tableLayoutPanelStudents.ColumnCount = 1;
            this.tableLayoutPanelStudents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStudents.Controls.Add(this.lblStudentListTitle, 0, 0);
            this.tableLayoutPanelStudents.Controls.Add(this.gridListStudent, 0, 1);
            this.tableLayoutPanelStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStudents.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelStudents.Name = "tableLayoutPanelStudents";
            this.tableLayoutPanelStudents.RowCount = 3;
            this.tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStudents.Size = new System.Drawing.Size(794, 536);
            this.tableLayoutPanelStudents.TabIndex = 0;
            // 
            // lblStudentListTitle
            // 
            this.lblStudentListTitle.AutoSize = true;
            this.lblStudentListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStudentListTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblStudentListTitle.Location = new System.Drawing.Point(3, 5);
            this.lblStudentListTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStudentListTitle.Name = "lblStudentListTitle";
            this.lblStudentListTitle.Size = new System.Drawing.Size(196, 28);
            this.lblStudentListTitle.TabIndex = 0;
            this.lblStudentListTitle.Text = "Danh sách học viên";
            // 
            // gridListStudent
            // 
            this.gridListStudent.AllowUserToAddRows = false;
            this.gridListStudent.AllowUserToResizeRows = false;
            this.gridListStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListStudent.BackgroundColor = System.Drawing.Color.White;
            this.gridListStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridListStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListStudent.ColumnHeadersHeight = 30;
            this.gridListStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FullName,
            this.Gender});
            this.gridListStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListStudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridListStudent.Location = new System.Drawing.Point(3, 42);
            this.gridListStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridListStudent.MultiSelect = false;
            this.gridListStudent.Name = "gridListStudent";
            this.gridListStudent.ReadOnly = true;
            this.gridListStudent.RowHeadersVisible = false;
            this.gridListStudent.RowHeadersWidth = 51;
            this.tableLayoutPanelStudents.SetRowSpan(this.gridListStudent, 2);
            this.gridListStudent.RowTemplate.Height = 28;
            this.gridListStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListStudent.Size = new System.Drawing.Size(788, 492);
            this.gridListStudent.TabIndex = 1;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "Mã học viên";
            this.StudentID.MinimumWidth = 100;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            this.FullName.DefaultCellStyle = dataGridViewCellStyle3;
            this.FullName.HeaderText = "Tên học viên";
            this.FullName.MinimumWidth = 300;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.MinimumWidth = 100;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.White;
            this.panelActions.Controls.Add(this.tableLayoutPanelActions);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActions.Location = new System.Drawing.Point(403, 542);
            this.panelActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(794, 56);
            this.panelActions.TabIndex = 2;
            // 
            // tableLayoutPanelActions
            // 
            this.tableLayoutPanelActions.ColumnCount = 2;
            this.tableLayoutPanelActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActions.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelActions.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelActions.Name = "tableLayoutPanelActions";
            this.tableLayoutPanelActions.RowCount = 1;
            this.tableLayoutPanelActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelActions.Size = new System.Drawing.Size(794, 56);
            this.tableLayoutPanelActions.TabIndex = 0;
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalStudents.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotalStudents.Location = new System.Drawing.Point(123, 102);
            this.lblTotalStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(179, 23);
            this.lblTotalStudents.TabIndex = 2;
            this.lblTotalStudents.Text = "Tổng cộng: 0 học viên";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddStudent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddTeacher, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(400, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 50);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddTeacher.FlatAppearance.BorderSize = 0;
            this.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddTeacher.Location = new System.Drawing.Point(198, 2);
            this.btnAddTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(190, 46);
            this.btnAddTeacher.TabIndex = 1;
            this.btnAddTeacher.Text = "Thêm giáo viên";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(3, 2);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(189, 46);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Thêm học viên";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chương trình học:";
            // 
            // cboCT
            // 
            this.cboCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCT.FormattingEnabled = true;
            this.cboCT.Location = new System.Drawing.Point(123, 3);
            this.cboCT.Name = "cboCT";
            this.cboCT.Size = new System.Drawing.Size(268, 24);
            this.cboCT.TabIndex = 4;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "Mã Lớp";
            this.ClassID.MinimumWidth = 6;
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Visible = false;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            this.ClassName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClassName.FillWeight = 66.31017F;
            this.ClassName.HeaderText = "Tên lớp";
            this.ClassName.MinimumWidth = 250;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 133.6898F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 125;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // StatusText
            // 
            this.StatusText.DataPropertyName = "StatusText";
            this.StatusText.HeaderText = "Trạng thái";
            this.StatusText.MinimumWidth = 6;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            // 
            // frmQuanLyLopHoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyLopHoc";
            this.Text = "Quản lý lớp học";
            this.Load += new System.EventHandler(this.frmQuanLyLopHoc_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.tableLayoutPanelSearch.ResumeLayout(false);
            this.tableLayoutPanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).EndInit();
            this.panelStudentList.ResumeLayout(false);
            this.tableLayoutPanelStudents.ResumeLayout(false);
            this.tableLayoutPanelStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListStudent)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.tableLayoutPanelActions.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearch;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gridLop;
        private System.Windows.Forms.Panel panelStudentList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStudents;
        private System.Windows.Forms.Label lblStudentListTitle;
        private System.Windows.Forms.DataGridView gridListStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelActions;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusText;
    }
}