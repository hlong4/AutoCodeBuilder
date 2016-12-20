using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Xml;

namespace AutoCodeBuilder.BLL
{
    /// <summary>
    /// 配置文件
    /// </summary>
    public class ConfigBLL
    {
        /// <summary>
        /// 数据库连接测试
        /// </summary>
        /// <returns></returns>
        public static bool ConnectionTest()
        {
            SqlConnection conn = new SqlConnection(Config.ConnectionString);
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                //throw;
            }
        }

        ///// <summary>
        ///// 创建XML文件
        ///// </summary>
        //public void CreateXML()
        //{
        //    XmlDocument doc = new XmlDocument();
        //    XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "GB2312", null);
        //    doc.AppendChild(dec);
        //    //创建一个根节点（一级）
        //    XmlElement root = doc.CreateElement("Config");
        //    doc.AppendChild(root);
        //    //创建节点（二级）
        //    XmlNode node = doc.CreateElement("Connection");
        //    //创建节点（三级）
        //    XmlElement element1 = doc.CreateElement("Server");
        //    element1.InnerText = ".";
        //    node.AppendChild(element1);

        //    XmlElement element2 = doc.CreateElement("DataBase");
        //    element2.InnerText = "test";
        //    node.AppendChild(element2);

        //    XmlElement element3 = doc.CreateElement("UserName");
        //    element3.InnerText = "sa";
        //    node.AppendChild(element3);

        //    XmlElement element4 = doc.CreateElement("Password");
        //    element4.InnerText = "!900423";
        //    node.AppendChild(element4);

        //    root.AppendChild(node);
        //    doc.Save(@"Config.xml");
        //    Console.Write(doc.OuterXml);

        //}

        ///// <summary>
        ///// 读取XML
        ///// </summary>
        //public List<ConnectionModel> ReadXML()
        //{
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(@"Config.xml");
        //    XmlNode root = doc.SelectSingleNode("Config");

        //    XmlNodeList nodes = root.ChildNodes;
        //    List<ConnectionModel> list = new List<ConnectionModel>();
        //    foreach (XmlNode node in nodes)
        //    {
        //        XmlNodeList ns = node.ChildNodes;
        //        ConnectionModel temp = new ConnectionModel();
        //        temp.Server = ns.Item(0).InnerText;
        //        temp.DataBase = ns.Item(1).InnerText;
        //        temp.UserName = ns.Item(2).InnerText;
        //        temp.Password = ns.Item(3).InnerText;
        //        list.Add(temp);
        //    }

        //    return list;
        //}
    }
}
