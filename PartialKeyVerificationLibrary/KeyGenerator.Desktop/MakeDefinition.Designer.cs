namespace PartialKeyVerification.KeyGen
{
    partial class MakeDefinition
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
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.numberOfKeysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfKeysLabel = new System.Windows.Forms.Label();
            this.codeLengthTextBox = new System.Windows.Forms.TextBox();
            this.sampleCodeTextBox = new System.Windows.Forms.TextBox();
            this.codeLengthLabel = new System.Windows.Forms.Label();
            this.sampleCodeLabel = new System.Windows.Forms.Label();
            this.keyDefinitionSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfKeysNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(296, 149);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create";
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(215, 149);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // numberOfKeysNumericUpDown
            // 
            this.numberOfKeysNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfKeysNumericUpDown.Location = new System.Drawing.Point(155, 12);
            this.numberOfKeysNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numberOfKeysNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfKeysNumericUpDown.Name = "numberOfKeysNumericUpDown";
            this.numberOfKeysNumericUpDown.Size = new System.Drawing.Size(216, 20);
            this.numberOfKeysNumericUpDown.TabIndex = 2;
            this.numberOfKeysNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfKeysNumericUpDown.ValueChanged += new System.EventHandler(this.numberOfKeysNumericUpDown_ValueChanged);
            // 
            // numberOfKeysLabel
            // 
            this.numberOfKeysLabel.AutoSize = true;
            this.numberOfKeysLabel.Location = new System.Drawing.Point(12, 14);
            this.numberOfKeysLabel.Name = "numberOfKeysLabel";
            this.numberOfKeysLabel.Size = new System.Drawing.Size(135, 13);
            this.numberOfKeysLabel.TabIndex = 3;
            this.numberOfKeysLabel.Text = "Number of generated keys:";
            // 
            // codeLengthTextBox
            // 
            this.codeLengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.codeLengthTextBox.Location = new System.Drawing.Point(155, 39);
            this.codeLengthTextBox.Name = "codeLengthTextBox";
            this.codeLengthTextBox.ReadOnly = true;
            this.codeLengthTextBox.Size = new System.Drawing.Size(216, 20);
            this.codeLengthTextBox.TabIndex = 4;
            // 
            // sampleCodeTextBox
            // 
            this.sampleCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleCodeTextBox.Location = new System.Drawing.Point(155, 65);
            this.sampleCodeTextBox.Multiline = true;
            this.sampleCodeTextBox.Name = "sampleCodeTextBox";
            this.sampleCodeTextBox.ReadOnly = true;
            this.sampleCodeTextBox.Size = new System.Drawing.Size(216, 78);
            this.sampleCodeTextBox.TabIndex = 4;
            // 
            // codeLengthLabel
            // 
            this.codeLengthLabel.AutoSize = true;
            this.codeLengthLabel.Location = new System.Drawing.Point(12, 42);
            this.codeLengthLabel.Name = "codeLengthLabel";
            this.codeLengthLabel.Size = new System.Drawing.Size(71, 13);
            this.codeLengthLabel.TabIndex = 3;
            this.codeLengthLabel.Text = "Code Length:";
            // 
            // sampleCodeLabel
            // 
            this.sampleCodeLabel.AutoSize = true;
            this.sampleCodeLabel.Location = new System.Drawing.Point(12, 68);
            this.sampleCodeLabel.Name = "sampleCodeLabel";
            this.sampleCodeLabel.Size = new System.Drawing.Size(73, 13);
            this.sampleCodeLabel.TabIndex = 3;
            this.sampleCodeLabel.Text = "Sample Code:";
            // 
            // keyDefinitionSaveFileDialog
            // 
            this.keyDefinitionSaveFileDialog.DefaultExt = "pkvk";
            this.keyDefinitionSaveFileDialog.Filter = "Key Definition Files (.pkvk)|*.pkvk|XML Files (.xml)|*.xml|Text Files (.txt)|*.tx" +
                "t";
            this.keyDefinitionSaveFileDialog.Title = "Save Key Definition File";
            // 
            // MakeDefinition
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(383, 184);
            this.Controls.Add(this.sampleCodeTextBox);
            this.Controls.Add(this.codeLengthTextBox);
            this.Controls.Add(this.sampleCodeLabel);
            this.Controls.Add(this.codeLengthLabel);
            this.Controls.Add(this.numberOfKeysLabel);
            this.Controls.Add(this.numberOfKeysNumericUpDown);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(831, 555);
            this.MinimumSize = new System.Drawing.Size(337, 154);
            this.Name = "MakeDefinition";
            this.Text = "Generate New Key Definition...";
            this.Load += new System.EventHandler(this.MakeDefinition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfKeysNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown numberOfKeysNumericUpDown;
        private System.Windows.Forms.Label numberOfKeysLabel;
        private System.Windows.Forms.TextBox codeLengthTextBox;
        private System.Windows.Forms.TextBox sampleCodeTextBox;
        private System.Windows.Forms.Label codeLengthLabel;
        private System.Windows.Forms.Label sampleCodeLabel;
        private System.Windows.Forms.SaveFileDialog keyDefinitionSaveFileDialog;
    }
}