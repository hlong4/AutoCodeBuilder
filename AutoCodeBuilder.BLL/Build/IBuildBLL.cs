using AutoCodeBuilder.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.BLL.Build
{
    /// <summary>
    /// 创建BLL接口
    /// </summary>
    public interface IBuildBLL
    {
        /// <summary>
        /// 生成获取实体代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="keyColumnList"></param>
        string BuildCode_GetModel(string tableName, List<Column> keyColumnList);

        /// <summary>
        /// 生成获取列表代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        string BuildCode_GetList(string tableName);

        /// <summary>
        /// 生成添加方法代码
        /// </summary>
        /// <param name="tableName"></param>
        string BuildCode_Add(string tableName);

        /// <summary>
        /// 生成修改方法代码
        /// </summary>
        /// <param name="tableName"></param>
        string BuildCode_Update(string tableName);

        /// <summary>
        /// 生成删除代码
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="keyColumnList"></param>
        string BuildCode_Delete(string tableName, List<Column> keyColumnList);

        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <param name="keyColumnList"></param>
        string BuildCode_Exist(string tableName, List<Column> keyColumnList);
    }
}
