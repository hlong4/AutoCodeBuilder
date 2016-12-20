using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace AutoCodeBuilder.Common.Configure
{
    /// <summary>
    /// 创建信息配置
    /// </summary>
    public class ConnectionConfig
    {
        string filePath = "";
        List<ConnectionModel> list;

        XmlDocument doc;

        /// <summary>
        /// 生成默认配置文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="list">配置的键值列表</param>
        public ConnectionConfig(string filePath, List<ConnectionModel> list)
        {
            this.filePath = filePath;
            this.list = list;
        }

        /// <summary>
        /// 生成处理
        /// </summary>
        public void CreateHandle()
        {
            doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "GB2312", null);
            doc.AppendChild(dec);

            //一级
            XmlElement root = doc.CreateElement("config");
            doc.AppendChild(root);

            foreach (var li in list)
            {
                //二级
                XmlElement element1 = doc.CreateElement("connection");
                element1.SetAttribute("Server", li.Server);
                element1.SetAttribute("DataBaseName", li.DataBaseName);
                element1.SetAttribute("VerifyType", li.VerifyType);
                element1.SetAttribute("UserName", li.UserName);
                element1.SetAttribute("Password", li.Password);
                root.AppendChild(element1);
            }

            doc.Save(filePath);
        }
    }
}
