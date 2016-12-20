using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoCodeBuilder.WinForm
{
    /// <summary>
    /// 连接窗口
    /// </summary>
    public partial class ConnectionForm : Form
    {
        List<Common.Configure.ConnectionModel> list;
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            LoadDefault();

            //BLL.ConnectionDAL dal = new BLL.ConnectionDAL();
            //list = dal.GetList();

            //foreach (var li in list)
            //{
            //    cbbList.Items.Add(string.Format("{0}/{1}/{2}", li.Server, li.DataBase, li.UserName, li.Password));
            //}
            Common.Configure.ConnectionConfigHelper bll = new Common.Configure.ConnectionConfigHelper();
            list = bll.GetList();
            foreach (var li in list)
            {
                cbbList.Items.Add(string.Format("{0}/{1}/{2}", li.Server, li.DataBaseName, li.VerifyType));
            }
            if (cbbList.Items.Count > 0)
            {
                cbbList.SelectedIndex = 0;
            }
        }
        //连接
        private void btnConnection_Click(object sender, EventArgs e)
        {
            string strConnection = GetConnectionString();
            BLL.Config.ConnectionString = strConnection;

            if (BLL.ConfigBLL.ConnectionTest())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("连接失败，请检查信息！");
            }
        }
        /// <summary>
        /// 拼接连接字符串
        /// </summary>
        /// <returns></returns>
        private string GetConnectionString()
        {
            string strServer = txtServer.Text.Trim();
            string strDataBase = txtDataBase.Text.Trim();
            string strUserName = txtUserName.Text.Trim();
            string strPwd = txtPwd.Text.Trim();
            bool isWindows = radWindows.Checked;
            string strConnection = "";
            if (isWindows)
            {
                strConnection = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", strServer, strDataBase);
            }
            else
            {
                strConnection = string.Format("server={0};database={1};uid={2};pwd={3};", strServer, strDataBase, strUserName, strPwd);
            }

            return strConnection;
        }

        private void cbbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbbList.SelectedIndex;
            txtServer.Text = list[index].Server;
            txtDataBase.Text = list[index].DataBaseName;
            if (list[index].VerifyType == "0")
            {
                radWindows.Checked = true;
                txtUserName.Text = "";
                txtPwd.Text = "";
            }
            else
            {
                radSQLServer.Checked = true;
                txtUserName.Text = list[index].UserName;
                txtPwd.Text = list[index].Password;
            }
        }

        //windows身份验证
        private void radWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (radWindows.Checked)
            {
                panel1.Enabled = false;
            }
            else
            {
                panel1.Enabled = true;
            }
        }

        /// <summary>
        /// 默认设置
        /// </summary>
        private void LoadDefault()
        {
            radWindows.Checked = true;
            panel1.Enabled = false;
        }

        //private void cbbServer_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbbDataBase.Items.Clear();
        //    string server = cbbServer.SelectedItem.ToString();
        //    foreach (var li in list.Where(x=>x.Server==server).Select(x=>x.DataBase).Distinct().ToList())
        //    {
        //        cbbDataBase.Items.Add(li);
        //    }
        //}

        //private void cbbDataBase_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbbUserName.Items.Clear();
        //    string dataBase = cbbDataBase.SelectedItem.ToString();
        //    foreach (var li in list.Where(x => x.DataBase == dataBase).Select(x => x.UserName).Distinct().ToList())
        //    {
        //        cbbUserName.Items.Add(li);
        //    }
        //}

        //private void cbbUserName_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
        //}
    }
}
