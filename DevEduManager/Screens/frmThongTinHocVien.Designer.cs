namespace DevEduManager.Screens
{
    partial class frmThongTinHocVien
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaHV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelGrids = new System.Windows.Forms.TableLayoutPanel();
            this.gridChuongTrinh = new System.Windows.Forms.DataGridView();
            this.gridMonHoc = new System.Windows.Forms.DataGridView();
            this.clmSubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.clmCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.tableLayoutPanelGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChuongTrinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelContent, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelGrids, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.panelFooter, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(900, 510);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.btnQuayLai);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 48);
            this.panelHeader.TabIndex = 0;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuayLai.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(780, 0);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(120, 48);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(900, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN HỌC VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.lblHoTen);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.lblMaHV);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(3, 51);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(894, 94);
            this.panelContent.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(426, 24);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(25, 16);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "ten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên học viên:";
            // 
            // lblMaHV
            // 
            this.lblMaHV.AutoSize = true;
            this.lblMaHV.Location = new System.Drawing.Point(141, 24);
            this.lblMaHV.Name = "lblMaHV";
            this.lblMaHV.Size = new System.Drawing.Size(26, 16);
            this.lblMaHV.TabIndex = 1;
            this.lblMaHV.Text = "mã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên:";
            // 
            // tableLayoutPanelGrids
            // 
            this.tableLayoutPanelGrids.ColumnCount = 2;
            this.tableLayoutPanelGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.21029F));
            this.tableLayoutPanelGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.78971F));
            this.tableLayoutPanelGrids.Controls.Add(this.gridChuongTrinh, 0, 0);
            this.tableLayoutPanelGrids.Controls.Add(this.gridMonHoc, 1, 0);
            this.tableLayoutPanelGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGrids.Location = new System.Drawing.Point(3, 151);
            this.tableLayoutPanelGrids.Name = "tableLayoutPanelGrids";
            this.tableLayoutPanelGrids.RowCount = 1;
            this.tableLayoutPanelGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGrids.Size = new System.Drawing.Size(894, 336);
            this.tableLayoutPanelGrids.TabIndex = 2;
            // 
            // gridChuongTrinh
            // 
            this.gridChuongTrinh.AllowUserToAddRows = false;
            this.gridChuongTrinh.AllowUserToDeleteRows = false;
            this.gridChuongTrinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridChuongTrinh.ColumnHeadersHeight = 40;
            this.gridChuongTrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCourseID,
            this.clmCourseName});
            this.gridChuongTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridChuongTrinh.Location = new System.Drawing.Point(0, 0);
            this.gridChuongTrinh.Margin = new System.Windows.Forms.Padding(0);
            this.gridChuongTrinh.Name = "gridChuongTrinh";
            this.gridChuongTrinh.ReadOnly = true;
            this.gridChuongTrinh.RowHeadersVisible = false;
            this.gridChuongTrinh.RowHeadersWidth = 51;
            this.gridChuongTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridChuongTrinh.Size = new System.Drawing.Size(431, 336);
            this.gridChuongTrinh.TabIndex = 0;
            this.gridChuongTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridChuongTrinh_CellClick);
            // 
            // gridMonHoc
            // 
            this.gridMonHoc.AllowUserToAddRows = false;
            this.gridMonHoc.AllowUserToDeleteRows = false;
            this.gridMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMonHoc.ColumnHeadersHeight = 40;
            this.gridMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSubjectID,
            this.clmSubjectName});
            this.gridMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMonHoc.Location = new System.Drawing.Point(431, 0);
            this.gridMonHoc.Margin = new System.Windows.Forms.Padding(0);
            this.gridMonHoc.Name = "gridMonHoc";
            this.gridMonHoc.ReadOnly = true;
            this.gridMonHoc.RowHeadersVisible = false;
            this.gridMonHoc.RowHeadersWidth = 51;
            this.gridMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMonHoc.Size = new System.Drawing.Size(463, 336);
            this.gridMonHoc.TabIndex = 1;
            // 
            // clmSubjectID
            // 
            this.clmSubjectID.DataPropertyName = "SubjectID";
            this.clmSubjectID.HeaderText = "Mã môn học";
            this.clmSubjectID.MinimumWidth = 6;
            this.clmSubjectID.Name = "clmSubjectID";
            this.clmSubjectID.ReadOnly = true;
            this.clmSubjectID.Visible = false;
            // 
            // clmSubjectName
            // 
            this.clmSubjectName.DataPropertyName = "SubjectName";
            this.clmSubjectName.HeaderText = "Tên môn học";
            this.clmSubjectName.MinimumWidth = 6;
            this.clmSubjectName.Name = "clmSubjectName";
            this.clmSubjectName.ReadOnly = true;
            this.clmSubjectName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panelFooter
            // 
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFooter.Location = new System.Drawing.Point(3, 493);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(894, 14);
            this.panelFooter.TabIndex = 3;
            // 
            // clmCourseID
            // 
            this.clmCourseID.DataPropertyName = "CourseID";
            this.clmCourseID.HeaderText = "Mã khóa học";
            this.clmCourseID.MinimumWidth = 6;
            this.clmCourseID.Name = "clmCourseID";
            this.clmCourseID.ReadOnly = true;
            this.clmCourseID.Visible = false;
            // 
            // clmCourseName
            // 
            this.clmCourseName.DataPropertyName = "CourseName";
            this.clmCourseName.HeaderText = "Tên khóa học";
            this.clmCourseName.MinimumWidth = 6;
            this.clmCourseName.Name = "clmCourseName";
            this.clmCourseName.ReadOnly = true;
            this.clmCourseName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmThongTinHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongTinHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin học viên";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.tableLayoutPanelGrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChuongTrinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGrids;
        private System.Windows.Forms.DataGridView gridChuongTrinh;
        private System.Windows.Forms.DataGridView gridMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubjectName;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCourseName;
    }
}
