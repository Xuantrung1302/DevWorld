using System.Windows.Forms;

namespace DevEduManager.Screens
{
    partial class frmLichThiHocSinh
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cboCT;
        private System.Windows.Forms.DataGridView dtgvLichThi;
        private System.Windows.Forms.Panel panelFooter;

        /// <summary>
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboCT = new System.Windows.Forms.ComboBox();
            this.dtgvLichThi = new System.Windows.Forms.DataGridView();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichThi)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelFilter, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dtgvLichThi, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.panelFooter, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.76923F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(914, 480);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(908, 54);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(344, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lịch Thi Của Bạn";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFilter.Controls.Add(this.lblMonHoc);
            this.panelFilter.Controls.Add(this.cboCT);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(3, 63);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(908, 67);
            this.panelFilter.TabIndex = 1;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMonHoc.Location = new System.Drawing.Point(34, 21);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(149, 23);
            this.lblMonHoc.TabIndex = 0;
            this.lblMonHoc.Text = "Chương trình học:";
            // 
            // cboCT
            // 
            this.cboCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCT.Location = new System.Drawing.Point(200, 13);
            this.cboCT.Name = "cboCT";
            this.cboCT.Size = new System.Drawing.Size(228, 31);
            this.cboCT.TabIndex = 1;
            // 
            // dtgvLichThi
            // 
            // 
            // dtgvLichThi
            // 
            this.dtgvLichThi.AllowUserToAddRows = false;
            this.dtgvLichThi.AllowUserToDeleteRows = false;
            this.dtgvLichThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLichThi.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLichThi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //this.dtgvLichThi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvLichThi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.SteelBlue;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            headerStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLichThi.ColumnHeadersDefaultCellStyle = headerStyle;

            this.dtgvLichThi.ColumnHeadersHeight = 35;
            this.dtgvLichThi.EnableHeadersVisualStyles = false;

            this.dtgvLichThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassName,
            this.SubjectName,
            this.ExamName,
            this.ExamType,
            this.ExamDateStart,
            this.ExamDateEnd,
            this.Room});
            this.dtgvLichThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvLichThi.Location = new System.Drawing.Point(3, 136);
            this.dtgvLichThi.Name = "dtgvLichThi";
            this.dtgvLichThi.ReadOnly = true;
            this.dtgvLichThi.RowHeadersVisible = false;
            this.dtgvLichThi.RowHeadersWidth = 51;
            this.dtgvLichThi.RowTemplate.Height = 30;
            this.dtgvLichThi.Size = new System.Drawing.Size(908, 300);
            this.dtgvLichThi.TabIndex = 2;

            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Tên lớp";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Tên môn học";
            this.SubjectName.MinimumWidth = 6;
            this.SubjectName.Name = "SubjectName";
            // 
            // ExamName
            // 
            this.ExamName.DataPropertyName = "ExamName";
            this.ExamName.HeaderText = "Tên kỳ thi";
            this.ExamName.MinimumWidth = 6;
            this.ExamName.Name = "ExamName";
            // 
            // ExamType
            // 
            this.ExamType.DataPropertyName = "ExamType";
            this.ExamType.HeaderText = "Kỳ thi";
            this.ExamType.MinimumWidth = 6;
            this.ExamType.Name = "ExamType";
            // 
            // ExamDateStart
            // 
            this.ExamDateStart.DataPropertyName = "ExamDateStart";
            this.ExamDateStart.HeaderText = "Ngày bắt đầu";
            this.ExamDateStart.MinimumWidth = 6;
            this.ExamDateStart.Name = "ExamDateStart";
            // 
            // ExamDateEnd
            // 
            this.ExamDateEnd.DataPropertyName = "ExamDateEnd";
            this.ExamDateEnd.HeaderText = "Ngày kết thúc";
            this.ExamDateEnd.MinimumWidth = 6;
            this.ExamDateEnd.Name = "ExamDateEnd";
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Phòng thi";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Moccasin;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFooter.Location = new System.Drawing.Point(3, 442);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(908, 35);
            this.panelFooter.TabIndex = 3;
            // 
            // frmLichThiHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLichThiHocSinh";
            this.Text = "Lịch Thi Học Viên";
            this.Load += new System.EventHandler(this.frmLichThiHocSinh_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichThi)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
    }
}
