using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace AutoCodeBuilder.Common.Configure
{
    /// <summary>
    /// 配置辅助类
    /// </summary>
    public class ConfigHelper
    {
        string fileName = "";

        public ConfigHelper(string fileName)
        {
            this.fileName = fileName;
        }

        /// <summary>
        /// 获取string类型的配置
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetStringValue(string key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode node;
            XmlElement xElem;
            node = doc.SelectSingleNode("//config");//补充，需要在你的app.config 文件中增加一下，<appSetting> </appSetting>
            xElem = (XmlElement)node.SelectSingleNode("//setting[@key='" + key + "']");
            if (xElem != null)
                return xElem.GetAttribute("value");
            else
                return "";
        }

        /// <summary>
        /// 获取int类型的配置
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetIntValue(string key)
        {
            string value = GetStringValue(key);
            return value.ToInt();
        }

        /// <summary>
        /// 设置配置
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void SetValue(string key, string value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode node = doc.SelectSingleNode(@"//config");
            XmlElement ele = (XmlElement)node.SelectSingleNode(@"//setting[@key='" + key + "']");
            ele.SetAttribute("value", value);
            doc.Save(fileName);

        }

        /// <summary>
        /// 设置配置
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void SetValue(string key, int value)
        {
            SetValue(key, value.ToString());
        }

    }
}
