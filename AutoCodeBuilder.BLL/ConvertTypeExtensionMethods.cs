using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.BLL
{
    /// <summary>
    /// 类型转换
    /// </summary>
    public static class ConvertTypeExtensionMethods
    {
        /// <summary>
        /// 类型转成SqlDbType
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToSqlDbTypeString(this string str)
        {
            switch (str)
            {
                case "char":
                    return "Char";
                case "nchar":
                case "varchar":
                    return "VarChar";
                case "nvarchar":
                    return "NVarChar";
                case "int":
                case "smallint":
                    return "Int";
                case "decimal":
                    return "Decimal";
                case "float":
                    return "Float";
                case "datetime":
                    return "DateTime";
                case "date":
                    return "Date";
                case "bit":
                    return "Bit";
                default:
                    return str;
            }
        }

        /// <summary>
        /// 类型转成C#类型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToCSharpTypeString(this string str)
        {
            switch (str)
            {
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                    return "string";
                case "int":
                case "float":
                case "decimal":
                    return str;
                case "datetime":
                case "date":
                    return "DateTime";
                case "bit":
                    return "bool";
                case "smallint":
                    return "int";
                default:
                    return str;
            }
        }
    }
}
