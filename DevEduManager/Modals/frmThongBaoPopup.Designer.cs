namespace DevEduManager.Screens
{
    partial class frmThongBaoPopup
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmThongBaoPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmThongBaoPopup";
            this.Text = "Thông báo";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tiêu đề (*)";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.Location = new System.Drawing.Point(30, 60);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(430, 30);
            this.txtTitle.TabIndex = 1;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblContent.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblContent.Location = new System.Drawing.Point(30, 110);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(94, 23);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Nội dung (*)";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContent.Location = new System.Drawing.Point(30, 140);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(430, 160);
            this.txtContent.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(200, 320);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.SandyBrown;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(340, 320);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Add controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
