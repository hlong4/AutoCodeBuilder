using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AutoCodeBuilder.BLL
{
    /// <summary>
    /// 字符串plus。可以添加带n个tab的字符串，使达到代码缩进。
    /// </summary>
    public class StringPlus
    {
        StringBuilder sb = new StringBuilder();

        public override string ToString()
        {
            return sb.ToString();
        }

        /// <summary>
        /// 添加一行字符，带n个缩进
        /// </summary>
        /// <param name="n">缩进次数</param>
        /// <param name="s">添加的字符</param>
        public void AppendSpaceLine(int n, string s)
        {
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str += "\t";
            }
            str += s;
            sb.AppendLine(str);
        }

        public void AppendLine(string s)
        {
            sb.AppendLine(s);
        }
    }
}
