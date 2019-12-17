namespace KeyGenerator.Desktop
{
    partial class KeyGenerator
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
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loadKeyDefinitionButton = new System.Windows.Forms.Button();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.keyDefinitionTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.generatedKeyLabel = new System.Windows.Forms.Label();
            this.seedLabel = new System.Windows.Forms.Label();
            this.keyDefinitionLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.keyDefinitionOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.generatedKeyMaskedTextBox = new System.Windows.Forms.TextBox();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.generatedKeyMaskedTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.loadKeyDefinitionButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.seedTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.keyDefinitionTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.userNameTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.generatedKeyLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.seedLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.keyDefinitionLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.userNameLabel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(515, 202);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(515, 248);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(515, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // loadKeyDefinitionButton
            // 
            this.loadKeyDefinitionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadKeyDefinitionButton.Location = new System.Drawing.Point(478, 12);
            this.loadKeyDefinitionButton.Name = "loadKeyDefinitionButton";
            this.loadKeyDefinitionButton.Size = new System.Drawing.Size(25, 23);
            this.loadKeyDefinitionButton.TabIndex = 5;
            this.loadKeyDefinitionButton.Text = "...";
            this.loadKeyDefinitionButton.UseVisualStyleBackColor = true;
            this.loadKeyDefinitionButton.Click += new System.EventHandler(this.loadKeyDefinitionButton_Click);
            // 
            // seedTextBox
            // 
            this.seedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.seedTextBox.Enabled = false;
            this.errorProvider.SetIconAlignment(this.seedTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.seedTextBox, 5);
            this.seedTextBox.Location = new System.Drawing.Point(108, 66);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.ReadOnly = true;
            this.seedTextBox.Size = new System.Drawing.Size(395, 20);
            this.seedTextBox.TabIndex = 2;
            // 
            // keyDefinitionTextBox
            // 
            this.keyDefinitionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.keyDefinitionTextBox.Enabled = false;
            this.keyDefinitionTextBox.Location = new System.Drawing.Point(108, 14);
            this.keyDefinitionTextBox.Name = "keyDefinitionTextBox";
            this.keyDefinitionTextBox.ReadOnly = true;
            this.keyDefinitionTextBox.Size = new System.Drawing.Size(364, 20);
            this.keyDefinitionTextBox.TabIndex = 1;
            this.keyDefinitionTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.Enabled = false;
            this.errorProvider.SetIconAlignment(this.userNameTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.userNameTextBox, 5);
            this.userNameTextBox.Location = new System.Drawing.Point(108, 40);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(395, 20);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // generatedKeyLabel
            // 
            this.generatedKeyLabel.AutoSize = true;
            this.generatedKeyLabel.Location = new System.Drawing.Point(12, 95);
            this.generatedKeyLabel.Name = "generatedKeyLabel";
            this.generatedKeyLabel.Size = new System.Drawing.Size(81, 13);
            this.generatedKeyLabel.TabIndex = 1;
            this.generatedKeyLabel.Text = "Generated Key:";
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(12, 69);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(35, 13);
            this.seedLabel.TabIndex = 1;
            this.seedLabel.Text = "Seed:";
            // 
            // keyDefinitionLabel
            // 
            this.keyDefinitionLabel.AutoSize = true;
            this.keyDefinitionLabel.Location = new System.Drawing.Point(12, 17);
            this.keyDefinitionLabel.Name = "keyDefinitionLabel";
            this.keyDefinitionLabel.Size = new System.Drawing.Size(75, 13);
            this.keyDefinitionLabel.TabIndex = 1;
            this.keyDefinitionLabel.Text = "Key Definition:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(12, 43);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDefinitionToolStripMenuItem,
            this.openDefinitionToolStripMenuItem,
            this.generateCodeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newDefinitionToolStripMenuItem
            // 
            this.newDefinitionToolStripMenuItem.Name = "newDefinitionToolStripMenuItem";
            this.newDefinitionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.newDefinitionToolStripMenuItem.Text = "&New Definition";
            this.newDefinitionToolStripMenuItem.Click += new System.EventHandler(this.newDefinitionToolStripMenuItem_Click);
            // 
            // openDefinitionToolStripMenuItem
            // 
            this.openDefinitionToolStripMenuItem.Name = "openDefinitionToolStripMenuItem";
            this.openDefinitionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.openDefinitionToolStripMenuItem.Text = "&Open Definition";
            this.openDefinitionToolStripMenuItem.Click += new System.EventHandler(this.loadKeyDefinitionButton_Click);
            // 
            // generateCodeToolStripMenuItem
            // 
            this.generateCodeToolStripMenuItem.Enabled = false;
            this.generateCodeToolStripMenuItem.Name = "generateCodeToolStripMenuItem";
            this.generateCodeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.generateCodeToolStripMenuItem.Text = "&Generate Code";
            this.generateCodeToolStripMenuItem.Click += new System.EventHandler(this.generateCodeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // keyDefinitionOpenFileDialog
            // 
            this.keyDefinitionOpenFileDialog.DefaultExt = "pkvk";
            this.keyDefinitionOpenFileDialog.Filter = "Key Definition Files (.pkvk)|*.pkvk|XML Files (.xml)|*.xml|Text Files (.txt)|*.tx" +
                "t";
            this.keyDefinitionOpenFileDialog.SupportMultiDottedExtensions = true;
            this.keyDefinitionOpenFileDialog.Title = "Select Key Definition File";
            // 
            // generatedKeyMaskedTextBox
            // 
            this.generatedKeyMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.generatedKeyMaskedTextBox.Location = new System.Drawing.Point(108, 95);
            this.generatedKeyMaskedTextBox.Multiline = true;
            this.generatedKeyMaskedTextBox.Name = "generatedKeyMaskedTextBox";
            this.generatedKeyMaskedTextBox.ReadOnly = true;
            this.generatedKeyMaskedTextBox.Size = new System.Drawing.Size(395, 94);
            this.generatedKeyMaskedTextBox.TabIndex = 6;
            // 
            // KeyGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 248);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 2005);
            this.MinimumSize = new System.Drawing.Size(250, 205);
            this.Name = "KeyGenerator";
            this.Text = "PKV Key Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox seedTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label generatedKeyLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button loadKeyDefinitionButton;
        private System.Windows.Forms.TextBox keyDefinitionTextBox;
        private System.Windows.Forms.Label keyDefinitionLabel;
        private System.Windows.Forms.OpenFileDialog keyDefinitionOpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem openDefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCodeToolStripMenuItem;
        private System.Windows.Forms.TextBox generatedKeyMaskedTextBox;
    }
}

