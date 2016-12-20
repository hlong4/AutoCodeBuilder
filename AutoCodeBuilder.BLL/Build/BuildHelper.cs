using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.BLL.Build
{
    /// <summary>
    /// 创建帮助类
    /// </summary>
    public class BuildHelper
    {

        /// <summary>
        /// 获取参数列表串（函数头）
        /// </summary>
        /// <param name="keyColumnList">参数列表</param>
        /// <param name="isWithType">是否带类型</param>
        /// <returns></returns>
        public static string BuildParameterListString(List<Column> keyColumnList, bool isWithType)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < keyColumnList.Count; i++)
            {
                if (isWithType)
                {
                    sb.Append(string.Format("{0} ", keyColumnList[i].Type.ToCSharpTypeString()));
                }
                sb.Append(string.Format("{0}", keyColumnList[i].Name));
                if (i != keyColumnList.Count - 1)
                {
                    sb.Append(",");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 创建where串（衔接where 1>0）
        /// </summary>
        /// <param name="keyColumnList"></param>
        /// <returns></returns>
        public static string BuildWhereString(List<Column> keyColumnList)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < keyColumnList.Count; i++)
            {
                sb.Append(" and ");
                if (keyColumnList[i].Type == "int" || keyColumnList[i].Type == "float" || keyColumnList[i].Type == "double" || keyColumnList[i].Type == "decimal")
                {
                    sb.Append(string.Format("{0}=\" + {0}", keyColumnList[i].Name));
                }
                else
                {
                    sb.Append(string.Format("{0}='\" + {0} + \"'", keyColumnList[i].Name));
                    if (i == keyColumnList.Count - 1)
                    {
                        sb.Append("\"");
                    }
                }

                //if (i != keyColumnList.Count - 1)
                //{
                //    sb.Append(" + ");
                //}
            }
            return sb.ToString();
        }

        /// <summary>
        /// 创建where串(存储过程)
        /// </summary>
        /// <param name="keyColumnList"></param>
        /// <returns></returns>
        public static string BuildWhereStringInP(List<Column> keyColumnList)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < keyColumnList.Count; i++)
            {
                sb.Append(string.Format("{0}=@{0}", keyColumnList[i].Name));

                if (i != keyColumnList.Count - 1)
                {
                    sb.Append(" and ");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 创建字段列字符串
        /// </summary>
        /// <param name="list">字段列表</param>
        /// <param name="hadSign">是否有@字符</param>
        /// <returns></returns>
        public static string BuildColumnList(List<Column> list,bool hadSign)
        {
            string str="";
            foreach (Column colunm in list)
            {
                str += hadSign ? "@" : "";
                str += colunm.Name;
                if (colunm.Name != list[list.Count - 1].Name)
                {
                    str += ",";
                }
            }
            return str;
        }

        /// <summary>
        /// 创建修改串（a=@a,b=@b,c=@c...）
        /// </summary>
        /// <param name="keyColumnList"></param>
        /// <returns></returns>
        public static string BuildSetString(List<Column> columnList)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Column colunm in columnList)
            {
                sb.Append(colunm.Name + "=@" + colunm.Name);
                if (colunm.Name != columnList[columnList.Count - 1].Name)
                {
                    sb.Append(",");
                }
            }
            return sb.ToString();
        }
    }
}
