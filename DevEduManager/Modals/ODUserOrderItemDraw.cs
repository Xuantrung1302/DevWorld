using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleWeekView
{
    public class ODUserOrderItemDraw
    {
        #region properties
        ///// <summary>
        ///// 
        ///// </summary>
        //public long OrderID
        //{
        //    get;
        //    set;
        //}
        /// <summary>
        /// 
        /// </summary>
        public Guid ServiceUniqKey
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ServiceCode
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ServiceCode_Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// time begin
        /// </summary>
        private DateTime m_StartDate;
        public DateTime StartDate
        {
            get
            {
                return m_StartDate;
            }
            set
            {
                m_StartDate = value;
            }
        }


        /// <summary>
        /// time end
        /// </summary>
        private DateTime m_EndDate;
        public DateTime EndDate
        {
            get
            {
                return m_EndDate;
            }
            set
            {
                m_EndDate = value;
            }
        }

        private DateTime m_StartDate_Draw;
        public DateTime StartDate_Draw
        {
            get
            {
                return m_StartDate_Draw;
            }
            set
            {
                m_StartDate_Draw = value;
            }
        }

        private DateTime m_EndDate_Draw;
        public DateTime EndDate_Draw
        {
            get
            {
                return m_EndDate_Draw;
            }
            set
            {
                m_EndDate_Draw = value;
            }
        }

        /// <summary>
        /// backcolor of item draw
        /// </summary>
        //R:222 / G:207 / B:0
        private Color color = Color.FromArgb(222, 207, 0);
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        /// <summary>
        ///  BorderColor of item draw
        /// </summary>
        //R:196 / G:183 / B:0
        private Color m_BorderColor = Color.FromArgb(196, 183, 0);
        public Color BorderColor
        {
            get
            {
                return m_BorderColor;
            }
            set
            {
                m_BorderColor = value;
            }
        }

        /// <summary>
        ///  backcolor of select item draw
        /// </summary>
        // R:247 / G:150 / B:070
        private Color colorSel = Color.FromArgb(247, 150, 070);
        public Color ColorSelected
        {
            get
            {
                return colorSel;
            }
            set
            {
                colorSel = value;
            }
        }

        /// <summary>
        ///  Border Color of select item draw
        /// </summary>
        private Color m_BorderColorSel = Color.FromArgb(196, 183, 0);
        public Color BorderColorSelected
        {
            get
            {
                return m_BorderColorSel;
            }
            set
            {
                m_BorderColorSel = value;
            }
        }

        /// <summary>
        /// Title of item draw
        /// </summary>
        private string m_Title = "";
        [System.ComponentModel.DefaultValue("")]
        public string WorkContent
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }
        //2023.08.23 Dat Ins S: staff list to show when hover
        private string m_showStaff = "";
        public string showStaff
        {
            get
            {
                return m_showStaff;
            }
            set
            {
                m_showStaff = value;
            }
        }
        //2023.08.23 Dat Ins E
        /// <summary>
        /// 
        /// </summary>
        public string NOT_ALLOW_DUPPLICATED_PATTERNS { get; set; }
        /// <summary>
        /// count  ODUserOrder items in one the time
        /// </summary>
        internal int m_ConflictCount;
        #endregion

        public ODUserOrderItemDraw()
        {
            ID = Guid.NewGuid();
            m_Title = "New Order";
        }
        public bool CANCEL_FLAG;  //2024.03.29 Dat Ins
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ODUserOrderItemDraw Copy()
        {
            ODUserOrderItemDraw objItem = new ODUserOrderItemDraw();
            objItem.BorderColor = BorderColor;
            objItem.BorderColorSelected = BorderColorSelected;
            objItem.Color = Color;
            objItem.ColorSelected = ColorSelected;
            objItem.EndDate = EndDate;
            objItem.EndDate_Draw = EndDate_Draw;
            objItem.ID = ID;
            //objItem.OrderID = OrderID;
            objItem.ServiceUniqKey = ServiceUniqKey;
            objItem.StartDate = StartDate;
            objItem.StartDate_Draw = StartDate_Draw;
            objItem.Value = Value;
            objItem.WorkContent = WorkContent;
            objItem.showStaff = showStaff; //2023.08.23 Dat Ins
            objItem.ServiceCode = ServiceCode;
            objItem.ServiceCode_Login = ServiceCode_Login;
            objItem.NOT_ALLOW_DUPPLICATED_PATTERNS = NOT_ALLOW_DUPPLICATED_PATTERNS;
            objItem.CANCEL_FLAG = CANCEL_FLAG; // 2024.03.29 Dat Ins 
            return objItem;
        }
    }

    #region SelectionType
    /// <summary>
    /// Selection Type when click to calendar
    /// </summary>
    public enum ODUserOrderSelectionType
    {
        DateRectangle,
        ODUserOrderItemDraw
    }
    #endregion
}
