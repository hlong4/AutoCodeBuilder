using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace AutoCodeBuilder.Common.Configure
{
    /// <summary>
    /// 连接配置帮助类
    /// </summary>
    public class ConnectionConfigHelper
    {
        string filePath = "Config.xml";
        public List<ConnectionModel> GetList()
        {
            List<ConnectionModel> list = new List<ConnectionModel>();

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNode node = doc.SelectSingleNode("//config");//
            foreach (XmlElement n in node.ChildNodes)
            {
                ConnectionModel temp = new ConnectionModel();
                temp.Server = n.GetAttribute("Server");
                temp.DataBaseName = n.GetAttribute("DataBaseName");
                temp.VerifyType = n.GetAttribute("VerifyType");
                temp.UserName = n.GetAttribute("UserName");
                temp.Password = n.GetAttribute("Password");
                list.Add(temp);
            }
            
            return list;
        }
    }
}
