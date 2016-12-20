using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoCodeBuilder.WinForm.Frm
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        //确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radioUseSQLHelper.Checked)
            {
                Config.CodeType = "SQLHelper";
            }
            else if (radioNoUseSQLHelper.Checked)
            {
                Config.CodeType = "NoSQLHelper";
            }
            else if (radioROMOSSSQLHelper.Checked)
            {
                Config.CodeType = "ROMOSS";
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadInfo()
        {
            if (Config.CodeType == "SQLHelper")
            {
                radioUseSQLHelper.Checked = true;
            }
            else if (Config.CodeType == "NoSQLHelper")
            {
                radioNoUseSQLHelper.Checked = true;
            }
            else if (Config.CodeType == "ROMOSS")
            {
                radioROMOSSSQLHelper.Checked = true;
            }
        }
    }
}
