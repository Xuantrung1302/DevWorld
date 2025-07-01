using System.Drawing.Text;
using System.Drawing;
using System.Threading;
using System;

namespace ScheduleWeekView
{
    /**
     * Edit History
     * 2023.07.03 Dat     [1726]【アサインPro】週間オーダーで職員割り当て月間展開後月間オーダー内で割り当て職員を新規割り当て・変更できるよう改善する
     * 2024.03.29 Dat     [1869] 訪問予定に対してキャンセル処理を行う
     **/
    public class DrawOD_USER_ORDER
    {
        /// <summary>
        /// font
        /// </summary>
        public Font FontItems;

        /// <summary>
        /// color text
        /// </summary>
        public Color ForeColorItems;

        /// <summary>
        /// color text of header
        /// </summary>
        public Color ForeColorItemsHeader;

        /// <summary>
        /// 
        /// </summary>
        Guid idServiceLogin = Guid.Empty;
        string ServiceCodeLogin = "";
        /// <summary>
        /// Initialize Component
        /// </summary>
        public DrawOD_USER_ORDER()
        {
            FontItems = SystemFonts.DefaultFont;
            ForeColorItems = SystemColors.ControlText;
            ForeColorItemsHeader = SystemColors.ControlText;
            //if (AppInfo.ServiceLogin != null)
            //{
            //    idServiceLogin = AppInfo.ServiceLogin.UNIQ_KEY;
            //    ServiceCodeLogin = AppInfo.ServiceLogin.SERVICE_CODE;
            //}
        }

        /// <summary>
        ///  Initialize Component
        /// </summary>
        /// <param name="font"> font draw</param>
        /// <param name="forecolor"> color text draw</param>
        public DrawOD_USER_ORDER(Font font, Color forecolor, Color forecolorHeader)
        {
            FontItems = font;
            ForeColorItems = forecolor;
            ForeColorItemsHeader = forecolorHeader;
            //if (AppInfo.ServiceLogin != null)
            //{
            //    idServiceLogin = AppInfo.ServiceLogin.UNIQ_KEY;
            //    ServiceCodeLogin = AppInfo.ServiceLogin.SERVICE_CODE;
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g">Graphics</param>
        /// <param name="rect">Rectangle to draw </param>
        /// <param name="hour">draw hour </param>
        /// <param name="gridLineColor"> color gridLine </param>
        public void DrawHourLabel(Graphics g, Rectangle rect, string hour, Color gridLineColor)
        {
            using (SolidBrush brush = new SolidBrush(ForeColorItemsHeader))
            {
                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(hour, FontItems, brush, rect, sf);

                g.TextRenderingHint = TextRenderingHint.SystemDefault;
            }
        }

        /// <summary>
        /// Draw Day Header of schedule
        /// </summary>
        /// <param name="g">Graphics </param>
        /// <param name="rect">Rectangle to draw </param>
        /// <param name="text">text draw</param>
        /// <param name="columnHeadersBackColor">backcolor</param>
        /// <param name="gridLineColor">border color</param>
        /// <param name="borderSize">border Size </param>
        public void DrawDayHeader(Graphics g, Rectangle rect, string text, Color columnHeadersBackColor, Color gridLineColor, int borderSize, Color? textcolor, bool IsDrawText)
        {
            using (Pen aPen = new Pen(gridLineColor, borderSize))
            {
                g.DrawLine(aPen, rect.Right, rect.Top, rect.Right, rect.Bottom);
            }
            rect.X += borderSize;
            rect.Width -= borderSize * 2;
            rect.Height += borderSize * 2;
            using (SolidBrush brush = new SolidBrush(columnHeadersBackColor))
                g.FillRectangle(brush, rect);
            if (IsDrawText)
            {
                StringFormat m_Format = new StringFormat();
                m_Format.Alignment = StringAlignment.Center;
                // m_Format.FormatFlags = StringFormatFlags.NoWrap;
                m_Format.LineAlignment = StringAlignment.Center;
                //
                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                g.DrawString(text, FontItems, new SolidBrush(textcolor != null ? textcolor.Value : ForeColorItemsHeader), rect, m_Format);
                g.TextRenderingHint = TextRenderingHint.SystemDefault;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="rect"></param>
        /// <param name="date"></param>
        /// <param name="columnHeadersBackColor"></param>
        /// <param name="gridLineColor"></param>
        /// <param name="borderSize"></param>
        public void DrawDayHeader(Graphics g, Rectangle rect, DateTime date, Color columnHeadersBackColor, Color gridLineColor, int borderSize, Color? textcolor, bool IsDrawText)
        {
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            StringFormat m_Format = new StringFormat();
            m_Format.Alignment = StringAlignment.Center;
            m_Format.LineAlignment = StringAlignment.Center;

            // Vẽ đường viền cột
            using (Pen aPen = new Pen(gridLineColor, borderSize))
            {
                g.DrawLine(aPen, rect.Right, rect.Top, rect.Right, rect.Bottom);
            }

            rect.X += borderSize;
            rect.Width -= borderSize * 2;
            using (SolidBrush brush = new SolidBrush(columnHeadersBackColor))
                g.FillRectangle(brush, rect);

            if (IsDrawText)
            {
                string vietnameseDayName = GetVietnameseDayName(date.DayOfWeek);
                Color drawColor = textcolor ?? (date.DayOfWeek == DayOfWeek.Sunday ? Color.Red : date.DayOfWeek == DayOfWeek.Saturday ? Color.Blue : ForeColorItemsHeader);

                g.DrawString(vietnameseDayName, FontItems, new SolidBrush(drawColor), rect, m_Format);
            }

            g.TextRenderingHint = TextRenderingHint.SystemDefault;
        }

        // Phương thức hỗ trợ để lấy tên ngày bằng tiếng Việt
        private string GetVietnameseDayName(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday: return "Thứ 2";
                case DayOfWeek.Tuesday: return "Thứ 3";
                case DayOfWeek.Wednesday: return "Thứ 4";
                case DayOfWeek.Thursday: return "Thứ 5";
                case DayOfWeek.Friday: return "Thứ 6";
                case DayOfWeek.Saturday: return "Thứ 7";
                case DayOfWeek.Sunday: return "Chủ nhật";
                default: return "";
            }
        }

        // item
        /// <summary>
        ///  draw OD_User_Order Item with 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="rect"></param>
        /// <param name="oDUserOrder"></param>
        public void DrawODUserOrderItem(Graphics g, Rectangle rect, ODUserOrderItemDraw oDUserOrder)
        {
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            StringFormat m_Format = new StringFormat();
            m_Format.Alignment = StringAlignment.Center;
            m_Format.LineAlignment = StringAlignment.Center;
            m_Format.Trimming = StringTrimming.EllipsisCharacter;
            //rect.X += 2;
            //rect.Y += 2;
            //rect.Width -= 4;
            //rect.Height -= 4;
            Color colPlan_Border = oDUserOrder.BorderColor;
            if (oDUserOrder.ServiceUniqKey == null || oDUserOrder.ServiceUniqKey == Guid.Empty)
            {
                rect.X += 2;
                rect.Y += 2;
                rect.Width -= 4;
                rect.Height -= 4;
                // using (SolidBrush brush = new SolidBrush(Color.FromArgb(125, oDUserOrder.Color)))
                using (SolidBrush brush = new SolidBrush(oDUserOrder.Color))
                    g.FillRectangle(brush, rect);
                colPlan_Border = oDUserOrder.BorderColor;
                // oDUserOrder.Color;
                using (Pen m_Pen = new Pen(colPlan_Border, 2))
                    g.DrawRectangle(m_Pen, rect);
                if (oDUserOrder.EndDate.Subtract(oDUserOrder.StartDate).TotalMinutes >= 30)
                {
                    g.DrawString(oDUserOrder.WorkContent, this.FontItems, new SolidBrush(Color.White), rect, m_Format);
                }
            }
            else
            {
                if ((oDUserOrder.ServiceCode_Login != null && oDUserOrder.ServiceCode_Login.Trim().ToLower() == ServiceCodeLogin.Trim().ToLower()) || (oDUserOrder.ServiceCode_Login == null && oDUserOrder.ServiceUniqKey == idServiceLogin))
                {
                    if (oDUserOrder.ServiceCode == null || string.IsNullOrWhiteSpace(oDUserOrder.ServiceCode))
                    {
                        using (SolidBrush brush = new SolidBrush(oDUserOrder.Color))
                            g.FillRectangle(brush, rect);
                        colPlan_Border = oDUserOrder.Color;
                    }
                    else
                    {
                        //using (SolidBrush brush = new SolidBrush(oDUserOrder.Color))
                        //    g.FillRectangle(brush, rect);
                        Color colPlan = Color.Brown;
                        //2024.03.29 Dat Ins S
                        //if (oDUserOrder.CANCEL_FLAG)
                        //{
                        //    colPlan = ModelsConst.COLOR_ORDER_SERVICE.ChangeColor();
                        //}
                        //2024.03.29 Dat Ins E
                        colPlan_Border = Color.Black;
                        //
                        using (SolidBrush brush = new SolidBrush(colPlan))
                            g.FillRectangle(brush, rect);
                    }
                }
                else
                {
                    //using (SolidBrush brush = new SolidBrush(Color.FromArgb(125, oDUserOrder.Color)))
                    //g.FillRectangle(brush, rect);
                    if (oDUserOrder.ServiceCode == null || string.IsNullOrWhiteSpace(oDUserOrder.ServiceCode))
                    {
                        using (SolidBrush brush = new SolidBrush(Color.FromArgb(125, oDUserOrder.Color)))
                            g.FillRectangle(brush, rect);
                        colPlan_Border = oDUserOrder.Color;
                    }
                    else
                    {
                        Color colPlan = Color.Brown;
                        //2024.03.29 Dat Ins S
                        //if (oDUserOrder.CANCEL_FLAG)
                        //{
                        //    colPlan = ModelsConst.COLOR_ORDER_SERVICE.ChangeColor();
                        //}
                        //2024.03.29 Dat Ins E
                        colPlan_Border = Color.Black;
                        //
                        using (SolidBrush brush = new SolidBrush(colPlan))
                            g.FillRectangle(brush, rect);
                    }
                }

                using (Pen m_Pen = new Pen(colPlan_Border, 2))
                    g.DrawRectangle(m_Pen, rect);

                // Draw shadow lines
                //int xLeft = rect.X + 6;
                //int xRight = rect.Right + 1;
                //int yTop = rect.Y + 1;
                //int yButton = rect.Bottom + 1;
                //for (int i = 0; i < 5; i++)
                //{
                //    using (Pen shadow_Pen = new Pen(Color.FromArgb(70 - 12 * i, Color.Black)))
                //    {
                //        g.DrawLine(shadow_Pen, xLeft + i, yButton + i, xRight + i - 1, yButton + i); //horisontal lines
                //        g.DrawLine(shadow_Pen, xRight + i, yTop + i, xRight + i, yButton + i); //vertical
                //    }
                //}
                //  }
                //2023.07.03 Dat Ins S
                Font showFont = new Font(FontItems.Name, 8, FontStyle.Regular);
                if (oDUserOrder.WorkContent != "*")
                {
                    g.DrawString(oDUserOrder.WorkContent, showFont, new SolidBrush(ForeColorItems), rect, m_Format);
                }
                else
                {
                    showFont = new Font(FontItems.Name, 12, FontStyle.Bold);
                    g.DrawString(oDUserOrder.WorkContent, showFont, new SolidBrush(ForeColorItems), rect, m_Format);
                }
                //2023.07.03 Dat Ins E
            }
            //  g.RotateTransform(0);
            g.TextRenderingHint = TextRenderingHint.SystemDefault;
        }



    }
}