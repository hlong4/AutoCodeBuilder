using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.Common
{
    public static class CommonExtensionMethods
    {
        ///// <summary>
        ///// 过滤特殊字符（',;--,=,or,and）
        ///// </summary>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //public static string ReplaceString(this string str)
        //{
        //    str = DataCommon.ReplaceString(str);
        //    return str;
        //}

        /// <summary>
        /// 判断是否是Int型数据
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsInt(this string str)
        {
            int temp;
            return int.TryParse(str, out temp);
        }

        /// <summary>
        /// 判断是否是DateTime型数据
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDateTime(this string str)
        {
            DateTime temp;
            return DateTime.TryParse(str, out temp);
        }

        /// <summary>
        /// 是否是某格式的日期
        /// </summary>
        /// <param name="str"></param>
        /// <param name="format">指定格式</param>
        /// <returns></returns>
        public static bool IsDateInFormat(this string str, string format)
        {
            DateTime temp;
            return DateTime.TryParseExact(str, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AllowInnerWhite, out temp);
        }

        /// <summary>
        /// 字符串按指定格式转成日期类型
        /// </summary>
        /// <param name="str"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static DateTime ToDateInFormat(this string str, string format)
        {
            DateTime temp;
            if (DateTime.TryParseExact(str, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AllowInnerWhite, out temp))
            {

            }
            return temp;
        }

        /// <summary>
        /// 字符串转成日期
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime ToDate(this string str)
        {
            DateTime temp;
            if (DateTime.TryParse(str, out temp))
            {

            }
            return temp;
        }

        /// <summary>
        /// 日期类型按指定格式转字符类型，日期类型为空时返回空字符串。
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToText(this DateTime date)
        {
            if (date != null)
            {
                return date.ToString("yyyy-MM-dd");
            }
            else
            {
                return "";
            }
        }
        /// <summary>
        /// 日期类型按指定格式转字符类型，日期类型为空时返回空字符串。
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToText(this DateTime date, string format)
        {
            if (date != null)
            {
                return date.ToString(format);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// 字符串转成整形
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ToInt(this string str)
        {
            int temp;
            if (int.TryParse(str, out temp))
            {

            }
            return temp;
        }

        /// <summary>
        /// 字符串转成十进制
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this string str)
        {
            decimal temp;
            if (decimal.TryParse(str, out temp))
            {

            }
            return temp;
        }

        /// <summary>
        /// 判断是否是十进制数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDecimal(this string str)
        {
            decimal temp;
            return decimal.TryParse(str, out temp);
        }
    }
}
