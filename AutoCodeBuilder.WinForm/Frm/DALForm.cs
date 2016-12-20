using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace AutoCodeBuilder.WinForm
{
    public partial class DALForm : Form
    {
        string selectTableName = "";
        public DALForm()
        {
            InitializeComponent();
        }

        private void DALForm_Load(object sender, EventArgs e)
        {
            //BindTableList();
            
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            BindTableList();
            List<Column> list = new List<Column>();
            dataGridView1.DataSource = list;
            richModelCode.Text = "";
            btnCreateCode.Enabled = true;
        }

        /// <summary>
        /// 绑定表名列表
        /// </summary>
        private void BindTableList()
        {
            BLL.SQLServerFrame frame = new BLL.SQLServerFrame();
            string strConnection = BLL.Config.ConnectionString;
            DataTable dt = frame.GetTables(strConnection);
            List<string> list = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i]["table_name"].ToString());
            }
            list.Sort();
            list.Insert(0, "");
            cbbTableList.DataSource = list;

            //DataView dv = new DataView(dt);
            //dv.Sort = "table_name";

            //cbbTableList.DisplayMember = "table_name";
            //cbbTableList.ValueMember = "table_name";
            //cbbTableList.DataSource = dv;
        }

        //生成
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            richModelCode.Text = BuildModel();
            richDALCode.Text = BuildDAL();
            richBLLCode.Text = BuildBLL();
        }

        //下拉列表选项改变时
        private void cbbTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //选空数据跳过
            if (cbbTableList.SelectedValue.ToString() == "")
                return;

            string tableName = cbbTableList.SelectedValue.ToString();
            selectTableName = tableName;

            BLL.SQLServerFrame frame = new BLL.SQLServerFrame();
            string strConnection = BLL.Config.ConnectionString;
            DataSet ds = frame.GetColumnField2(strConnection, tableName);
            DataTable dt = ds.Tables[0];
            List<Column> list = new List<Column>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Column { Name = dr[0].ToString(), Type = dr[1].ToString(), Key = false, AddColumn = true, UpdateColumn = true });
            }
            list[0].Key = true;//默认第一个字段为主键
            list[0].UpdateColumn = false;//默认主键不修改

            if (checkIdentity.Checked)//主键自增
            {
                list[0].AddColumn = false;
                list[0].UpdateColumn = false;
            }


            dataGridView1.DataSource = list;
        }

        /// <summary>
        /// 模型
        /// </summary>
        private string BuildModel()
        {
            List<BLL.Column> columnList = GetAllColumnList();
            string txt = "";
            BLL.Build.BuildModel builder = new BLL.Build.BuildModel();
            txt = builder.BuildCode_Model(selectTableName, columnList);
            return txt;
        }

        /// <summary>
        /// DAL
        /// </summary>
        /// <returns></returns>
        private string BuildDAL()
        {
            StringBuilder sb = new StringBuilder();
            //BLL.Build.IBuildDAL builder = new BLL.Build.BuildDAL();
            //BLL.Build.IBuildDAL builder = new BLL.Build.BuildDAL_NoSQLHelper();
            BLL.Build.IBuildDAL builder = BLL.Build.BuildDALFactory.CreateBuildDAL(Config.CodeType);
            List<BLL.Column> keyColumnList = GetKeyColumnList();
            string temp = "";

            if (checkCreateList.Checked)
            {
                List<BLL.Column> columnList = GetAllColumnList();
                temp = builder.BuildCode_GetList(selectTableName, columnList);
                sb.AppendLine(temp);
            }
            if (checkCreateModel.Checked)
            {
                List<BLL.Column> columnList = GetAllColumnList();
                temp = builder.BuildCode_GetModel(selectTableName, columnList, keyColumnList);
                //temp += "\n";
                //temp += builder.BuildCode_GetModelTable(selectTableName, columnList, keyColumnList);
                sb.AppendLine(temp);
            }
            if (checkCreateAdd.Checked)
            {
                bool isIdentity = checkIdentity.Checked;//是否自增
                List<BLL.Column> columnListx = GetSelectedColumnList(3);
                temp = builder.BuildCode_Add(selectTableName, columnListx, isIdentity);
                sb.AppendLine(temp);
            }
            if (checkCreateUpdate.Checked)
            {
                List<BLL.Column> columnListx = GetSelectedColumnList(4);
                temp = builder.BuildCode_Update(selectTableName, columnListx, keyColumnList);
                sb.AppendLine(temp);
            }
            if (checkCreateDel.Checked)
            {
                temp = builder.BuildCode_Delete(selectTableName, keyColumnList);
                sb.AppendLine(temp);
            }
            if (checkExist.Checked)
            {
                temp = builder.BuildCode_Exist(selectTableName, keyColumnList);
                sb.AppendLine(temp);
            }
            return sb.ToString();
        }

        /// <summary>
        /// BLL
        /// </summary>
        /// <returns></returns>
        private string BuildBLL()
        {
            StringBuilder sb = new StringBuilder();
            BLL.Build.IBuildBLL builder;
            builder = new BLL.Build.BuildBLL();
            List<BLL.Column> keyColumnList = GetKeyColumnList();
            string temp = "";

            if (checkCreateList.Checked)
            {
                temp = builder.BuildCode_GetList(selectTableName);
                sb.AppendLine(temp);
            }
            if (checkCreateModel.Checked)
            {
                temp = builder.BuildCode_GetModel(selectTableName, keyColumnList);
                sb.AppendLine(temp);
            }
            if (checkCreateAdd.Checked)
            {
                temp = builder.BuildCode_Add(selectTableName);
                sb.AppendLine(temp);
            }
            if (checkCreateUpdate.Checked)
            {
                temp = builder.BuildCode_Update(selectTableName);
                sb.AppendLine(temp);
            }
            if (checkCreateDel.Checked)
            {
                temp = builder.BuildCode_Delete(selectTableName, keyColumnList);
                sb.AppendLine(temp);
            }
            if (checkExist.Checked)
            {
                temp = builder.BuildCode_Exist(selectTableName, keyColumnList);
                sb.AppendLine(temp);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取key列
        /// </summary>
        /// <returns></returns>
        public List<BLL.Column> GetKeyColumnList()
        {
            return GetSelectedColumnList(2);
        }
        /// <summary>
        /// 获取所选的列
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public List<BLL.Column> GetSelectedColumnList(int index)
        {
            List<BLL.Column> columnList = new List<BLL.Column>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[index];
                if ((Boolean)checkCell.Value)
                {
                    BLL.Column column = new BLL.Column
                    {
                        Name = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                        Type = dataGridView1.Rows[i].Cells[1].Value.ToString()
                    };
                    columnList.Add(column);
                }

            }
            return columnList;
        }
        //所有字段列
        public List<BLL.Column> GetAllColumnList()
        {
            List<BLL.Column> columnList = new List<BLL.Column>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                BLL.Column column = new BLL.Column
                {
                    Name = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    Type = dataGridView1.Rows[i].Cells[1].Value.ToString()
                };
                columnList.Add(column);

            }
            return columnList;
        }

        

        
    }

    public class Column 
    {
        /// <summary>
        /// 字段名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 键
        /// </summary>
        public bool Key { get; set; }
        /// <summary>
        /// 要添加的字段
        /// </summary>
        public bool AddColumn { get; set; }
        /// <summary>
        /// 要修改的字段
        /// </summary>
        public bool UpdateColumn { get; set; }
    }
}
