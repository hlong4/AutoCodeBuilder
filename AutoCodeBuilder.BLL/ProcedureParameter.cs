using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.BLL
{
    /// <summary>
    /// 存储过程参数
    /// </summary>
    public class ProcedureParameter
    {
        /// <summary>
        /// 参数名称
        /// </summary>
        public string Param { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public DbType Type { get; set; }
        /// <summary>
        /// 参数类型
        /// </summary>
        public ParameterDirection Direction { get; set; }
    }
}
