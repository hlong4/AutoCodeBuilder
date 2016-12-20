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
    public partial class ProcedureForm : Form
    {
        public ProcedureForm()
        {
            InitializeComponent();
        }

        private void ProcedureForm_Load(object sender, EventArgs e)
        {
            //BindProcedureList();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            BindProcedureList();
            richCode.Text = "";
        }

        /// <summary>
        /// 绑定存储过程列表
        /// </summary>
        private void BindProcedureList()
        {
            BLL.SQLServerFrame frame = new BLL.SQLServerFrame();
            List<string> list = frame.GetProcedureList(BLL.Config.ConnectionString);
            listBoxProcedure.DataSource = list;
        }

        //存储过程列表双击
        private void listBoxProcedure_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxProcedure.SelectedValue == null)
                return;

            string procedureName = listBoxProcedure.SelectedValue.ToString();
            CreateCode(procedureName);
        }

        /// <summary>
        /// 生成存储过程代码
        /// </summary>
        /// <param name="procedureName"></param>
        public void CreateCode(string procedureName)
        {
            BLL.Build.BuildProcedure builder = new BLL.Build.BuildProcedure();
            BLL.SQLServerFrame frame = new BLL.SQLServerFrame();
            List<BLL.ProcedureParameter> list = frame.GetParameterOfProcedure(BLL.Config.ConnectionString, procedureName);
            string txt = builder.BuildCode_Procedure(procedureName, list);
            richCode.Text = txt;
        }
    }
}
