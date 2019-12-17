namespace PartialKeyVerification.KeyGen
{
    partial class CodeGenerator
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.optionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.verifiedKeysGroupBox = new System.Windows.Forms.GroupBox();
            this.verifiedKeysCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.generatedCodeTextBox = new System.Windows.Forms.TextBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.verifiedKeysGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1062, 502);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1062, 527);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.generatedCodeTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 502);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.optionsGroupBox);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.verifiedKeysGroupBox);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer2.Size = new System.Drawing.Size(224, 502);
            this.splitContainer2.SplitterDistance = 156;
            this.splitContainer2.TabIndex = 0;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.optionsCheckedListBox);
            this.optionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsGroupBox.Location = new System.Drawing.Point(10, 10);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(204, 136);
            this.optionsGroupBox.TabIndex = 2;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Enabled Options";
            // 
            // optionsCheckedListBox
            // 
            this.optionsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsCheckedListBox.Enabled = false;
            this.optionsCheckedListBox.FormattingEnabled = true;
            this.optionsCheckedListBox.IntegralHeight = false;
            this.optionsCheckedListBox.Location = new System.Drawing.Point(3, 16);
            this.optionsCheckedListBox.Name = "optionsCheckedListBox";
            this.optionsCheckedListBox.Size = new System.Drawing.Size(198, 117);
            this.optionsCheckedListBox.TabIndex = 0;
            // 
            // verifiedKeysGroupBox
            // 
            this.verifiedKeysGroupBox.Controls.Add(this.verifiedKeysCheckedListBox);
            this.verifiedKeysGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verifiedKeysGroupBox.Location = new System.Drawing.Point(10, 10);
            this.verifiedKeysGroupBox.Name = "verifiedKeysGroupBox";
            this.verifiedKeysGroupBox.Size = new System.Drawing.Size(204, 322);
            this.verifiedKeysGroupBox.TabIndex = 1;
            this.verifiedKeysGroupBox.TabStop = false;
            this.verifiedKeysGroupBox.Text = "Verified Keys";
            // 
            // verifiedKeysCheckedListBox
            // 
            this.verifiedKeysCheckedListBox.CheckOnClick = true;
            this.verifiedKeysCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verifiedKeysCheckedListBox.FormattingEnabled = true;
            this.verifiedKeysCheckedListBox.IntegralHeight = false;
            this.verifiedKeysCheckedListBox.Location = new System.Drawing.Point(3, 16);
            this.verifiedKeysCheckedListBox.Name = "verifiedKeysCheckedListBox";
            this.verifiedKeysCheckedListBox.Size = new System.Drawing.Size(198, 303);
            this.verifiedKeysCheckedListBox.TabIndex = 0;
            this.verifiedKeysCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.verifiedKeysCheckedListBox_ItemCheck);
            // 
            // generatedCodeTextBox
            // 
            this.generatedCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generatedCodeTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedCodeTextBox.Location = new System.Drawing.Point(0, 0);
            this.generatedCodeTextBox.Multiline = true;
            this.generatedCodeTextBox.Name = "generatedCodeTextBox";
            this.generatedCodeTextBox.ReadOnly = true;
            this.generatedCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.generatedCodeTextBox.Size = new System.Drawing.Size(834, 502);
            this.generatedCodeTextBox.TabIndex = 0;
            this.generatedCodeTextBox.WordWrap = false;
            // 
            // CodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 527);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "CodeGenerator";
            this.Text = "Verification Code Generator";
            this.Load += new System.EventHandler(this.CodeGenerator_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.optionsGroupBox.ResumeLayout(false);
            this.verifiedKeysGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox verifiedKeysGroupBox;
        private System.Windows.Forms.CheckedListBox verifiedKeysCheckedListBox;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.CheckedListBox optionsCheckedListBox;
        private System.Windows.Forms.TextBox generatedCodeTextBox;
    }
}