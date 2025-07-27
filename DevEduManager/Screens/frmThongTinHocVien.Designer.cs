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
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gridLopHoc = new System.Windows.Forms.DataGridView();
            this.clmChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelGrid, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(900, 637);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuayLai.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(739, 0);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(161, 60);
            this.btnQuayLai.TabIndex = 5;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
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
            this.panelHeader.Size = new System.Drawing.Size(900, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(900, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN HỌC VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Controls.Add(this.gridLopHoc);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(3, 63);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(10);
            this.panelGrid.Size = new System.Drawing.Size(894, 571);
            this.panelGrid.TabIndex = 1;
            // 
            // gridLopHoc
            // 
            this.gridLopHoc.AllowUserToAddRows = false;
            this.gridLopHoc.AllowUserToDeleteRows = false;
            this.gridLopHoc.AllowUserToResizeRows = false;
            this.gridLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLopHoc.BackgroundColor = System.Drawing.Color.White;
            this.gridLopHoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridLopHoc.ColumnHeadersHeight = 40;
            this.gridLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmChuongTrinh,
            this.clmMonHoc});
            this.gridLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLopHoc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLopHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLopHoc.Location = new System.Drawing.Point(10, 10);
            this.gridLopHoc.MultiSelect = false;
            this.gridLopHoc.Name = "gridLopHoc";
            this.gridLopHoc.ReadOnly = true;
            this.gridLopHoc.RowHeadersVisible = false;
            this.gridLopHoc.RowHeadersWidth = 51;
            this.gridLopHoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLopHoc.Size = new System.Drawing.Size(874, 551);
            this.gridLopHoc.TabIndex = 0;
            // 
            // clmChuongTrinh
            // 
            this.clmChuongTrinh.HeaderText = "Chương trình học";
            this.clmChuongTrinh.MinimumWidth = 6;
            this.clmChuongTrinh.Name = "clmChuongTrinh";
            this.clmChuongTrinh.ReadOnly = true;
            this.clmChuongTrinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmChuongTrinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmMonHoc
            // 
            this.clmMonHoc.HeaderText = "Môn học";
            this.clmMonHoc.MinimumWidth = 6;
            this.clmMonHoc.Name = "clmMonHoc";
            this.clmMonHoc.ReadOnly = true;
            this.clmMonHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmThongTinHocVien
            // 
            this.ClientSize = new System.Drawing.Size(900, 637);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongTinHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin học viên";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView gridLopHoc;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChuongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonHoc;
    }
}
