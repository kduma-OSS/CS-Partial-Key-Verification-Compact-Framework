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
            _generator = new PartialKeyGenerator(new Adler16(), new Jenkins96(), new uint[] { 1, 2, 3, 4 }) { Spacing = 6 };
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            GenerateAndSetSeedAndKey();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateAndSetSeedAndKey();
        }

        private void GenerateAndSetSeedAndKey()
        {
            var seed = PartialKeyValidator.GetSerialNumberFromSeed(userNameTextBox.Text).ToString(CultureInfo.InvariantCulture);
            seedTextBox.Text = seed.ToString(CultureInfo.InvariantCulture);
            generatedKeyTextBox.Text = _generator.Generate(seed);
        }
    }
}
