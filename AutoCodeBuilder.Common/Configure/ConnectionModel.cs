using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.Common.Configure
{
    /// <summary>
    /// 数据连接模型
    /// </summary>
    public class ConnectionModel
    {
        public string Server { get; set; }
        public string DataBaseName { get; set; }
        public string VerifyType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
