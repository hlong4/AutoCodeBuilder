using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.BLL.Build
{
    /// <summary>
    /// 创建数据访问层（无SQLHelper）
    /// </summary>
    public class BuildDAL_NoSQLHelper:IBuildDAL
    {
        ///// <summary>
        ///// 生成获取实体代码
        ///// </summary>
        ///// <param name="tableName"></param>
        ///// <param name="keyColumnList"></param>
        ///// <returns></returns>
        //public string BuildCode_GetModel(string tableName, List<Column> columnList, List<Column> keyColumnList)
        //{
        //    string txt = "";
        //    txt = BuildCode_GetModel(tableName, keyColumnList);
        //    txt += "\n";
        //    txt += BuildCode_GetModelTable(tableName, columnList, keyColumnList);
        //    return txt;
        //}

        /// <summary>
        /// 生成获取实体代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="keyColumnList"></param>
        /// <returns></returns>
        public string BuildCode_GetModel(string tableName, List<Column> columnList, List<Column> keyColumnList)
        {
            StringPlus sp = new StringPlus();

            //注释
            sp.AppendSpaceLine(1, "/// <summary>");
            sp.AppendSpaceLine(1, "/// " + "获取模型");
            sp.AppendSpaceLine(1, "/// </summary>");

            //方法头
            string strFun = string.Format("public {0} GetModel({1})", tableName, BuildHelper.BuildParameterListString(keyColumnList, true));
            sp.AppendSpaceLine(1, strFun);

            //方法体
            sp.AppendSpaceLine(1, "{");
            sp.AppendSpaceLine(2, "string strConn = Config.ConnectionString;");
            sp.AppendSpaceLine(2, "StringBuilder strSql = new StringBuilder();");
            string columnsString = BuildHelper.BuildColumnList(columnList, false);

            sp.AppendSpaceLine(2, string.Format("strSql.Append(\"select {0}\");", columnsString));
            sp.AppendSpaceLine(2, string.Format("strSql.Append(\" from {0}\");", tableName));
            sp.AppendSpaceLine(2, string.Format("strSql.Append(\" where 1>0{0});", BuildHelper.BuildWhereString(keyColumnList)));

            sp.AppendSpaceLine(2, "SqlConnection conn = new SqlConnection(strConn);");
            sp.AppendSpaceLine(2, "SqlCommand cmd = new SqlCommand(strSql.ToString(), conn);");
            sp.AppendSpaceLine(2, "conn.Open();");
            sp.AppendSpaceLine(2, "SqlDataReader dr = cmd.ExecuteReader();");
            sp.AppendSpaceLine(2, string.Format("{0} model = new {0}();", tableName));
            sp.AppendSpaceLine(2, "if (dr.Read())");
            sp.AppendSpaceLine(2, "{");

            foreach (var column in columnList)
            {
                if (column.Type.ToCSharpTypeString() == "int" || column.Type.ToCSharpTypeString() == "float" || column.Type.ToCSharpTypeString() == "decimal")
                {
                    sp.AppendSpaceLine(3, string.Format("model.{0} = Convert.ToInt16(dr[\"{0}\"]);", column.Name));
                }
                else if (column.Type.ToCSharpTypeString() == "bool")
                {
                    sp.AppendSpaceLine(3, string.Format("model.{0} = Convert.ToBoolean(dr[\"{0}\"]);", column.Name));
                }
                else if (column.Type.ToCSharpTypeString() == "DateTime")
                {
                    sp.AppendSpaceLine(3, string.Format("model.{0} = Convert.ToDateTime(dr[\"{0}\"]);", column.Name));
                }
                else
                {
                    sp.AppendSpaceLine(3, string.Format("model.{0} = dr[\"{0}\"].ToString();",column.Name));
                }
            }

            sp.AppendSpaceLine(2, "}");
            sp.AppendSpaceLine(2, "conn.Close();");

            sp.AppendSpaceLine(2, "return model;");
            sp.AppendSpaceLine(1, "}");

            return sp.ToString();
        }

        //private string BuildCode_GetModelTable(string tableName, List<Column> columnList, List<Column> keyColumnList)
        //{
        //    StringPlus sp = new StringPlus();

        //    //注释
        //    sp.AppendSpaceLine(1, "/// <summary>");
        //    sp.AppendSpaceLine(1, "/// " + "获取模型Tabel");
        //    sp.AppendSpaceLine(1, "/// </summary>");

        //    //方法头
        //    string strFun = string.Format("public DataTable GetModelTable({0})", BuildHelper.BuildParameterListString(keyColumnList, true));
        //    sp.AppendSpaceLine(1, strFun);

        //    //方法体
        //    sp.AppendSpaceLine(1, "{");
        //    sp.AppendSpaceLine(2, "StringBuilder strSql = new StringBuilder();");
        //    string columnsString = BuildHelper.BuildColumnList(columnList, false);

        //    sp.AppendSpaceLine(2, string.Format("strSql.Append(\"select {0}\");", columnsString));
        //    sp.AppendSpaceLine(2, string.Format("strSql.Append(\" from {0}\");", tableName));
        //    sp.AppendSpaceLine(2, string.Format("strSql.Append(\" where 1>0{0});", BuildHelper.BuildWhereString(keyColumnList)));
        //    sp.AppendSpaceLine(2, "DataTable dt = SQLHelper.ExecuteDt(strSql.ToString());");
        //    sp.AppendSpaceLine(2, "return dt;");
        //    sp.AppendSpaceLine(1, "}");

        //    return sp.ToString();
        //}


        /// <summary>
        /// 生成获取列表代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <returns></returns>
        public string BuildCode_GetList(string tableName, List<Column> columnList)
        {
            StringPlus sp = new StringPlus();

            //注释
            sp.AppendSpaceLine(1, "/// <summary>");
            sp.AppendSpaceLine(1, "/// " + "获取列表");
            sp.AppendSpaceLine(1, "/// </summary>");

            //方法头
            string strretu = "DataSet";
            string strFun = string.Format("public {0} GetList(string condition)", strretu);
            sp.AppendSpaceLine(1, strFun);

            //方法体
            sp.AppendSpaceLine(1, "{");
            sp.AppendSpaceLine(2, "string strConn = Config.ConnectionString;");
            sp.AppendSpaceLine(2, "StringBuilder strSql = new StringBuilder();");
            string columnsString = BuildHelper.BuildColumnList(columnList, false);

            sp.AppendSpaceLine(2, string.Format("strSql.Append(\"select {0}\");", columnsString));
            sp.AppendSpaceLine(2, string.Format("strSql.Append(\" from {0}\");", tableName));
            sp.AppendSpaceLine(2, string.Format("strSql.Append(\" where 1>0 \" + condition);"));
            sp.AppendSpaceLine(2, "SqlConnection conn = new SqlConnection(strConn);");
            sp.AppendSpaceLine(2, "SqlDataAdapter da = new SqlDataAdapter(strSql.ToString(), conn);");
            sp.AppendSpaceLine(2, "DataSet ds = new DataSet();");
            sp.AppendSpaceLine(2, "da.Fill(ds);");
            sp.AppendSpaceLine(2, "return ds;");
            sp.AppendSpaceLine(1, "}");

            return sp.ToString();
        }

        /// <summary>
        /// 生成添加方法代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <param name="IsIdentity">主键是否是自增</param>
        /// <returns></returns>
        public string BuildCode_Add(string tableName, List<Column> columnList, bool IsIdentity)
        {
            StringPlus sp = new StringPlus();

            //注释
            sp.AppendSpaceLine(1, "/// <summary>");
            sp.AppendSpaceLine(1, "/// " + "添加");
            sp.AppendSpaceLine(1, "/// </summary>");

            //方法头
            string strretu = "int";
            string strFun = "public " + strretu + " Add(" + tableName + " model)";
            sp.AppendSpaceLine(1, strFun);

            //方法体
            sp.AppendSpaceLine(1, "{");
            sp.AppendSpaceLine(2, "string strConn = Config.ConnectionString;");
            sp.AppendSpaceLine(2, "StringBuilder strSql = new StringBuilder();");
            sp.AppendSpaceLine(2, "strSql.Append(\"insert into " + tableName + "(\");");
            string columnsString = BuildHelper.BuildColumnList(columnList, false);

            sp.AppendSpaceLine(2, "strSql.Append(\"" + columnsString + ")\");");
            sp.AppendSpaceLine(2, "strSql.Append(\" values (\");");
            columnsString = BuildHelper.BuildColumnList(columnList, true);

            sp.AppendSpaceLine(2, "strSql.Append(\"" + columnsString + ")\");");
            if (IsIdentity)//主键自增
            {
                sp.AppendSpaceLine(2, "strSql.Append(\";select @@IDENTITY\");");
            }
            sp.AppendSpaceLine(2, "SqlConnection conn = new SqlConnection(strConn);");
            sp.AppendSpaceLine(2, "SqlCommand cmd = new SqlCommand(strSql.ToString(), conn);");
            sp.AppendSpaceLine(2, "SqlParameter[] parameters = new SqlParameter[" + columnList.Count + "];");

            for (int i = 0; i < columnList.Count; i++)
            {
                sp.AppendSpaceLine(2, "parameters[" + i + "] = new SqlParameter(\"@" + columnList[i].Name + "\", SqlDbType." + columnList[i].Type.ToSqlDbTypeString() + ");");
            }
            for (int i = 0; i < columnList.Count; i++)
            {
                if (columnList[i].Type == "datetime" || columnList[i].Type == "date")//时间类型处理
                {
                    sp.AppendSpaceLine(2, "if (model." + columnList[i].Name + " == null)");
                    sp.AppendSpaceLine(2, "{");
                    sp.AppendSpaceLine(3, "parameters[" + i + "].IsNullable = true;");
                    sp.AppendSpaceLine(3, "parameters[" + i + "].Value = DBNull.Value;");
                    sp.AppendSpaceLine(2, "}");
                    sp.AppendSpaceLine(2, "else");
                    sp.AppendSpaceLine(2, "{");
                    sp.AppendSpaceLine(3, "parameters[" + i + "].Value = model." + columnList[i].Name + ";");
                    sp.AppendSpaceLine(2, "}");
                }
                else
                {
                    sp.AppendSpaceLine(2, "parameters[" + i + "].Value = model." + columnList[i].Name + ";");
                }
            }
            sp.AppendSpaceLine(2, "cmd.Parameters.AddRange(parameters);");
            sp.AppendSpaceLine(2, "conn.Open();");
            if (IsIdentity)//主键自增
            {
                sp.AppendSpaceLine(2, "int result = (int)cmd.ExecuteScalar();");
            }
            else//主键非自增
            {
                sp.AppendSpaceLine(2, "int result = cmd.ExecuteNonQuery();");
            }
            sp.AppendSpaceLine(2, "conn.Close();");
            sp.AppendSpaceLine(2, "return result;");

            sp.AppendSpaceLine(1, "}");
            return sp.ToString();

        }

        /// <summary>
        /// 生成修改方法代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <param name="keyColumnList"></param>
        /// <returns></returns>
        public string BuildCode_Update(string tableName, List<Column> columnList, List<Column> keyColumnList)
        {
            StringPlus sp = new StringPlus();

            //注释
            sp.AppendSpaceLine(1, "/// <summary>");
            sp.AppendSpaceLine(1, "/// " + "修改");
            sp.AppendSpaceLine(1, "/// </summary>");

            //方法头
            string strretu = "int";
            string strFun = "\t" + "public " + strretu + " Update(" + tableName + " model)";
            sp.AppendLine(strFun);

            //方法体
            sp.AppendSpaceLine(1, "{");
            sp.AppendSpaceLine(2, "string strConn = Config.ConnectionString;");
            sp.AppendSpaceLine(2, "StringBuilder strSql = new StringBuilder();");
            sp.AppendSpaceLine(2, "strSql.Append(\"update " + tableName + " set \");");
            string columnsString = BuildHelper.BuildSetString(columnList);
            sp.AppendSpaceLine(2, "strSql.Append(\" " + columnsString + " \");");
            sp.AppendSpaceLine(2, "strSql.Append(\" where " + BuildHelper.BuildWhereStringInP(keyColumnList) + "\");");
            sp.AppendSpaceLine(2, "SqlConnection conn = new SqlConnection(strConn);");
            sp.AppendSpaceLine(2, "SqlCommand cmd = new SqlCommand(strSql.ToString(), conn);");
            sp.AppendSpaceLine(2, "SqlParameter[] parameters = new SqlParameter[" + (columnList.Count + keyColumnList.Count) + "];");
            int i = 0;
            for (i = 0; i < columnList.Count; i++)
            {
                sp.AppendSpaceLine(2, "parameters[" + i + "] = new SqlParameter(\"@" + columnList[i].Name + "\", SqlDbType." + columnList[i].Type.ToSqlDbTypeString() + ");");
            }
            for (int k = 0; k < keyColumnList.Count; k++, i++)
            {
                sp.AppendSpaceLine(2, "parameters[" + i + "] = new SqlParameter(\"@" + keyColumnList[k].Name + "\", SqlDbType." + keyColumnList[k].Type.ToSqlDbTypeString() + ");");
            }
            int j = 0;
            for (j = 0; j < columnList.Count; j++)
            {
                sp.AppendSpaceLine(2, "parameters[" + j + "].Value = model." + columnList[j].Name + ";");
            }
            for (int k = 0; k < keyColumnList.Count; k++, j++)
            {
                sp.AppendSpaceLine(2, "parameters[" + j + "].Value = model." + keyColumnList[k].Name + ";");

            }
            sp.AppendSpaceLine(2, "cmd.Parameters.AddRange(parameters);");
            sp.AppendSpaceLine(2, "conn.Open();");
            sp.AppendSpaceLine(2, "int result = cmd.ExecuteNonQuery();");
            sp.AppendSpaceLine(2, "conn.Close();");
            sp.AppendSpaceLine(2, "return result;");

            sp.AppendSpaceLine(1, "}");
            return sp.ToString();

        }

        /// <summary>
        /// 生成删除代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="keyColumnList"></param>
        /// <returns></returns>
        public string BuildCode_Delete(string tableName, List<Column> keyColumnList)
        {
            StringPlus sp = new StringPlus();

            //注释
            sp.AppendSpaceLine(1, "/// <summary>");
            sp.AppendSpaceLine(1, "/// " + "删除");
            sp.AppendSpaceLine(1, "/// </summary>");

            //方法头
            string strFun = string.Format("public int Delete({0})", BuildHelper.BuildParameterListString(keyColumnList, true));
            sp.AppendSpaceLine(1, strFun);

            //方法体
            sp.AppendSpaceLine(1, "{");
            sp.AppendSpaceLine(2, "string strConn = Config.ConnectionString;");
            sp.AppendSpaceLine(2, string.Format("string strSql = \"delete from {0} where 1>0{1};", tableName, BuildHelper.BuildWhereString(keyColumnList)));
            sp.AppendSpaceLine(2, "SqlConnection conn = new SqlConnection(strConn);");
            sp.AppendSpaceLine(2, "SqlCommand cmd = new SqlCommand(strSql.ToString(), conn);");
            sp.AppendSpaceLine(2, "conn.Open();");
            sp.AppendSpaceLine(2, "cmd.ExecuteNonQuery();");
            sp.AppendSpaceLine(2, "conn.Close();");
            sp.AppendSpaceLine(2, "return 1;");

            sp.AppendSpaceLine(1, "}");

            return sp.ToString();
        }

        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <param name="keyColumnList"></param>
        /// <returns></returns>
        public string BuildCode_Exist(string tableName, List<Column> keyColumnList)
        {
            StringPlus sp = new StringPlus();

            //注释
            sp.AppendSpaceLine(1, "/// <summary>");
            sp.AppendSpaceLine(1, "/// " + "是否存在");
            sp.AppendSpaceLine(1, "/// </summary>");

            //方法头
            string strFun = string.Format("public bool Exist({0})", BuildHelper.BuildParameterListString(keyColumnList, true));
            sp.AppendSpaceLine(1, strFun);

            //方法体
            sp.AppendSpaceLine(1, "{");
            sp.AppendSpaceLine(2, string.Format("string condition = \"{0};", BuildHelper.BuildWhereString(keyColumnList)));
            sp.AppendSpaceLine(2, "DataSet ds = GetList(condition);");
            sp.AppendSpaceLine(2, "if (ds.Tables[0].Rows.Count > 0)");
            sp.AppendSpaceLine(2, "{");
            sp.AppendSpaceLine(3, "return true;");
            sp.AppendSpaceLine(2, "}");
            sp.AppendSpaceLine(2, "else");
            sp.AppendSpaceLine(2, "{");
            sp.AppendSpaceLine(3, "return false;");
            sp.AppendSpaceLine(2, "}");
            sp.AppendSpaceLine(1, "}");

            return sp.ToString();
        }

    }
}
