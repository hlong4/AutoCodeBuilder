using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.BLL.Build
{
    /// <summary>
    /// 创建业务逻辑层
    /// </summary>
    public class BuildBLL:IBuildBLL
    {
        /// <summary>
        /// 生成获取实体代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="keyColumnList"></param>
        /// <returns></returns>
        public string BuildCode_GetModel(string tableName, List<Column> keyColumnList)
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
            sp.AppendSpaceLine(2, string.Format("return dal.GetModel({0});",BuildHelper.BuildParameterListString(keyColumnList, false)));
            sp.AppendSpaceLine(1, "}");

            return sp.ToString();
        }

        /// <summary>
        /// 生成获取列表代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <returns></returns>
        public string BuildCode_GetList(string tableName)
        {
            StringPlus sp = new StringPlus();

            //注释
            sp.AppendSpaceLine(1, "/// <summary>");
            sp.AppendSpaceLine(1, "/// " + "获取列表");
            sp.AppendSpaceLine(1, "/// </summary>");

            //方法头
            string strretu = "DataTable";
            string strFun = string.Format("public {0} GetList(string condition)", strretu);
            sp.AppendSpaceLine(1, strFun);

            //方法体
            sp.AppendSpaceLine(1, "{");
            sp.AppendSpaceLine(2, "return dal.GetList(condition);");
            sp.AppendSpaceLine(1, "}");

            return sp.ToString();
        }

        /// <summary>
        /// 生成添加方法代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <returns></returns>
        public string BuildCode_Add(string tableName)
        {
            StringPlus sp = new StringPlus();

            //注释
            sp.AppendSpaceLine(1, "/// <summary>");
            sp.AppendSpaceLine(1, "/// " + "添加");
            sp.AppendSpaceLine(1, "/// </summary>");

            //方法头
            string strretu = "bool";
            string strFun = "public " + strretu + " Add(" + tableName + " model)";
            sp.AppendSpaceLine(1, strFun);

            //方法体
            sp.AppendSpaceLine(1, "{");
            sp.AppendSpaceLine(2, "if (dal.Add(model) > 0)");
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

        /// <summary>
        /// 生成修改方法代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <param name="keyColumnList"></param>
        /// <returns></returns>
        public string BuildCode_Update(string tableName)
        {
            StringPlus sp = new StringPlus();

            //注释
            sp.AppendSpaceLine(1, "/// <summary>");
            sp.AppendSpaceLine(1, "/// " + "修改");
            sp.AppendSpaceLine(1, "/// </summary>");

            //方法头
            string strretu = "bool";
            string strFun = "\t" + "public " + strretu + " Update(" + tableName + " model)";
            sp.AppendLine(strFun);

            //方法体
            sp.AppendSpaceLine(1, "{");
            sp.AppendSpaceLine(2, "if (dal.Update(model) > 0)");
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
            string strFun = string.Format("public bool Delete({0})", BuildHelper.BuildParameterListString(keyColumnList, true));
            sp.AppendSpaceLine(1, strFun);

            //方法体
            sp.AppendSpaceLine(1, "{");
            sp.AppendSpaceLine(2, string.Format("if (dal.Delete({0}) > 0)", BuildHelper.BuildParameterListString(keyColumnList, false)));
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
            sp.AppendSpaceLine(2, string.Format("return dal.Exist({0});",BuildHelper.BuildParameterListString(keyColumnList, false)));
            sp.AppendSpaceLine(1, "}");

            return sp.ToString();
        }
    }
}
