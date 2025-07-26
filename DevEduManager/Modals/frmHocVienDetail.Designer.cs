namespace DevEduManager.Modals
{
    partial class frmHocVienDetail
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.lblMaHV = new System.Windows.Forms.Label();
            this.lblTenHV = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.grpDanhSachLop = new System.Windows.Forms.GroupBox();
            this.treeChuongTrinhHoc = new System.Windows.Forms.TreeView();

            this.tableLayoutPanelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.grpDanhSachLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelThongTin, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.grpDanhSachLop, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 600);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Text = "THÔNG TIN HỌC VIÊN";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelThongTin
            // 
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.panelThongTin.BackColor = System.Drawing.Color.WhiteSmoke;

            this.lblMaHV.Text = "Mã HV: HV001";
            this.lblTenHV.Text = "Tên: Nguyễn Văn A";
            this.lblNgaySinh.Text = "Ngày sinh: 01/01/2000";
            this.lblGioiTinh.Text = "Giới tính: Nam";
            this.lblEmail.Text = "Email: example@gmail.com";
            this.lblSdt.Text = "SĐT: 0123456789";
            this.lblDiaChi.Text = "Địa chỉ: Hà Nội";

            this.lblMaHV.Location = new System.Drawing.Point(20, 20);
            this.lblTenHV.Location = new System.Drawing.Point(20, 50);
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 80);
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 110);
            this.lblEmail.Location = new System.Drawing.Point(400, 20);
            this.lblSdt.Location = new System.Drawing.Point(400, 50);
            this.lblDiaChi.Location = new System.Drawing.Point(400, 80);

            this.panelThongTin.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.lblMaHV, this.lblTenHV, this.lblNgaySinh,
                this.lblGioiTinh, this.lblEmail, this.lblSdt, this.lblDiaChi
            });
            // 
            // grpDanhSachLop
            // 
            this.grpDanhSachLop.Text = "Danh sách lớp đã và đang học";
            this.grpDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSachLop.Controls.Add(this.treeChuongTrinhHoc);
            // 
            // treeChuongTrinhHoc
            // 
            this.treeChuongTrinhHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeChuongTrinhHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.treeChuongTrinhHoc.BackColor = System.Drawing.Color.White;

            // 
            // frmThongTinHocVien
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Text = "Thông tin học viên";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Label lblMaHV;
        private System.Windows.Forms.Label lblTenHV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.GroupBox grpDanhSachLop;
        private System.Windows.Forms.TreeView treeChuongTrinhHoc;
    }
}
