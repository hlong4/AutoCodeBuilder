using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.BLL.Build
{
    /// <summary>
    /// 创建存储过程
    /// </summary>
    public class BuildProcedure
    {
        /// <summary>
        /// 生成存储过程方法代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <returns></returns>
        public string BuildCode_Procedure(string procedureName, List<ProcedureParameter> paramList)
        {
            StringPlus sp = new StringPlus();

            //注释
            sp.AppendSpaceLine(1, "/// <summary>");
            sp.AppendSpaceLine(1, "/// ");
            sp.AppendSpaceLine(1, "/// </summary>");

            //方法头
            string strretu = "DataTable";
            string strFun = "public " + strretu + " GetProcedure()";
            sp.AppendSpaceLine(1, strFun);

            //方法体
            sp.AppendSpaceLine(1, "{");
            sp.AppendSpaceLine(2, "SQLHelper sqlhelper = new SQLHelper();");
            sp.AppendSpaceLine(2, "SqlParameter[] prams = new SqlParameter[" + paramList.Count + "];");
            for (int i = 0; i < paramList.Count; i++)
            {
                sp.AppendSpaceLine(2, "prams[" + i + "] = new SqlParameter(\"" + paramList[i].Param + "\", DbType." + paramList[i].Type.ToString() + ");");
            }
            for (int i = 0; i < paramList.Count; i++)
            {
                sp.AppendSpaceLine(2, "prams[" + i + "].Value = \"\";");
            }
            sp.AppendSpaceLine(2, "DataTable dt = sqlhelper.RunProcToDt(\"" + procedureName + "\", prams);");
            sp.AppendSpaceLine(2, "return dt;");
            sp.AppendSpaceLine(1, "}");
            return sp.ToString();
        }
    }
}
