namespace DevEduManager.Modals
{
    partial class frmNhapDiemMoi
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.cboCT = new System.Windows.Forms.ComboBox();
            this.cboLH = new System.Windows.Forms.ComboBox();
            this.cboMH = new System.Windows.Forms.ComboBox();
            this.dgvNhapDiem = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelFilter, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dgvNhapDiem, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.panelFooter, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(894, 44);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(20, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(204, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Nhập kết quả thi";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFilter.Controls.Add(this.tableLayoutPanel1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(3, 53);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(894, 64);
            this.panelFilter.TabIndex = 1;
            // 
            // cboCT
            // 
            this.cboCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCT.Location = new System.Drawing.Point(3, 27);
            this.cboCT.Name = "cboCT";
            this.cboCT.Size = new System.Drawing.Size(291, 31);
            this.cboCT.TabIndex = 0;
            // 
            // cboLH
            // 
            this.cboLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLH.Location = new System.Drawing.Point(300, 27);
            this.cboLH.Name = "cboLH";
            this.cboLH.Size = new System.Drawing.Size(291, 31);
            this.cboLH.TabIndex = 1;
            // 
            // cboMH
            // 
            this.cboMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMH.Location = new System.Drawing.Point(597, 27);
            this.cboMH.Name = "cboMH";
            this.cboMH.Size = new System.Drawing.Size(294, 31);
            this.cboMH.TabIndex = 2;
            // 
            // dgvNhapDiem
            // 
            this.dgvNhapDiem.AllowUserToAddRows = false;
            this.dgvNhapDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhapDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FullName,
            this.Score});
            this.dgvNhapDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapDiem.Location = new System.Drawing.Point(3, 123);
            this.dgvNhapDiem.Name = "dgvNhapDiem";
            this.dgvNhapDiem.RowHeadersVisible = false;
            this.dgvNhapDiem.RowHeadersWidth = 51;
            this.dgvNhapDiem.RowTemplate.Height = 28;
            this.dgvNhapDiem.Size = new System.Drawing.Size(894, 414);
            this.dgvNhapDiem.TabIndex = 2;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFooter.Controls.Add(this.btnLuu);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFooter.Location = new System.Drawing.Point(3, 543);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(894, 54);
            this.panelFooter.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(730, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(140, 35);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "LƯU ĐIỂM";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.cboMH, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboCT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboLH, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(894, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chương trình học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(300, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lớp học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(597, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Môn học";
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "Mã học viên";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "Điểm";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            // 
            // frmNhapDiemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "frmNhapDiemMoi";
            this.Text = "Nhập điểm học viên";
            this.Load += new System.EventHandler(this.frmNhapDiemMoi_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox cboCT;
        private System.Windows.Forms.ComboBox cboLH;
        private System.Windows.Forms.ComboBox cboMH;
        private System.Windows.Forms.DataGridView dgvNhapDiem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}
