using Entity.Modals;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ScheduleWeekView
{
    public partial class ScheduleUctrl : UserControl
    {
        #region "Define"

        #region Colors
        private Color itemTextColor = Color.FromName("ControlDark");
        [DefaultValue("ControlDark")]
        public Color ItemTextColor
        {
            get => itemTextColor;
            set
            {
                itemTextColor = value;
                renderer.ForeColorItems = itemTextColor;
                Invalidate();
            }
        }

        private Color gridLineColor = Color.FromName("ControlDark");
        [DefaultValue("ControlDark")]
        public Color GridLineColor
        {
            get => gridLineColor;
            set
            {
                gridLineColor = value;
                Invalidate();
            }
        }

        private Color gridBackColor = Color.FromName("Control");
        [DefaultValue("Control")]
        public Color GridBackColor
        {
            get => gridBackColor;
            set
            {
                gridBackColor = value;
                Invalidate();
            }
        }

        private Color columnHeadersBackColor = Color.FromArgb(211, 211, 211);
        [DefaultValue("211, 211, 211")]
        public Color ColumnHeadersBackColor
        {
            get => columnHeadersBackColor;
            set
            {
                columnHeadersBackColor = value;
                Invalidate();
            }
        }
        #endregion

        #region Datetime and Display
        private DateTime startDate = DateTime.Now;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                startDate = value;
                OnStartDateChanged();
            }
        }

        private DateTime endDate = DateTime.Now.AddDays(7);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DateTime EndDate
        {
            get => endDate;
            set
            {
                endDate = value < startDate ? startDate : (startDate.Date.AddDays(30) <= value ? startDate.AddDays(30) : value);
                OnStartDateChanged();
            }
        }

        private int daysToShow = 0;
        private bool isScheduleMonth = false;
        [DefaultValue(false)]
        public bool IsMonth
        {
            get => isScheduleMonth;
            set
            {
                isScheduleMonth = value;
                OnStartDateChanged();
            }
        }
        #endregion

        #region Height and Width
        private int halfHourHeight = 30;
        [DefaultValue(30)]
        public int HalfHourHeight
        {
            get => halfHourHeight;
            set
            {
                halfHourHeight = value;
                OnHalfHourHeightChanged();
            }
        }

        private int rowHeaderWidth = 100;
        [DefaultValue(100)]
        public int RowHeadersWidth
        {
            get => rowHeaderWidth;
            set
            {
                rowHeaderWidth = value;
                AdjustHScrollbar();
                Invalidate();
            }
        }

        private int columnHeadersHeight = 30;
        [DefaultValue(30)]
        public int ColumnDateHeadersHeight
        {
            get => columnHeadersHeight;
            set
            {
                columnHeadersHeight = value;
                OnHalfHourHeightChanged();
            }
        }

        private int headerDayNamesHeight = 25;
        [DefaultValue(25)]
        public int ColumnDayNameHeadersHeight
        {
            get => headerDayNamesHeight;
            set
            {
                headerDayNamesHeight = value;
                OnHalfHourHeightChanged();
            }
        }

        private int HeaderHeight => isScheduleMonth ? columnHeadersHeight + headerDayNamesHeight : columnHeadersHeight;

        private bool showallColumns = true;
        private int defaultWidthColumn = 100;
        [DefaultValue(100)]
        public int DefaultWidthColumns
        {
            get => defaultWidthColumn;
            set
            {
                defaultWidthColumn = value;
                Invalidate();
            }
        }

        private string rowColumnHeaderText = "時間";
        [DefaultValue("時間")]
        public string RowColumnHeaderText
        {
            get => rowColumnHeaderText;
            set
            {
                rowColumnHeaderText = value;
                Invalidate();
            }
        }
        #endregion

        #region Scrollbar
        private bool allowScroll = true;
        [DefaultValue(true)]
        public bool AllowScroll
        {
            get => allowScroll;
            set => allowScroll = value;
        }

        public VScrollBar scrollbar;
        private HScrollBar hscrollbar;

        private void AdjustScrollbar()
        {
            int maxScroll = (2 * halfHourHeight * 24) - this.Height + this.HeaderHeight + scrollbar.LargeChange;
            scrollbar.Maximum = Math.Max(0, maxScroll);
            scrollbar.Minimum = 0;
        }

        private void AdjustHScrollbar()
        {
            int maxHScroll = (daysToShow * defaultWidthColumn) - this.Width + this.rowHeaderWidth + scrollbar.Width + hscrollbar.LargeChange;
            hscrollbar.Maximum = Math.Max(0, maxHScroll);
            hscrollbar.Minimum = 0;
        }
        #endregion

        #region Other
        private DrawOD_USER_ORDER renderer;
        #endregion

        #region "Handle"
        public ScheduleUctrl()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // Tối ưu vẽ trong WM_PAINT
            SetStyle(ControlStyles.UserPaint, true); // Điều khiển tự vẽ
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Selectable, true);

            if (daysToShow == 0) daysToShow = 1;

            scrollbar = new VScrollBar
            {
                SmallChange = halfHourHeight,
                LargeChange = halfHourHeight * 2,
                Dock = DockStyle.Right,
                Visible = allowScroll
            };

            hscrollbar = new HScrollBar
            {
                SmallChange = this.Width / daysToShow / 2,
                LargeChange = this.Width / daysToShow,
                Dock = DockStyle.Bottom,
                Visible = false
            };

            scrollbar.Scroll += scrollbar_Scroll;
            AdjustScrollbar();
            scrollbar.Value = 0;
            this.Controls.Add(scrollbar);

            hscrollbar.Scroll += scrollbar_Scroll;
            AdjustHScrollbar();
            hscrollbar.Value = 0;
            this.Controls.Add(hscrollbar);

            this.Size = new Size(300, 300);
            AdjustScrollbar();
            AdjustHScrollbar();

            renderer = new DrawOD_USER_ORDER(this.Font, this.ItemTextColor, this.ForeColor)
            {
                ForeColorItems = this.ItemTextColor,
                ForeColorItemsHeader = this.ForeColor
            };
        }
        #endregion

        #region "Methods"

        #region Headers
        private int BorderSizeHeaderColumns = 1;

        private void DrawDayHeaders(PaintEventArgs e, Rectangle rect)
        {
            DateTime headerDate = startDate;
            Rectangle dayHeaderRectangle = new Rectangle(rect.Left, rect.Top, rowHeaderWidth, rect.Height);

            e.Graphics.SetClip(dayHeaderRectangle);
            renderer.DrawDayHeader(e.Graphics, dayHeaderRectangle, rowColumnHeaderText, columnHeadersBackColor, GridLineColor, BorderSizeHeaderColumns, null, true);
            e.Graphics.ResetClip();

            rect.X += rowHeaderWidth;
            rect.Width -= rowHeaderWidth;
            rect.Height = HeaderHeight;
            int dayWidth = isScheduleMonth ? rect.Width / 31 : (showallColumns ? rect.Width / daysToShow : defaultWidthColumn);

            dayHeaderRectangle = rect;
            e.Graphics.SetClip(dayHeaderRectangle);
            Color textColor = this.ForeColor;
            for (int day = 0; day < daysToShow; day++)
            {
                dayHeaderRectangle.X = rect.X + (day * dayWidth) - hscrollbar.Value;
                dayHeaderRectangle.Width = dayWidth;
                dayHeaderRectangle.Y = rect.Y;
                if (!isScheduleMonth)
                {
                    dayHeaderRectangle.Height = HeaderHeight;
                    renderer.DrawDayHeader(e.Graphics, dayHeaderRectangle, headerDate, columnHeadersBackColor, GridLineColor, BorderSizeHeaderColumns, null, true);
                }
                else
                {
                    bool isShowText = true;
                    dayHeaderRectangle.Height = headerDayNamesHeight + 3;
                    renderer.DrawDayHeader(e.Graphics, dayHeaderRectangle, headerDate.ToString("dd"), columnHeadersBackColor, GridLineColor, BorderSizeHeaderColumns, textColor, isShowText);

                    dayHeaderRectangle.Height = columnHeadersHeight;
                    dayHeaderRectangle.Y += headerDayNamesHeight + 3;
                    renderer.DrawDayHeader(e.Graphics, dayHeaderRectangle, headerDate, columnHeadersBackColor, GridLineColor, BorderSizeHeaderColumns, textColor, isShowText);
                }
                headerDate = headerDate.AddDays(1);
            }
            e.Graphics.ResetClip();
        }
        #endregion

        #region Body
        private void DrawBackgroundDay(PaintEventArgs e, Rectangle rect, DateTime time)
        {
            // Cache chiều rộng cột để tránh tính toán lặp lại
            int columnWidth = rect.Width / daysToShow;
            int maxBottom = rect.Top + (24 * 2 * halfHourHeight) - scrollbar.Value;

            // Vẽ đường ngang
            using (Pen pen = new Pen(gridLineColor))
            {
                for (int hour = 0; hour <= 24 * 4; hour++)
                {
                    int y = rect.Top + (hour * halfHourHeight / 2) - scrollbar.Value;
                    if (y < rect.Top || y > rect.Bottom) continue;

                    pen.DashStyle = hour % 2 != 0 ? System.Drawing.Drawing2D.DashStyle.Dot : System.Drawing.Drawing2D.DashStyle.Solid;
                    pen.DashPattern = hour % 2 != 0 ? new float[] { 2, 2 } : new float[] { 5, 2 };
                    e.Graphics.DrawLine(pen, rect.Left - hscrollbar.Value, y, rect.Right - hscrollbar.Value, y);
                }
            }

            // Vẽ đường dọc
            using (Pen verticalPen = new Pen(gridLineColor, 1))
            {
                if (time.Date == startDate.Date)
                    e.Graphics.DrawLine(verticalPen, rect.Left - hscrollbar.Value, rect.Top, rect.Left - hscrollbar.Value, maxBottom);

                e.Graphics.DrawLine(verticalPen, rect.Right - hscrollbar.Value, rect.Top, rect.Right - hscrollbar.Value, maxBottom);

                for (int day = 0; day <= daysToShow; day++)
                {
                    int x = rect.Left + (day * columnWidth) - hscrollbar.Value;
                    e.Graphics.DrawLine(verticalPen, x, rect.Top, x, rect.Bottom);
                }
            }
        }

        private void DrawHourLabels(PaintEventArgs e, Rectangle rect)
        {
            e.Graphics.SetClip(rect);
            for (int m_Hour = 0; m_Hour < 24; m_Hour++)
            {
                Rectangle hourRectangle = new Rectangle(rect.X + 1, 0, rowHeaderWidth, halfHourHeight);
                string strTime = m_Hour.ToString("##00") + ":00";
                hourRectangle.Y = rect.Y + (m_Hour * 2 * halfHourHeight) - scrollbar.Value;

                if (hourRectangle.Y > HeaderHeight)
                {
                    hourRectangle.Y -= halfHourHeight - (halfHourHeight / 2);
                    renderer.DrawHourLabel(e.Graphics, hourRectangle, strTime, GridLineColor);
                    hourRectangle.Y += halfHourHeight;
                    strTime = m_Hour.ToString("##00") + ":30";
                    renderer.DrawHourLabel(e.Graphics, hourRectangle, strTime, GridLineColor);
                }
                else
                {
                    if (hourRectangle.Y - halfHourHeight + (halfHourHeight / 2) >= 0)
                    {
                        hourRectangle.Y -= halfHourHeight - (halfHourHeight / 2);
                        if (strTime != "00:00") renderer.DrawHourLabel(e.Graphics, hourRectangle, strTime, GridLineColor);
                    }
                    if (hourRectangle.Y + halfHourHeight > 0)
                    {
                        hourRectangle.Y += halfHourHeight;
                        strTime = m_Hour.ToString("##00") + ":30";
                        renderer.DrawHourLabel(e.Graphics, hourRectangle, strTime, GridLineColor);
                    }
                }
            }
            e.Graphics.ResetClip();
        }
        #endregion

        #region Datetime and Display Events
        protected virtual void OnStartDateChanged()
        {
            if (!isScheduleMonth)
            {
                SetStart_EndDateWeekly();
                daysToShow = 7;
            }
            else
            {
                DateTime dtstart = new DateTime(startDate.Year, startDate.Month, startDate.Day);
                DateTime dtend = new DateTime(endDate.Year, endDate.Month, endDate.Day);
                daysToShow = (int)(dtend - dtstart).TotalDays + 1;
                if (daysToShow == 0) daysToShow = 1;
            }
            AdjustHScrollbar(); // Chỉnh scroll ngang khi ngày thay đổi
            Invalidate();
        }

        private void SetStart_EndDateWeekly()
        {
            DateTime dtime = DateTime.Now;
            switch (dtime.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    startDate = dtime.AddDays(-4);
                    break;
                case DayOfWeek.Saturday:
                    startDate = dtime.AddDays(-5);
                    break;
                case DayOfWeek.Sunday:
                    startDate = dtime.AddDays(-6);
                    break;
                case DayOfWeek.Thursday:
                    startDate = dtime.AddDays(-3);
                    break;
                case DayOfWeek.Tuesday:
                    startDate = dtime.AddDays(-1);
                    break;
                case DayOfWeek.Wednesday:
                    startDate = dtime.AddDays(-2);
                    break;
                default:
                    startDate = dtime;
                    break;
            }
            endDate = startDate.AddDays(6);
        }
        #endregion

        #region Height and Width Events
        private void OnHalfHourHeightChanged()
        {
            AdjustScrollbar();
            AdjustHScrollbar();
            Invalidate();
        }
        #endregion

        #region Scrollbar Events
        private void scrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            // Giới hạn vùng vẽ lại chỉ ở khu vực nội dung
            Rectangle scrollRegion = new Rectangle(rowHeaderWidth, HeaderHeight, Width - rowHeaderWidth - scrollbar.Width, Height - HeaderHeight);
            Invalidate(scrollRegion);
        }
        #endregion

        #region Paint
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Parent != null) this.Font = Parent.Font;
            renderer.FontItems = this.Font;
            renderer.ForeColorItems = this.ForeColor;

            using (SolidBrush backBrush = new SolidBrush(this.BackColor))
                e.Graphics.FillRectangle(backBrush, ClientRectangle);

            if (startDate > endDate) endDate = startDate;
            if (daysToShow <= 0) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle visibleRect = new Rectangle(0, 0, Width - scrollbar.Width, Height);

            // Vẽ header
            Rectangle headerRect = new Rectangle(visibleRect.X, visibleRect.Y, visibleRect.Width, HeaderHeight);
            if (e.ClipRectangle.IntersectsWith(headerRect))
                DrawDayHeaders(e, headerRect);

            // Vẽ hour labels
            Rectangle hourLabelRect = new Rectangle(visibleRect.X, headerRect.Bottom, rowHeaderWidth, Height - HeaderHeight);
            if (e.ClipRectangle.IntersectsWith(hourLabelRect))
                DrawHourLabels(e, hourLabelRect);

            // Vẽ nội dung
            Rectangle daysRect = new Rectangle(rowHeaderWidth, HeaderHeight, Width - rowHeaderWidth - scrollbar.Width, Height - HeaderHeight);
            if (e.ClipRectangle.IntersectsWith(daysRect))
                DrawBackgroundDay(e, daysRect, startDate);

            using (Pen borderPen = new Pen(gridLineColor, 2))
                e.Graphics.DrawRectangle(borderPen, visibleRect);
        }
        #endregion


        /// <summary>
        /// items show in HalfHour layout
        /// </summary>
        class HalfHourLayout
        {
            public int Count;
            public ODUserOrderItemDraw[] ODUserOrders;
            public T_Schedule_Class_Plan_Weekly_Models[] Class_Plan_Weekly;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="lstDataFCs"></param>
        /// <returns></returns>
        //private HalfHourLayout[] GetMaxParalelFcOrderWeeks(List<T_Schedule_Class_Plan_Weekly_Models> lstDataFCs)
        //{
        //    HalfHourLayout[] appLayouts = new HalfHourLayout[24 * 2];
        //    foreach (T_Schedule_Class_Plan_Weekly_Models item in lstDataFCs)
        //    {
        //        if (item.StartDateDraw != null && item.EndDateDraw != null)
        //        {
        //            int firstHalfHour = item.StartDateDraw.Hour * 2 + (item.StartDateDraw.Minute / 30);
        //            int lastHalfHour = item.EndDateDraw.Hour * 2 + (item.EndDateDraw.Minute / 30);
        //            if (firstHalfHour == lastHalfHour)
        //                lastHalfHour = firstHalfHour + 1;
        //            else if (lastHalfHour < firstHalfHour)
        //                lastHalfHour = 47;
        //            for (int halfHour = firstHalfHour; halfHour < lastHalfHour; halfHour++)
        //            {
        //                HalfHourLayout layout = appLayouts[halfHour];
        //                if (layout == null)
        //                {
        //                    layout = new HalfHourLayout();
        //                    layout.Class_Plan_Weekly = new T_Schedule_Class_Plan_Weekly_Models[lstDataFCs.Count];
        //                    appLayouts[halfHour] = layout;
        //                }
        //                layout.Class_Plan_Weekly[layout.Count] = item;
        //                layout.Count++;
        //                // update conflicts
        //                foreach (T_Schedule_Class_Plan_Weekly_Models app2 in layout.Class_Plan_Weekly)
        //                {
        //                    if (app2 != null)
        //                    {
        //                        if (app2.m_ConflictCount < layout.Count)
        //                            app2.m_ConflictCount = layout.Count;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return appLayouts;
        //}


        ///// <summary>
        ///// 
        ///// </summary>
        //void Paint_OrderFC_BackGround(Graphics g, Rectangle rectangle, DateTime time)
        //{
        //    if (lstDatas_SCHEDULE_FC != null)
        //    {
        //        if (isScheduleMonth && lstDatas_SCHEDULE_FC is List<T_SCHEDULE_MANAGEMENT_INHOUSE_MONTHLY_Model>)
        //        {
        //            List<T_SCHEDULE_MANAGEMENT_INHOUSE_MONTHLY_Model> lstDataFCs = (List<T_SCHEDULE_MANAGEMENT_INHOUSE_MONTHLY_Model>)lstDatas_SCHEDULE_FC;
        //            if (lstDataFCs.Count == 0)
        //                return;
        //            //2021.12.30 Edit Viet S
        //            lstDataFCs = lstDataFCs.Where(p => p.StartDateDraw != null && p.EndDateDraw != null && p.StartDateDraw.Date == time.Date).ToList();
        //            //2021.12.30 Edit Viet E
        //            if (lstDataFCs == null || lstDataFCs.Count == 0)
        //                return;
        //            Paint_OrderFC_BackGround_Month(lstDataFCs, g, rectangle);
        //        }
        //        else if (!isScheduleMonth && lstDatas_SCHEDULE_FC is List<T_Schedule_Class_Plan_Weekly_Models>)
        //        {
        //            List<T_Schedule_Class_Plan_Weekly_Models> lstDataFCs = (List<T_Schedule_Class_Plan_Weekly_Models>)lstDatas_SCHEDULE_FC;
        //            if (lstDataFCs.Count == 0)
        //                return;
        //            //2021.12.30 Edit Viet S
        //            lstDataFCs = lstDataFCs.Where(p => (p.StartDateDraw != null && p.EndDateDraw != null) && (
        //            (p.TargetWeekdayDraw == null && p.StartDateDraw.Date == time.Date)
        //            ||
        //            (p.TargetWeekdayDraw != null && p.TargetWeekdayDraw.Equals(FC_DAYOFWEEK_VALUE_NAME.GetDayName(time)))
        //            )).ToList();
        //            //2021.12.30 Edit Viet E
        //            if (lstDataFCs == null || lstDataFCs.Count == 0)
        //                return;
        //            Paint_OrderFC_BackGround_Week(lstDataFCs, g, rectangle);
        //        }
        //    }
        //}

        //Color Color_OD_BackGround_FC = Color.FromArgb(255, 250, 206);



        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="lstDataFCs"></param>
        ///// <param name="g"></param>
        ///// <param name="rect"></param>
        //void Paint_OrderFC_BackGround_Week(List<T_Schedule_Class_Plan_Weekly_Models> lstDataFCs, Graphics g, Rectangle rect)
        //{
        //    HalfHourLayout[] layout = GetMaxParalelFcOrderWeeks(lstDataFCs);
        //    List<T_Schedule_Class_Plan_Weekly_Models> drawnItems = new List<T_Schedule_Class_Plan_Weekly_Models>();
        //    for (int halfHour = 0; halfHour < 24 * 2; halfHour++)
        //    {
        //        HalfHourLayout hourLayout = layout[halfHour];
        //        if ((hourLayout != null) && (hourLayout.Count > 0))
        //        {
        //            for (int appIndex = 0; appIndex < hourLayout.Count; appIndex++)
        //            {
        //                T_Schedule_Class_Plan_Weekly_Models item = hourLayout.Class_Plan_Weekly[appIndex];
        //                if (drawnItems.IndexOf(item) < 0)
        //                {
        //                    Rectangle appRect = rect;
        //                    ODUserOrderView view;
        //                    //2021.12.30 Edit Viet S
        //                    appRect = GetHourRangeRectangle(item.StartDateDraw, item.EndDateDraw, appRect);
        //                    //2021.12.30 Edit Viet E
        //                    //
        //                    int lastX = 0;
        //                    int appointmentWidth = rect.Width / item.m_ConflictCount;
        //                    foreach (T_Schedule_Class_Plan_Weekly_Models app in hourLayout.Class_Plan_Weekly)
        //                    {
        //                        if ((app != null) && (FC_ODUserOrderItemViews_WEEKLY.ContainsKey(app)))
        //                        {
        //                            view = FC_ODUserOrderItemViews_WEEKLY[app];
        //                            if (lastX < view.Rectangle[0].X)
        //                                lastX = view.Rectangle[0].X;
        //                        }
        //                    }
        //                    //
        //                    if ((lastX + (appointmentWidth * 2)) > (rect.X + rect.Width))
        //                        lastX = 0;
        //                    appRect.Width = appointmentWidth;
        //                    if (lastX > 0)
        //                        appRect.X = lastX + appointmentWidth;
        //                    view = new ODUserOrderView();
        //                    List<Rectangle> lstRecs = new List<Rectangle>();
        //                    lstRecs.Add(appRect);
        //                    view.Rectangle = lstRecs;
        //                    view.FC_ODUserOrderItemDraw_WEEKLY = item;
        //                    FC_ODUserOrderItemViews_WEEKLY[item] = view;
        //                    //
        //                    Color colbase = Color.LightGreen;
        //                    Color colOrder = Color.Empty;
        //                    Color colOrder_Border = Color.Empty;
        //                    if (item.TARGET_SERVICE_TYPE != null && item.TARGET_SERVICE_TYPE.Length >= 2)
        //                    {
        //                        string ser_code = item.TARGET_SERVICE_TYPE.Substring(0, 2);
        //                        if (StrSV11.IndexOf(ser_code) != -1)
        //                        {
        //                            // colbase = ColorService11;
        //                            colOrder = ModelsConst.COLOR_ORDER_SERVICE.GetColorService(ModelsConst.COLOR_ORDER_SERVICE.Service_11_Value, ModelsConst.COLOR_ORDER_SERVICE.FC);
        //                            colOrder_Border = ModelsConst.COLOR_ORDER_SERVICE.GetColorService(ModelsConst.COLOR_ORDER_SERVICE.Service_11_Value, ModelsConst.COLOR_ORDER_SERVICE.FC, true);
        //                        }

        //                    }
        //                    using (SolidBrush brush = new SolidBrush(colOrder))
        //                        g.FillRectangle(brush, new Rectangle(appRect.X + 2, appRect.Y + 2, appRect.Width - 4, appRect.Height - 4));
        //                    using (Pen m_pen = new Pen(colOrder_Border))
        //                        g.DrawRectangle(m_pen, new Rectangle(appRect.X + 2, appRect.Y + 2, appRect.Width - 4, appRect.Height - 4));
        //                    //2024.03.27 TARGET_SERVICE_TYPE == 99 then Show only TARGET_SERVICE_CODE
        //                    string strValue2 = ((item.TARGET_SERVICE_TYPE != null && item.TARGET_SERVICE_TYPE.Length >= 2 && item.TARGET_SERVICE_TYPE != "99") ? item.TARGET_SERVICE_TYPE.Substring(0, 2) : "") + item.TARGET_SERVICE_CODE;
        //                    string strValue = (
        //                      (item.SERVICE_BEGIN_DATE == item.SERVICE_END_DATE ? (item.SERVICE_BEGIN_DATE.Value.ToStringHoursWithDefaultFormat()) : (item.SERVICE_BEGIN_DATE.Value.ToStringHoursWithDefaultFormat() + "ー" + item.SERVICE_END_DATE.Value.ToStringHoursWithDefaultFormat()))
        //                      + " "
        //                      + item.TARGET_SERVICE_CODE_NAME
        //                      );

        //                    //
        //                    //2021.12.30 Edit Viet S
        //                    FC_TOOLTIP_ODUserOrderView objTooltip;
        //                    if (cachedToolTipText.TryGetValue(item.UNIQ_KEY, out objTooltip))
        //                    {
        //                        objTooltip.Rectangle2 = new Rectangle(appRect.X + 2, appRect.Y + 2, appRect.Width - 4, appRect.Height - 4);
        //                    }
        //                    else
        //                    {
        //                        //New TooltTip
        //                        objTooltip = new FC_TOOLTIP_ODUserOrderView();
        //                        objTooltip.Rectangle = new Rectangle(appRect.X + 2, appRect.Y + 2, appRect.Width - 4, appRect.Height - 4);
        //                        objTooltip.TexTooltip = strValue;
        //                        objTooltip.TexTooltip2 = strValue2;
        //                        objTooltip.ID_Order = item.UNIQ_KEY;
        //                        objTooltip.ServiceCode = item.SERVICE_CODE;
        //                        objTooltip.ServiceCodeLogin = item.LOGIN_SERVICE_CODE;
        //                        objTooltip.Tag = item;
        //                        cachedToolTipText[item.UNIQ_KEY] = objTooltip;
        //                    }
        //                    //
        //                    //StaticData_ODUserOrder.FC_TOOLTIP_ODUserOrderView.Add(objTooltip);
        //                    //
        //                    //2021.12.30 Edit Viet E
        //                    drawnItems.Add(item);
        //                }
        //            }
        //        }
        //    }
        //    drawnItems = null;
        //}



        ///// <summary>
        ///// draw ODUserOrderItemDraw list follow about select times
        ///// </summary>
        ///// <param name="e"> </param>
        ///// <param name="rect">Rectangle contain</param>
        ///// <param name="time">get ODUserOrderItemDraw list in the hour </param>
        //private void DrawODUserOrders(PaintEventArgs e, Rectangle rect, DateTime time)
        //{
        //    DateTime dtStartDay = new DateTime(startDate.Year, startDate.Month, startDate.Day, time.Hour, time.Minute, time.Second, time.Millisecond);
        //    int Day = (int)time.Subtract(startDate).TotalDays + 1;
        //    ODUserOrderList lstODUserOrders = (ODUserOrderList)cachedODUserOrders[Day];
        //    if (lstODUserOrders != null && lstODUserOrders.Count > 0)
        //    {
        //        HalfHourLayout[] layout = GetMaxParalelODUserOrders(lstODUserOrders);
        //        List<ODUserOrderItemDraw> drawnItems = new List<ODUserOrderItemDraw>();
        //        //2022.09.21 ChinhTN - S
        //        for (int halfHour = 0; halfHour < 24 * 60; halfHour++)
        //        //2022.09.21 ChinhTN - E
        //        {
        //            HalfHourLayout hourLayout = layout[halfHour];
        //            if ((hourLayout != null) && (hourLayout.Count > 0))
        //            {
        //                for (int appIndex = 0; appIndex < hourLayout.Count; appIndex++)
        //                {
        //                    ODUserOrderItemDraw item = hourLayout.ODUserOrders[appIndex];
        //                    if (drawnItems.IndexOf(item) < 0)
        //                    {
        //                        Rectangle appRect = rect;
        //                        ODUserOrderView view;
        //                        appRect = GetHourRangeRectangle(item.StartDate_Draw, item.EndDate_Draw, appRect);
        //                        int lastX = 0;
        //                        int appointmentWidth = rect.Width / item.m_ConflictCount;
        //                        foreach (ODUserOrderItemDraw app in hourLayout.ODUserOrders)
        //                        {
        //                            if ((app != null) && (ODUserOrderItemViews.ContainsKey(app)))
        //                            {
        //                                view = ODUserOrderItemViews[app];
        //                                if (lastX < view.Rectangle[0].X)
        //                                    lastX = view.Rectangle[0].X;
        //                            }
        //                        }
        //                        if ((lastX + (appointmentWidth * 2)) > (rect.X + rect.Width))
        //                            lastX = 0;
        //                        appRect.Width = appointmentWidth;
        //                        if (lastX > 0)
        //                            appRect.X = lastX + appointmentWidth;
        //                        //  e.Graphics.DrawRectangle(new Pen(Color.Black,2), appRect);
        //                        view = new ODUserOrderView();
        //                        List<Rectangle> lstRecs = new List<Rectangle>();
        //                        lstRecs.Add(appRect);
        //                        view.Rectangle = lstRecs;
        //                        view.ODUserOrderItemDraw = item;
        //                        ODUserOrderItemViews[item] = view;
        //                        //
        //                        var size = TextRenderer.MeasureText(item.WorkContent, renderer.FontItems, new Size(appRect.Width, appRect.Height), TextFormatFlags.WordBreak);
        //                        if (size.Width >= appRect.Width || size.Height >= appRect.Height)
        //                        {
        //                            ODUserOrderItemViews_Tooltips[item] = view;
        //                        }
        //                        //
        //                        renderer.DrawODUserOrderItem(e.Graphics, appRect, item);
        //                        //, selectedODUserOrder != null ? item.ID == selectedODUserOrder.ID : false
        //                        drawnItems.Add(item);
        //                    }
        //                }
        //            }
        //        }
        //        drawnItems = null;
        //    }
        //}



        /// <summary>
        /// setup location for ODUserOrderItemDraw list
        /// </summary>
        /// <param name="lstODUserOrders"></param>
        /// <returns></returns>
        private HalfHourLayout[] GetMaxParalelODUserOrders(List<ODUserOrderItemDraw> lstODUserOrders)
        {
            HalfHourLayout[] appLayouts = new HalfHourLayout[24 * 60];
            foreach (ODUserOrderItemDraw item in lstODUserOrders)
            {
                item.m_ConflictCount = 1;
                //2022.09.21 ChinhTN - S
                int firstHalfHour = item.StartDate_Draw.Hour * 60 + item.StartDate_Draw.Minute;
                int lastHalfHour = item.EndDate_Draw.Hour * 60 + item.EndDate_Draw.Minute;
                if (firstHalfHour == lastHalfHour)
                    lastHalfHour = firstHalfHour + 1;
                else if (lastHalfHour < firstHalfHour)
                    lastHalfHour = 24 * 60 - 1;
                //2022.09.21 ChinhTN - E
                for (int halfHour = firstHalfHour; halfHour < lastHalfHour; halfHour++)
                {
                    HalfHourLayout layout = appLayouts[halfHour];
                    if (layout == null)
                    {
                        layout = new HalfHourLayout();
                        layout.ODUserOrders = new ODUserOrderItemDraw[lstODUserOrders.Count];
                        appLayouts[halfHour] = layout;
                    }
                    layout.ODUserOrders[layout.Count] = item;
                    layout.Count++;
                    // update conflicts
                    foreach (ODUserOrderItemDraw app2 in layout.ODUserOrders)
                    {
                        if (app2 != null)
                        {
                            if (app2.m_ConflictCount < layout.Count)
                                app2.m_ConflictCount = layout.Count;
                        }
                    }
                }
            }
            return appLayouts;
        }




        #region Resize
        protected override void OnResize(EventArgs e)
        {
            AdjustScrollbar();
            AdjustHScrollbar();
            if (!showallColumns && daysToShow * defaultWidthColumn + rowHeaderWidth > Width - scrollbar.Width)
                hscrollbar.Visible = true;
            else
                hscrollbar.Visible = false;
            hscrollbar.Value = 0;
            base.OnResize(e);
            Invalidate();
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            AdjustScrollbar();
            AdjustHScrollbar();
            base.SetBoundsCore(x, y, width, height, specified);
        }
        #endregion

        #region Font and Size
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            ResizeHeaderHeight();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ResizeHeaderHeight();
        }

        private void ResizeHeaderHeight()
        {
            if (isScheduleMonth)
            {
                int dayWidth = (Width - (scrollbar.Width + rowHeaderWidth)) / 31;
                var size = TextRenderer.MeasureText("00", renderer.FontItems);
                headerDayNamesHeight = size.Width <= dayWidth ? size.Height : size.Height * 2;
            }
            Invalidate();
        }
        #endregion

        #region Mouse
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            int delta = -e.Delta * SystemInformation.MouseWheelScrollLines / 12;
            int newValue = scrollbar.Value + delta;
            scrollbar.Value = Math.Max(0, Math.Min(scrollbar.Maximum - scrollbar.LargeChange, newValue));
            Invalidate();
        }
        #endregion
        #endregion
        #endregion
    }
}