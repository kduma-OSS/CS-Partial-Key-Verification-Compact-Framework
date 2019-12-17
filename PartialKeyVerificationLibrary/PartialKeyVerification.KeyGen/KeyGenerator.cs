using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PartialKeyVerification.Checksum;
using PartialKeyVerification.Hash;

namespace PartialKeyVerification.KeyGen
{
    public partial class KeyGenerator : Form
    {
        private readonly PartialKeyGenerator _generator;

        public KeyGenerator()
        {
            InitializeComponent();
            _generator = new PartialKeyGenerator(new Adler16(), new Jenkins96(), new uint[] { 1, 2, 3, 4, 5, 6 }) { Spacing = 6 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ValidateForm())
                GenerateAndSetSeedAndKey();
            else
                ClearSeedAndKey();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateForm())
                GenerateAndSetSeedAndKey();
            else
                ClearSeedAndKey();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearSeedAndKey()
        {
            seedTextBox.Text = "";
            generatedKeyTextBox.Text = "";
        }

        private bool ValidateForm()
        {
            var isValid = !String.IsNullOrEmpty(userNameTextBox.Text);
            errorProvider.SetError(userNameTextBox, isValid ? "" : "User Name is required");
            return isValid;
        }

        private void GenerateAndSetSeedAndKey()
        {
            var seed = PartialKeyValidator.GetSerialNumberFromSeed(userNameTextBox.Text).ToString(CultureInfo.InvariantCulture);
            seedTextBox.Text = seed.ToString(CultureInfo.InvariantCulture);
            generatedKeyTextBox.Text = _generator.Generate(seed);
        }
    }
}
