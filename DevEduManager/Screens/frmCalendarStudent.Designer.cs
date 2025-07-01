namespace DevEduManager.Screens
{
    partial class frmCalendarStudent
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.tlpConditionSearch = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tlpListService = new System.Windows.Forms.TableLayoutPanel();
            this.tblFilterName = new System.Windows.Forms.TableLayoutPanel();
            //this.ScheduleWeekView = new ScheduleWeekView.ScheduleUctrl();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpButtonMenu = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tlpConditionSearch.SuspendLayout();
            this.tblFilterName.SuspendLayout();
            this.tlpButtonMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 7;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.Controls.Add(this.lbltitle, 1, 1);
            this.tlpMain.Controls.Add(this.tlpConditionSearch, 1, 5);
            this.tlpMain.Controls.Add(this.tlpListService, 1, 7);
            this.tlpMain.Controls.Add(this.tblFilterName, 1, 3);
            this.tlpMain.Controls.Add(this.ScheduleWeekly, 1, 9);
            this.tlpMain.Controls.Add(this.tlpButtonMenu, 1, 11);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 13;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMain.Size = new System.Drawing.Size(1282, 753);
            this.tlpMain.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lbltitle, 5);
            this.lbltitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.lbltitle.Location = new System.Drawing.Point(30, 15);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(1222, 35);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "基本オーダー設定（週間計画）　編集（更新）";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpConditionSearch
            // 
            this.tlpConditionSearch.AutoScroll = true;
            this.tlpConditionSearch.AutoScrollMinSize = new System.Drawing.Size(950, 0);
            this.tlpConditionSearch.ColumnCount = 10;
            this.tlpMain.SetColumnSpan(this.tlpConditionSearch, 5);
            this.tlpConditionSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpConditionSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpConditionSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpConditionSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpConditionSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpConditionSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpConditionSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConditionSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpConditionSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpConditionSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConditionSearch.Controls.Add(this.label2, 0, 0);
            this.tlpConditionSearch.Controls.Add(this.label3, 3, 0);
            this.tlpConditionSearch.Controls.Add(this.label4, 4, 0);
            this.tlpConditionSearch.Controls.Add(this.label6, 7, 0);
            this.tlpConditionSearch.Controls.Add(this.lblNotification, 8, 0);
            this.tlpConditionSearch.Controls.Add(this.lblNote, 0, 1);
            this.tlpConditionSearch.Controls.Add(this.label8, 1, 0);
            this.tlpConditionSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConditionSearch.Location = new System.Drawing.Point(30, 105);
            this.tlpConditionSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpConditionSearch.Name = "tlpConditionSearch";
            this.tlpConditionSearch.RowCount = 3;
            this.tlpConditionSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpConditionSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpConditionSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpConditionSearch.Size = new System.Drawing.Size(1222, 90);
            this.tlpConditionSearch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "適用開始日";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(340, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "～";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(370, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "適用終了日";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(750, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "月間への展開：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(950, 0);
            this.lblNotification.Margin = new System.Windows.Forms.Padding(0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(120, 40);
            this.lblNotification.TabIndex = 6;
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNote
            // 
            this.lblNote.AutoEllipsis = true;
            this.lblNote.AutoSize = true;
            this.tlpConditionSearch.SetColumnSpan(this.lblNote, 10);
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNote.Location = new System.Drawing.Point(0, 40);
            this.lblNote.Margin = new System.Windows.Forms.Padding(0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(1222, 45);
            this.lblNote.TabIndex = 7;
            this.lblNote.Text = "ファーストケアの週間予定と著しく時間が異なる場合は、週間予定を見直し再アップロードしてください。\r\n";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(110, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 40);
            this.label8.TabIndex = 9;
            this.label8.Text = "※";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpListService
            // 
            this.tlpListService.ColumnCount = 6;
            this.tlpMain.SetColumnSpan(this.tlpListService, 5);
            this.tlpListService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpListService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpListService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpListService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpListService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpListService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpListService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListService.Location = new System.Drawing.Point(30, 205);
            this.tlpListService.Margin = new System.Windows.Forms.Padding(0);
            this.tlpListService.Name = "tlpListService";
            this.tlpListService.RowCount = 1;
            this.tlpListService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListService.Size = new System.Drawing.Size(1222, 30);
            this.tlpListService.TabIndex = 7;
            // 
            // tblFilterName
            // 
            this.tblFilterName.ColumnCount = 3;
            this.tblFilterName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblFilterName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblFilterName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFilterName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblFilterName.Controls.Add(this.label1, 1, 0);
            this.tblFilterName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilterName.Location = new System.Drawing.Point(30, 60);
            this.tblFilterName.Margin = new System.Windows.Forms.Padding(0);
            this.tblFilterName.Name = "tblFilterName";
            this.tblFilterName.RowCount = 1;
            this.tblFilterName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFilterName.Size = new System.Drawing.Size(882, 35);
            this.tblFilterName.TabIndex = 1;
            this.tblFilterName.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(110, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "※";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScheduleWeekly
            // 
            this.ScheduleWeekly.AllowDrop = true;
            this.ScheduleWeekly.ColumnDateHeadersHeight = 40;
            this.ScheduleWeekly.ColumnHeadersBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tlpMain.SetColumnSpan(this.ScheduleWeekly, 5);
            //this.ScheduleWeekly.DataSource = null;
            this.ScheduleWeekly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleWeekly.EndDate = new System.DateTime(2025, 6, 22, 22, 9, 7, 962);
            this.ScheduleWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleWeekly.GridBackColor = System.Drawing.SystemColors.Control;
            this.ScheduleWeekly.GridLineColor = System.Drawing.SystemColors.ControlDark;
            this.ScheduleWeekly.HalfHourHeight = 40;
            //this.ScheduleWeekly.Holidays = null;
            //this.ScheduleWeekly.IsShowTooltipFC_Order = true;
            this.ScheduleWeekly.ItemTextColor = System.Drawing.SystemColors.ControlDark;
            this.ScheduleWeekly.Location = new System.Drawing.Point(31, 246);
            this.ScheduleWeekly.Margin = new System.Windows.Forms.Padding(1);
            this.ScheduleWeekly.Name = "ScheduleWeekly";
            this.ScheduleWeekly.RowColumnHeaderText = "";
            //this.ScheduleWeekly.ScreenID = "CalendarStu";
            this.ScheduleWeekly.Size = new System.Drawing.Size(1220, 446);
            this.ScheduleWeekly.StartDate = new System.DateTime(2025, 6, 16, 22, 9, 7, 962);
            //this.ScheduleWeekly.StartHour = 6;
            //this.ScheduleWeekly.StartMinute = 30;
            //this.ScheduleWeekly.T_SCHEDULE_MANAGEMENT_INHOUSE_FC = null;
            this.ScheduleWeekly.TabIndex = 8;
            this.ScheduleWeekly.TabStop = false;
            this.ScheduleWeekly.Text = "scheduleAS_D_OD_071";
            // 
            // tlpButtonMenu
            // 
            this.tlpButtonMenu.ColumnCount = 8;
            this.tlpMain.SetColumnSpan(this.tlpButtonMenu, 5);
            this.tlpButtonMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tlpButtonMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpButtonMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tlpButtonMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpButtonMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tlpButtonMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpButtonMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpButtonMenu.Controls.Add(this.label7, 0, 0);
            this.tlpButtonMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonMenu.Location = new System.Drawing.Point(30, 703);
            this.tlpButtonMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtonMenu.Name = "tlpButtonMenu";
            this.tlpButtonMenu.RowCount = 1;
            this.tlpButtonMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonMenu.Size = new System.Drawing.Size(1222, 35);
            this.tlpButtonMenu.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(597, 35);
            this.label7.TabIndex = 5;
            this.label7.Text = "※必須項目";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCalendarStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.tlpMain);
            this.Name = "frmCalendarStudent";
            this.Text = "frmCalendarStudent";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpConditionSearch.ResumeLayout(false);
            this.tlpConditionSearch.PerformLayout();
            this.tblFilterName.ResumeLayout(false);
            this.tblFilterName.PerformLayout();
            this.tlpButtonMenu.ResumeLayout(false);
            this.tlpButtonMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TableLayoutPanel tlpConditionSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tlpListService;
        private System.Windows.Forms.TableLayoutPanel tblFilterName;
        public ScheduleWeekView.ScheduleUctrl ScheduleWeekly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpButtonMenu;
        private System.Windows.Forms.Label label7;
    }
}