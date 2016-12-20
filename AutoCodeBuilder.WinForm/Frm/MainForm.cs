using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoCodeBuilder.WinForm
{
    public partial class MainForm : Form
    {
        DALForm fmDAL;
        ProcedureForm fmProcedure;
        public MainForm()
        {
            InitializeComponent();

            //初始化DAL窗口
            fmDAL = new DALForm();
            fmDAL.TopLevel = false;
            fmDAL.Visible = true;
            fmDAL.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置为没有边框样式
            fmDAL.Dock = DockStyle.Fill;
            tabPageDAL.Controls.Add(fmDAL);

            //初始化Procedure窗口
            fmProcedure = new ProcedureForm();
            fmProcedure.TopLevel = false;
            fmProcedure.Visible = true;
            fmProcedure.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置为没有边框样式
            fmProcedure.Dock = DockStyle.Fill;
            tabPageProcedure.Controls.Add(fmProcedure);

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectionForm fm = new ConnectionForm();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                fmDAL.Initial();
                fmProcedure.Initial();
            }
            lblStatus.Text = "生成类型：" + Config.CodeType;
        }

        //连接
        private void btnConnection_Click(object sender, EventArgs e)
        {
            ConnectionForm fm = new ConnectionForm();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                fmDAL.Initial();
                fmProcedure.Initial();
            }
        }

        //刷新
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (BLL.Config.ConnectionString == "")
            {
                MessageBox.Show("请先连接数据库","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                fmDAL.Initial();
                fmProcedure.Initial();
            }
        }

        //关于
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © HelloWorld");
        }

        //选择选项卡
        private void tab_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        //配置
        private void btnConfig_Click(object sender, EventArgs e)
        {
            Frm.Setting frm = new Frm.Setting();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //刷新配置
                lblStatus.Text = "生成类型：" + Config.CodeType;
            }
        }
        
    }

}
