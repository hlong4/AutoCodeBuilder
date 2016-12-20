namespace AutoCodeBuilder.WinForm
{
    partial class ProcedureForm
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
            this.richCode = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxProcedure = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richCode
            // 
            this.richCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richCode.Location = new System.Drawing.Point(0, 0);
            this.richCode.Name = "richCode";
            this.richCode.Size = new System.Drawing.Size(442, 330);
            this.richCode.TabIndex = 0;
            this.richCode.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxProcedure);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richCode);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(596, 330);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 1;
            // 
            // listBoxProcedure
            // 
            this.listBoxProcedure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProcedure.FormattingEnabled = true;
            this.listBoxProcedure.ItemHeight = 12;
            this.listBoxProcedure.Location = new System.Drawing.Point(0, 0);
            this.listBoxProcedure.Name = "listBoxProcedure";
            this.listBoxProcedure.Size = new System.Drawing.Size(150, 330);
            this.listBoxProcedure.TabIndex = 1;
            this.listBoxProcedure.DoubleClick += new System.EventHandler(this.listBoxProcedure_DoubleClick);
            // 
            // ProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 330);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProcedureForm";
            this.Text = "ProcedureForm";
            this.Load += new System.EventHandler(this.ProcedureForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richCode;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxProcedure;
    }
}