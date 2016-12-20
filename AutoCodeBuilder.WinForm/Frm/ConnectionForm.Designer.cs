namespace AutoCodeBuilder.WinForm
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbList = new System.Windows.Forms.ComboBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.radWindows = new System.Windows.Forms.RadioButton();
            this.radSQLServer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(197, 225);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "连接";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "用户名：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(70, 49);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(201, 21);
            this.txtPwd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "串：";
            // 
            // cbbList
            // 
            this.cbbList.FormattingEnabled = true;
            this.cbbList.Location = new System.Drawing.Point(71, 12);
            this.cbbList.Name = "cbbList";
            this.cbbList.Size = new System.Drawing.Size(201, 20);
            this.cbbList.TabIndex = 3;
            this.cbbList.SelectedIndexChanged += new System.EventHandler(this.cbbList_SelectedIndexChanged);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(71, 44);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(201, 21);
            this.txtServer.TabIndex = 6;
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(71, 75);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(201, 21);
            this.txtDataBase.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(70, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 21);
            this.txtUserName.TabIndex = 8;
            // 
            // radWindows
            // 
            this.radWindows.AutoSize = true;
            this.radWindows.Checked = true;
            this.radWindows.Location = new System.Drawing.Point(22, 113);
            this.radWindows.Name = "radWindows";
            this.radWindows.Size = new System.Drawing.Size(113, 16);
            this.radWindows.TabIndex = 9;
            this.radWindows.TabStop = true;
            this.radWindows.Text = "Windows身份验证";
            this.radWindows.UseVisualStyleBackColor = true;
            this.radWindows.CheckedChanged += new System.EventHandler(this.radWindows_CheckedChanged);
            // 
            // radSQLServer
            // 
            this.radSQLServer.AutoSize = true;
            this.radSQLServer.Location = new System.Drawing.Point(141, 113);
            this.radSQLServer.Name = "radSQLServer";
            this.radSQLServer.Size = new System.Drawing.Size(131, 16);
            this.radSQLServer.TabIndex = 10;
            this.radSQLServer.Text = "SQL Server身份验证";
            this.radSQLServer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Location = new System.Drawing.Point(2, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 81);
            this.panel1.TabIndex = 11;
            // 
            // ConnectionForm
            // 
            this.AcceptButton = this.btnConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 256);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radSQLServer);
            this.Controls.Add(this.radWindows);
            this.Controls.Add(this.txtDataBase);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.cbbList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnection);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接设置";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbList;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.RadioButton radWindows;
        private System.Windows.Forms.RadioButton radSQLServer;
        private System.Windows.Forms.Panel panel1;
    }
}