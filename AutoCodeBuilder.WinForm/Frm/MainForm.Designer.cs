namespace AutoCodeBuilder.WinForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tool = new System.Windows.Forms.ToolStrip();
            this.cbbConnection = new System.Windows.Forms.ToolStripComboBox();
            this.btnConnection = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfig = new System.Windows.Forms.ToolStripButton();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPageDAL = new System.Windows.Forms.TabPage();
            this.tabPageProcedure = new System.Windows.Forms.TabPage();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tool.SuspendLayout();
            this.tab.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // tool
            // 
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbbConnection,
            this.btnConnection,
            this.btnRefresh,
            this.btnAbout,
            this.toolStripSeparator1,
            this.btnConfig});
            this.tool.Location = new System.Drawing.Point(0, 0);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(944, 25);
            this.tool.TabIndex = 1;
            this.tool.Text = "toolStrip1";
            // 
            // cbbConnection
            // 
            this.cbbConnection.Name = "cbbConnection";
            this.cbbConnection.Size = new System.Drawing.Size(121, 25);
            // 
            // btnConnection
            // 
            this.btnConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnConnection.Image")));
            this.btnConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(52, 22);
            this.btnConnection.Text = "连接";
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 22);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(23, 22);
            this.btnAbout.Text = "关于";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnConfig
            // 
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(52, 22);
            this.btnConfig.Text = "配置";
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPageDAL);
            this.tab.Controls.Add(this.tabPageProcedure);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 25);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(944, 447);
            this.tab.TabIndex = 0;
            this.tab.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_Selected);
            // 
            // tabPageDAL
            // 
            this.tabPageDAL.Location = new System.Drawing.Point(4, 22);
            this.tabPageDAL.Name = "tabPageDAL";
            this.tabPageDAL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDAL.Size = new System.Drawing.Size(936, 421);
            this.tabPageDAL.TabIndex = 0;
            this.tabPageDAL.Text = "DAL";
            this.tabPageDAL.UseVisualStyleBackColor = true;
            // 
            // tabPageProcedure
            // 
            this.tabPageProcedure.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcedure.Name = "tabPageProcedure";
            this.tabPageProcedure.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcedure.Size = new System.Drawing.Size(936, 421);
            this.tabPageProcedure.TabIndex = 2;
            this.tabPageProcedure.Text = "Procedure";
            this.tabPageProcedure.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.status.Location = new System.Drawing.Point(0, 472);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(944, 22);
            this.status.TabIndex = 3;
            this.status.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(32, 17);
            this.lblStatus.Text = "状态";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 494);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.tool);
            this.Controls.Add(this.status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XGAutoCodeBuilder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            this.tab.ResumeLayout(false);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripComboBox cbbConnection;
        private System.Windows.Forms.ToolStripButton btnConnection;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPageDAL;
        private System.Windows.Forms.TabPage tabPageProcedure;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnConfig;

    }
}