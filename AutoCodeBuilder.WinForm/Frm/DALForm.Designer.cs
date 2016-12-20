namespace AutoCodeBuilder.WinForm
{
    partial class DALForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DALForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.字段 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.选 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Select_Update = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsKey_Update = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabContent = new System.Windows.Forms.TabControl();
            this.tabModel = new System.Windows.Forms.TabPage();
            this.richModelCode = new System.Windows.Forms.RichTextBox();
            this.tabDAL = new System.Windows.Forms.TabPage();
            this.richDALCode = new System.Windows.Forms.RichTextBox();
            this.tabBLL = new System.Windows.Forms.TabPage();
            this.richBLLCode = new System.Windows.Forms.RichTextBox();
            this.btnCreateCode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkCreateList = new System.Windows.Forms.CheckBox();
            this.checkExist = new System.Windows.Forms.CheckBox();
            this.checkCreateDel = new System.Windows.Forms.CheckBox();
            this.checkCreateModel = new System.Windows.Forms.CheckBox();
            this.checkCreateUpdate = new System.Windows.Forms.CheckBox();
            this.checkCreateAdd = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.checkIdentity = new System.Windows.Forms.CheckBox();
            this.cbbTableList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabContent.SuspendLayout();
            this.tabModel.SuspendLayout();
            this.tabDAL.SuspendLayout();
            this.tabBLL.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.字段,
            this.类型,
            this.选,
            this.Select_Update,
            this.IsKey_Update});
            this.dataGridView1.Location = new System.Drawing.Point(3, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 18;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(339, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // 字段
            // 
            this.字段.DataPropertyName = "Name";
            this.字段.FillWeight = 121.6901F;
            this.字段.HeaderText = "字段";
            this.字段.Name = "字段";
            this.字段.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 类型
            // 
            this.类型.DataPropertyName = "Type";
            this.类型.HeaderText = "类型";
            this.类型.Name = "类型";
            this.类型.Visible = false;
            // 
            // 选
            // 
            this.选.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.选.DataPropertyName = "Key";
            this.选.FillWeight = 95.67633F;
            this.选.HeaderText = "键";
            this.选.Name = "选";
            this.选.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.选.Width = 50;
            // 
            // Select_Update
            // 
            this.Select_Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Select_Update.DataPropertyName = "AddColumn";
            this.Select_Update.FillWeight = 100.4536F;
            this.Select_Update.HeaderText = "添加";
            this.Select_Update.Name = "Select_Update";
            this.Select_Update.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Select_Update.Width = 50;
            // 
            // IsKey_Update
            // 
            this.IsKey_Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsKey_Update.DataPropertyName = "UpdateColumn";
            this.IsKey_Update.FillWeight = 108.1021F;
            this.IsKey_Update.HeaderText = "修改";
            this.IsKey_Update.Name = "IsKey_Update";
            this.IsKey_Update.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsKey_Update.Width = 50;
            // 
            // tabContent
            // 
            this.tabContent.Controls.Add(this.tabModel);
            this.tabContent.Controls.Add(this.tabDAL);
            this.tabContent.Controls.Add(this.tabBLL);
            this.tabContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContent.Location = new System.Drawing.Point(0, 0);
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedIndex = 0;
            this.tabContent.Size = new System.Drawing.Size(603, 447);
            this.tabContent.TabIndex = 2;
            // 
            // tabModel
            // 
            this.tabModel.Controls.Add(this.richModelCode);
            this.tabModel.Location = new System.Drawing.Point(4, 22);
            this.tabModel.Name = "tabModel";
            this.tabModel.Padding = new System.Windows.Forms.Padding(3);
            this.tabModel.Size = new System.Drawing.Size(595, 421);
            this.tabModel.TabIndex = 0;
            this.tabModel.Text = "Model";
            this.tabModel.UseVisualStyleBackColor = true;
            // 
            // richModelCode
            // 
            this.richModelCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richModelCode.Location = new System.Drawing.Point(3, 3);
            this.richModelCode.Name = "richModelCode";
            this.richModelCode.Size = new System.Drawing.Size(589, 415);
            this.richModelCode.TabIndex = 1;
            this.richModelCode.Text = "";
            // 
            // tabDAL
            // 
            this.tabDAL.Controls.Add(this.richDALCode);
            this.tabDAL.Location = new System.Drawing.Point(4, 22);
            this.tabDAL.Name = "tabDAL";
            this.tabDAL.Padding = new System.Windows.Forms.Padding(3);
            this.tabDAL.Size = new System.Drawing.Size(595, 421);
            this.tabDAL.TabIndex = 1;
            this.tabDAL.Text = "DAL";
            this.tabDAL.UseVisualStyleBackColor = true;
            // 
            // richDALCode
            // 
            this.richDALCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richDALCode.Location = new System.Drawing.Point(3, 3);
            this.richDALCode.Name = "richDALCode";
            this.richDALCode.Size = new System.Drawing.Size(589, 415);
            this.richDALCode.TabIndex = 2;
            this.richDALCode.Text = "";
            // 
            // tabBLL
            // 
            this.tabBLL.Controls.Add(this.richBLLCode);
            this.tabBLL.Location = new System.Drawing.Point(4, 22);
            this.tabBLL.Name = "tabBLL";
            this.tabBLL.Padding = new System.Windows.Forms.Padding(3);
            this.tabBLL.Size = new System.Drawing.Size(595, 421);
            this.tabBLL.TabIndex = 2;
            this.tabBLL.Text = "BLL";
            this.tabBLL.UseVisualStyleBackColor = true;
            // 
            // richBLLCode
            // 
            this.richBLLCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richBLLCode.Location = new System.Drawing.Point(3, 3);
            this.richBLLCode.Name = "richBLLCode";
            this.richBLLCode.Size = new System.Drawing.Size(589, 415);
            this.richBLLCode.TabIndex = 2;
            this.richBLLCode.Text = "";
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateCode.BackgroundImage")));
            this.btnCreateCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateCode.Enabled = false;
            this.btnCreateCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreateCode.Location = new System.Drawing.Point(289, 29);
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.Size = new System.Drawing.Size(52, 20);
            this.btnCreateCode.TabIndex = 1;
            this.btnCreateCode.Text = "生成";
            this.btnCreateCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateCode.UseVisualStyleBackColor = true;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkCreateList);
            this.groupBox1.Controls.Add(this.checkExist);
            this.groupBox1.Controls.Add(this.checkCreateDel);
            this.groupBox1.Controls.Add(this.checkCreateModel);
            this.groupBox1.Controls.Add(this.checkCreateUpdate);
            this.groupBox1.Controls.Add(this.checkCreateAdd);
            this.groupBox1.Location = new System.Drawing.Point(3, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 49);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // checkCreateList
            // 
            this.checkCreateList.AutoSize = true;
            this.checkCreateList.Checked = true;
            this.checkCreateList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCreateList.Location = new System.Drawing.Point(6, 20);
            this.checkCreateList.Name = "checkCreateList";
            this.checkCreateList.Size = new System.Drawing.Size(48, 16);
            this.checkCreateList.TabIndex = 5;
            this.checkCreateList.Text = "列表";
            this.checkCreateList.UseVisualStyleBackColor = true;
            // 
            // checkExist
            // 
            this.checkExist.AutoSize = true;
            this.checkExist.Checked = true;
            this.checkExist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkExist.Location = new System.Drawing.Point(276, 19);
            this.checkExist.Name = "checkExist";
            this.checkExist.Size = new System.Drawing.Size(48, 16);
            this.checkExist.TabIndex = 5;
            this.checkExist.Text = "存在";
            this.checkExist.UseVisualStyleBackColor = true;
            // 
            // checkCreateDel
            // 
            this.checkCreateDel.AutoSize = true;
            this.checkCreateDel.Checked = true;
            this.checkCreateDel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCreateDel.Location = new System.Drawing.Point(222, 19);
            this.checkCreateDel.Name = "checkCreateDel";
            this.checkCreateDel.Size = new System.Drawing.Size(48, 16);
            this.checkCreateDel.TabIndex = 5;
            this.checkCreateDel.Text = "删除";
            this.checkCreateDel.UseVisualStyleBackColor = true;
            // 
            // checkCreateModel
            // 
            this.checkCreateModel.AutoSize = true;
            this.checkCreateModel.Checked = true;
            this.checkCreateModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCreateModel.Location = new System.Drawing.Point(60, 20);
            this.checkCreateModel.Name = "checkCreateModel";
            this.checkCreateModel.Size = new System.Drawing.Size(48, 16);
            this.checkCreateModel.TabIndex = 5;
            this.checkCreateModel.Text = "实体";
            this.checkCreateModel.UseVisualStyleBackColor = true;
            // 
            // checkCreateUpdate
            // 
            this.checkCreateUpdate.AutoSize = true;
            this.checkCreateUpdate.Checked = true;
            this.checkCreateUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCreateUpdate.Location = new System.Drawing.Point(168, 20);
            this.checkCreateUpdate.Name = "checkCreateUpdate";
            this.checkCreateUpdate.Size = new System.Drawing.Size(48, 16);
            this.checkCreateUpdate.TabIndex = 5;
            this.checkCreateUpdate.Text = "修改";
            this.checkCreateUpdate.UseVisualStyleBackColor = true;
            // 
            // checkCreateAdd
            // 
            this.checkCreateAdd.AutoSize = true;
            this.checkCreateAdd.Checked = true;
            this.checkCreateAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCreateAdd.Location = new System.Drawing.Point(114, 20);
            this.checkCreateAdd.Name = "checkCreateAdd";
            this.checkCreateAdd.Size = new System.Drawing.Size(48, 16);
            this.checkCreateAdd.TabIndex = 5;
            this.checkCreateAdd.Text = "添加";
            this.checkCreateAdd.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel1.Controls.Add(this.checkIdentity);
            this.splitContainer2.Panel1.Controls.Add(this.btnCreateCode);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.cbbTableList);
            this.splitContainer2.Panel1MinSize = 150;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel2.Controls.Add(this.tabContent);
            this.splitContainer2.Size = new System.Drawing.Size(951, 447);
            this.splitContainer2.SplitterDistance = 344;
            this.splitContainer2.TabIndex = 1;
            // 
            // checkIdentity
            // 
            this.checkIdentity.AutoSize = true;
            this.checkIdentity.Checked = true;
            this.checkIdentity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIdentity.Location = new System.Drawing.Point(12, 32);
            this.checkIdentity.Name = "checkIdentity";
            this.checkIdentity.Size = new System.Drawing.Size(72, 16);
            this.checkIdentity.TabIndex = 4;
            this.checkIdentity.Text = "主键自增";
            this.checkIdentity.UseVisualStyleBackColor = true;
            // 
            // cbbTableList
            // 
            this.cbbTableList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTableList.FormattingEnabled = true;
            this.cbbTableList.Location = new System.Drawing.Point(3, 3);
            this.cbbTableList.Name = "cbbTableList";
            this.cbbTableList.Size = new System.Drawing.Size(339, 20);
            this.cbbTableList.TabIndex = 2;
            this.cbbTableList.SelectedIndexChanged += new System.EventHandler(this.cbbTableList_SelectedIndexChanged);
            // 
            // DALForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 447);
            this.Controls.Add(this.splitContainer2);
            this.Name = "DALForm";
            this.Text = "DALForm";
            this.Load += new System.EventHandler(this.DALForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabContent.ResumeLayout(false);
            this.tabModel.ResumeLayout(false);
            this.tabDAL.ResumeLayout(false);
            this.tabBLL.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richModelCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkCreateList;
        private System.Windows.Forms.CheckBox checkCreateDel;
        private System.Windows.Forms.CheckBox checkCreateModel;
        private System.Windows.Forms.CheckBox checkCreateUpdate;
        private System.Windows.Forms.CheckBox checkCreateAdd;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnCreateCode;
        private System.Windows.Forms.CheckBox checkExist;
        private System.Windows.Forms.TabControl tabContent;
        private System.Windows.Forms.TabPage tabModel;
        private System.Windows.Forms.TabPage tabDAL;
        private System.Windows.Forms.TabPage tabBLL;
        private System.Windows.Forms.RichTextBox richDALCode;
        private System.Windows.Forms.RichTextBox richBLLCode;
        private System.Windows.Forms.ComboBox cbbTableList;
        private System.Windows.Forms.CheckBox checkIdentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn 字段;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select_Update;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsKey_Update;
    }
}