namespace DevEduManager.Modals
{
    partial class frmTaoLichThi
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtKyThi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCT = new System.Windows.Forms.ComboBox();
            this.cboLH = new System.Windows.Forms.ComboBox();
            this.cboMH = new System.Windows.Forms.ComboBox();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpkNgayThi = new System.Windows.Forms.DateTimePicker();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(220, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TẠO LỊCH THI";
            // 
            // txtKyThi
            // 
            this.txtKyThi.Location = new System.Drawing.Point(20, 95);
            this.txtKyThi.Name = "txtKyThi";
            this.txtKyThi.Size = new System.Drawing.Size(250, 22);
            this.txtKyThi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên kỳ thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chương trình học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Môn học";
            // 
            // cboCT
            // 
            this.cboCT.Location = new System.Drawing.Point(20, 165);
            this.cboCT.Name = "cboCT";
            this.cboCT.Size = new System.Drawing.Size(250, 24);
            this.cboCT.TabIndex = 4;
            // 
            // cboLH
            // 
            this.cboLH.Location = new System.Drawing.Point(320, 165);
            this.cboLH.Name = "cboLH";
            this.cboLH.Size = new System.Drawing.Size(250, 24);
            this.cboLH.TabIndex = 6;
            // 
            // cboMH
            // 
            this.cboMH.Location = new System.Drawing.Point(20, 235);
            this.cboMH.Name = "cboMH";
            this.cboMH.Size = new System.Drawing.Size(250, 24);
            this.cboMH.TabIndex = 8;
            // 
            // cboTime
            // 
            this.cboTime.Location = new System.Drawing.Point(320, 235);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(250, 24);
            this.cboTime.TabIndex = 10;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ca thi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày thi";
            // 
            // dtpkNgayThi
            // 
            this.dtpkNgayThi.Location = new System.Drawing.Point(20, 305);
            this.dtpkNgayThi.Name = "dtpkNgayThi";
            this.dtpkNgayThi.Size = new System.Drawing.Size(250, 22);
            this.dtpkNgayThi.TabIndex = 12;
            this.dtpkNgayThi.ValueChanged += new System.EventHandler(this.dtpkNgayThi_ValueChanged);
            // 
            // cboRoom
            // 
            this.cboRoom.Location = new System.Drawing.Point(320, 305);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(250, 24);
            this.cboRoom.TabIndex = 13;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 14;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Red;
            this.lblNote.Location = new System.Drawing.Point(20, 340);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(0, 16);
            this.lblNote.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phòng thi";
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTB.Location = new System.Drawing.Point(24, 349);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(46, 16);
            this.lblTB.TabIndex = 17;
            this.lblTB.Text = "*Lưu ý:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(476, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 37);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmTaoLichThi
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKyThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboLH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpkNgayThi);
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblNote);
            this.Name = "frmTaoLichThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo lịch thi";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKyThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpkNgayThi;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Button btnSave;
    }
}
