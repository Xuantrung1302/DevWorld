using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entity.Models
{
    public static class ModelsConst
    {
    //    #region color order, plan
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public static class COLOR_ORDER_SERVICE
    //    {
    //        //ServiceColor.Add("11", Color.FromArgb(242, 134, 54));
    //        //ServiceColor.Add("13", Color.FromArgb(222, 108, 131));
    //        //ServiceColor.Add("99", Color.FromArgb(123, 113, 232));
    //        public const string
    //            Service_99 = "99",
    //            Service_13 = "13",
    //            Service_11 = "11";
    //        public const int
    //           Service_99_Value = 99,
    //           Service_13_Value = 13,
    //           Service_11_Value = 11;

    //        public const int
    //          FC = 1,
    //          Inactive = 2,
    //          AS = 3;

    //        static Color Service_99_FC_Color = Color.FromArgb(238, 238, 238);
    //        static Color Service_99_FC_Border_Color = Color.FromArgb(238, 238, 238);

    //        static Color Service_99_Inactive_Color = Color.White;
    //        static Color Service_99_Inactive_Border_Color = Color.FromArgb(143, 143, 143);

    //        static Color Service_99_Color = Color.White;
    //        static Color Service_99_Border_Color = Color.Black;
    //        //13
    //        static Color Service_13_FC_Color = Color.FromArgb(239, 206, 187);
    //        static Color Service_13_FC_Border_Color = Service_13_FC_Color;

    //        static Color Service_13_Inactive_Color = Color.FromArgb(201, 160, 131);
    //        static Color Service_13_Inactive_Border_Color = Service_99_Inactive_Border_Color;

    //        static Color Service_13_Color = Service_13_Inactive_Color;
    //        static Color Service_13_Border_Color = Color.Black;

    //        //11
    //        static Color Service_11_FC_Color = Color.FromArgb(234, 242, 191);
    //        static Color Service_11_FC_Border_Color = Service_11_FC_Color;

    //        static Color Service_11_Inactive_Color = Color.FromArgb(224, 230, 153);
    //        static Color Service_11_Inactive_Border_Color = Service_99_Inactive_Border_Color;

    //        static Color Service_11_Color = Service_11_Inactive_Color;
    //        static Color Service_11_Border_Color = Color.Black;

    //        /// <summary>
    //        /// 
    //        /// </summary>
    //        /// <param name="sv_value"></param>
    //        /// <param name="typeData">FC = 1, Inactive = 2,  AS = 3; </param>
    //        /// <returns></returns>
    //        public static Color GetColorService(int? sv_value, int typeData = 3, bool _isBoder = false)
    //        {
    //            if (_isBoder)
    //            {
    //                if (sv_value != null && sv_value.Value == 99)
    //                {
    //                    if (typeData == 1)
    //                        return Service_99_FC_Border_Color;
    //                    else if (typeData == 2)
    //                        return Service_99_Inactive_Border_Color;
    //                    else
    //                        return Service_99_Border_Color;
    //                }
    //                else if (sv_value != null && sv_value.Value == 13)
    //                {
    //                    if (typeData == 1)
    //                        return Service_13_FC_Border_Color;
    //                    else if (typeData == 2)
    //                        return Service_13_Inactive_Border_Color;
    //                    else
    //                        return Service_13_Border_Color;
    //                }
    //                else if (sv_value != null && sv_value.Value == 11)
    //                {
    //                    if (typeData == 1)
    //                        return Service_11_FC_Border_Color;
    //                    else if (typeData == 2)
    //                        return Service_11_Inactive_Border_Color;
    //                    else
    //                        return Service_11_Border_Color;
    //                }
    //                else
    //                {
    //                    return Color.Empty;
    //                }
    //            }
    //            else
    //            {
    //                if (sv_value != null && sv_value.Value == 99)
    //                {
    //                    if (typeData == 1)
    //                        return Service_99_FC_Color;
    //                    else if (typeData == 2)
    //                        return Service_99_Inactive_Color;
    //                    else
    //                        return Service_99_Color;
    //                }
    //                else if (sv_value != null && sv_value.Value == 13)
    //                {
    //                    if (typeData == 1)
    //                        return Service_13_FC_Color;
    //                    else if (typeData == 2)
    //                        return Service_13_Inactive_Color;
    //                    else
    //                        return Service_13_Color;
    //                }
    //                else if (sv_value != null && sv_value.Value == 11)
    //                {
    //                    if (typeData == 1)
    //                        return Service_11_FC_Color;
    //                    else if (typeData == 2)
    //                        return Service_11_Inactive_Color;
    //                    else
    //                        return Service_11_Color;
    //                }
    //                else
    //                {
    //                    return Color.Empty;
    //                }
    //            }
    //        }


    //        /// <summary>
    //        /// 
    //        /// </summary>
    //        /// <param name="sv_code"></param>
    //        /// <returns></returns>
    //        public static Color GetColorService(string sv_code, int typeData = 3, bool _isBoder = false)
    //        {
    //            if (_isBoder)
    //            {
    //                if (!string.IsNullOrWhiteSpace(sv_code) && sv_code.Trim().Equals("99"))
    //                {
    //                    if (typeData == 1)
    //                        return Service_99_FC_Border_Color;
    //                    else if (typeData == 2)
    //                        return Service_99_Inactive_Border_Color;
    //                    else
    //                        return Service_99_Border_Color;
    //                }
    //                if (!string.IsNullOrWhiteSpace(sv_code) && sv_code.Trim().Equals("13"))
    //                {
    //                    if (typeData == 1)
    //                        return Service_13_FC_Border_Color;
    //                    else if (typeData == 2)
    //                        return Service_13_Inactive_Border_Color;
    //                    else
    //                        return Service_13_Border_Color;
    //                }
    //                if (!string.IsNullOrWhiteSpace(sv_code) && sv_code.Trim().Equals("11"))
    //                {
    //                    if (typeData == 1)
    //                        return Service_11_FC_Border_Color;
    //                    else if (typeData == 2)
    //                        return Service_11_Inactive_Border_Color;
    //                    else
    //                        return Service_11_Border_Color;
    //                }
    //                else
    //                {
    //                    return Color.Empty;
    //                }
    //            }
    //            else
    //            {
    //                if (!string.IsNullOrWhiteSpace(sv_code) && sv_code.Trim().Equals("99"))
    //                {
    //                    if (typeData == 1)
    //                        return Service_99_FC_Color;
    //                    else if (typeData == 2)
    //                        return Service_99_Inactive_Color;
    //                    else
    //                        return Service_99_Color;
    //                }
    //                if (!string.IsNullOrWhiteSpace(sv_code) && sv_code.Trim().Equals("13"))
    //                {
    //                    if (typeData == 1)
    //                        return Service_13_FC_Color;
    //                    else if (typeData == 2)
    //                        return Service_13_Inactive_Color;
    //                    else
    //                        return Service_13_Color;
    //                }
    //                if (!string.IsNullOrWhiteSpace(sv_code) && sv_code.Trim().Equals("11"))
    //                {

    //                    if (typeData == 1)
    //                        return Service_11_FC_Color;
    //                    else if (typeData == 2)
    //                        return Service_11_Inactive_Color;
    //                    else
    //                        return Service_11_Color;
    //                }
    //                else
    //                {
    //                    return Color.Empty;
    //                }
    //            }
    //        }
    //        #region change color order
    //        public static Color ChangeColor()//2024.02.28 Cong 1869 đổi màu của order theo service code
    //        {
    //            return Color.FromArgb(169, 169, 169);
    //        }
    //        #endregion
    //    }
    //    #endregion

    //    #region Sex
    //    public const string MALE = "男性";
    //    public const string FEMALE = "女性";
    //    public const string UNKNOWN = "その他";

    //    public const string MALE_INT = "1"; //"男性";
    //    public const string FEMALE_INT = "2"; //"女性";
    //    public const string UNKNOWN_INT = "3"; //"その他";
    //    #endregion

    }

}
