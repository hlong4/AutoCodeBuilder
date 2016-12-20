using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.BLL.Build
{
    /// <summary>
    /// 创建模型
    /// </summary>
    public class BuildModel
    {
        /// <summary>
        /// 生成实体模型代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <returns></returns>
        public string BuildCode_Model(string tableName, List<Column> columnList)
        {
            StringPlus sp = new StringPlus();

            //注释
            sp.AppendSpaceLine(1, "/// <summary>");
            sp.AppendSpaceLine(1, "/// " + tableName + "实体");
            sp.AppendSpaceLine(1, "/// </summary>");

            //类头
            sp.AppendSpaceLine(1, string.Format("public class {0}", tableName));

            //类体
            sp.AppendSpaceLine(1, "{");
            foreach (Column colunm in columnList)
            {
                sp.AppendSpaceLine(2, string.Format("public {0} {1} {{ get; set; }}", colunm.Type.ToCSharpTypeString(), colunm.Name));
            }
            sp.AppendSpaceLine(1, "}");

            return sp.ToString();
        }
    }
}
