namespace AutoCodeBuilder.WinForm.Frm
{
    partial class Setting
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
            this.radioNoUseSQLHelper = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioROMOSSSQLHelper = new System.Windows.Forms.RadioButton();
            this.radioUseSQLHelper = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioDataTable = new System.Windows.Forms.RadioButton();
            this.radioList = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioNoUseSQLHelper
            // 
            this.radioNoUseSQLHelper.AutoSize = true;
            this.radioNoUseSQLHelper.Location = new System.Drawing.Point(16, 42);
            this.radioNoUseSQLHelper.Name = "radioNoUseSQLHelper";
            this.radioNoUseSQLHelper.Size = new System.Drawing.Size(113, 16);
            this.radioNoUseSQLHelper.TabIndex = 1;
            this.radioNoUseSQLHelper.Text = "不使用SQLHelper";
            this.radioNoUseSQLHelper.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioROMOSSSQLHelper);
            this.groupBox1.Controls.Add(this.radioUseSQLHelper);
            this.groupBox1.Controls.Add(this.radioNoUseSQLHelper);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "底层";
            // 
            // radioROMOSSSQLHelper
            // 
            this.radioROMOSSSQLHelper.AutoSize = true;
            this.radioROMOSSSQLHelper.Location = new System.Drawing.Point(16, 64);
            this.radioROMOSSSQLHelper.Name = "radioROMOSSSQLHelper";
            this.radioROMOSSSQLHelper.Size = new System.Drawing.Size(119, 16);
            this.radioROMOSSSQLHelper.TabIndex = 1;
            this.radioROMOSSSQLHelper.Text = "ROMOSS_SQLHelper";
            this.radioROMOSSSQLHelper.UseVisualStyleBackColor = true;
            // 
            // radioUseSQLHelper
            // 
            this.radioUseSQLHelper.AutoSize = true;
            this.radioUseSQLHelper.Checked = true;
            this.radioUseSQLHelper.Location = new System.Drawing.Point(16, 20);
            this.radioUseSQLHelper.Name = "radioUseSQLHelper";
            this.radioUseSQLHelper.Size = new System.Drawing.Size(101, 16);
            this.radioUseSQLHelper.TabIndex = 1;
            this.radioUseSQLHelper.TabStop = true;
            this.radioUseSQLHelper.Text = "使用SQLHelper";
            this.radioUseSQLHelper.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioDataTable);
            this.groupBox2.Controls.Add(this.radioList);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成类型";
            // 
            // radioDataTable
            // 
            this.radioDataTable.AutoSize = true;
            this.radioDataTable.Location = new System.Drawing.Point(16, 42);
            this.radioDataTable.Name = "radioDataTable";
            this.radioDataTable.Size = new System.Drawing.Size(77, 16);
            this.radioDataTable.TabIndex = 1;
            this.radioDataTable.Text = "DataTable";
            this.radioDataTable.UseVisualStyleBackColor = true;
            // 
            // radioList
            // 
            this.radioList.AutoSize = true;
            this.radioList.Checked = true;
            this.radioList.Location = new System.Drawing.Point(16, 20);
            this.radioList.Name = "radioList";
            this.radioList.Size = new System.Drawing.Size(65, 16);
            this.radioList.TabIndex = 1;
            this.radioList.TabStop = true;
            this.radioList.Text = "List<T>";
            this.radioList.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(88, 201);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 232);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioNoUseSQLHelper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioROMOSSSQLHelper;
        private System.Windows.Forms.RadioButton radioUseSQLHelper;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioDataTable;
        private System.Windows.Forms.RadioButton radioList;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}