namespace DevEduManager.Screens
{
    partial class frmThongTinCaNhan
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

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMa, lblHoTen, lblGioiTinh, lblDiaChi, lblEmail, lblSDT;
        private System.Windows.Forms.TextBox txtMa, txtHoTen, txtDiaChi, txtEmail, txtSDT;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblMa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMa, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHoTen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHoTen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGioiTinh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDiaChi, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDiaChi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSDT, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSDT, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSex, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMa
            // 
            this.lblMa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMa.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMa.Location = new System.Drawing.Point(3, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(94, 23);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã:";
            this.lblMa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMa
            // 
            this.txtMa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMa.Location = new System.Drawing.Point(103, 3);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(688, 30);
            this.txtMa.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHoTen.Location = new System.Drawing.Point(3, 50);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(94, 23);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(103, 53);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(688, 30);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGioiTinh.Location = new System.Drawing.Point(3, 100);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(94, 23);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiaChi.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDiaChi.Location = new System.Drawing.Point(3, 150);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(94, 23);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ:";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDiaChi.Location = new System.Drawing.Point(103, 153);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(688, 30);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEmail.Location = new System.Drawing.Point(3, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 23);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(103, 203);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(688, 30);
            this.txtEmail.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSDT.Location = new System.Drawing.Point(103, 253);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(688, 30);
            this.txtSDT.TabIndex = 11;
            // 
            // lblSDT
            // 
            this.lblSDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSDT.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSDT.Location = new System.Drawing.Point(3, 250);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(94, 23);
            this.lblSDT.TabIndex = 10;
            this.lblSDT.Text = "Số điện thoại:";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSex.Location = new System.Drawing.Point(103, 103);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(688, 30);
            this.txtSex.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.55556F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.44444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel2.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(4, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(792, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "THÔNG TIN CÁ NHÂN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongTinCaNhan";
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.frmThongTinCaNhan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSex;
    }
}
