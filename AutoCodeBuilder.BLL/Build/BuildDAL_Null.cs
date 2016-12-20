using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.BLL.Build
{
    /// <summary>
    /// 
    /// </summary>
    public class BuildDAL_Null : IBuildDAL
    {
        /// <summary>
        /// 生成获取实体代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="keyColumnList"></param>
        /// <returns></returns>
        public string BuildCode_GetModel(string tableName, List<Column> columnList, List<Column> keyColumnList)
        {
            return "";
        }

        

        /// <summary>
        /// 生成获取列表代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <returns></returns>
        public string BuildCode_GetList(string tableName, List<Column> columnList)
        {
            return "";
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
            return "";

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
            return "";

        }

        /// <summary>
        /// 生成删除代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="keyColumnList"></param>
        /// <returns></returns>
        public string BuildCode_Delete(string tableName, List<Column> keyColumnList)
        {
            return "";
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
            return "";
        }
    }
}
