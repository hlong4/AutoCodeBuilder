using AutoCodeBuilder.Common.Configure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.WinForm
{
    /// <summary>
    /// 配置
    /// </summary>
    public class Config
    {
        static string filePath = "Config.xml";
        static ConfigHelper helper = new ConfigHelper(filePath);

        /// <summary>
        /// 初始配置
        /// </summary>
        public static void Init()
        {
            //存在文件，跳过创建初始配置
            if (System.IO.File.Exists(filePath))
                return;

            //初始配置
            ConnectionConfig initConfig = new ConnectionConfig(filePath,
                new List<ConnectionModel>() { 
                    new ConnectionModel{Server=".",DataBaseName="main_db",VerifyType="0",UserName="",Password=""},
                    new ConnectionModel{Server="192.168.60.95",DataBaseName="main_db",VerifyType="1",UserName="main_user",Password="webuser"}
                });

            initConfig.CreateHandle();
        }

        //public static string Url
        //{
        //    get { return helper.GetStringValue("Url"); }
        //    set { helper.SetValue("Url", value); }
        //}

        public static string CodeType = "ROMOSS";
    }
}
