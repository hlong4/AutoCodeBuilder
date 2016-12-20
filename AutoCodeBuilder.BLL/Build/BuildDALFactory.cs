using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCodeBuilder.BLL.Build
{
    public class BuildDALFactory
    {
        /// <summary>
        /// 创建BuildDAL对象
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IBuildDAL CreateBuildDAL(string type)
        {
            IBuildDAL buildDAL = null;
            switch (type)
            {
                case "ROMOSS":
                    buildDAL = new BuildDAL_ROMOSS();
                    break;
                case "NoSQLHelper":
                    buildDAL = new BuildDAL_NoSQLHelper();
                    break;
                default:
                    buildDAL = new BuildDAL_Null();
                    break;
            }
            return buildDAL;
        }
    }
}
