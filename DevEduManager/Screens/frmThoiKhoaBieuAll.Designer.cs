namespace DevEduManager.Screens
{
    partial class frmThoiKhoaBieuAll
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
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.cboKyHoc = new System.Windows.Forms.ComboBox();
            this.flpLich = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Controls.Add(this.cboMonHoc, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboKyHoc, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.flpLich, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.button1, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1283, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(748, 61);
            this.cboMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(367, 24);
            this.cboMonHoc.TabIndex = 6;
            // 
            // cboKyHoc
            // 
            this.cboKyHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboKyHoc.FormattingEnabled = true;
            this.cboKyHoc.Location = new System.Drawing.Point(168, 61);
            this.cboKyHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboKyHoc.Name = "cboKyHoc";
            this.cboKyHoc.Size = new System.Drawing.Size(221, 24);
            this.cboKyHoc.TabIndex = 1;
            this.cboKyHoc.SelectedIndexChanged += new System.EventHandler(this.cboKyHoc_SelectedIndexChanged);
            this.cboKyHoc.SelectedValueChanged += new System.EventHandler(this.cboKyHoc_SelectedValueChanged);
            // 
            // flpLich
            // 
            this.flpLich.AutoScroll = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flpLich, 7);
            this.flpLich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLich.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLich.Location = new System.Drawing.Point(32, 246);
            this.flpLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpLich.Name = "flpLich";
            this.flpLich.Size = new System.Drawing.Size(1215, 446);
            this.flpLich.TabIndex = 9;
            this.flpLich.WrapContents = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1121, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 208);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 22);
            this.button2.TabIndex = 10;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmThoiKhoaBieuAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThoiKhoaBieuAll";
            this.Text = "frmThoiKhoaBieuAll";
            this.Load += new System.EventHandler(this.frmThoiKhoaBieuAll_Load_1);
            this.Shown += new System.EventHandler(this.frmThoiKhoaBieuAll_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboKyHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpLich;
        private System.Windows.Forms.Button button2;
    }
}