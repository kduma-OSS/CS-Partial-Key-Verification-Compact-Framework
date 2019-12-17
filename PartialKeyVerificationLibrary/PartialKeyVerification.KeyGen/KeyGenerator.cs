using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using PartialKeyVerification.Checksum;
using PartialKeyVerification.Generator;
using PartialKeyVerification.Hash;
using System.Runtime.Serialization.Formatters.Binary;

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


            var def = new KeyDefinition
            {
                BaseKeys = new List<uint> {1, 2, 3, 4, 5, 6},
                Checksum = KeyDefinition.ChecksumType.Adler16,
                HashFunctions = new List<KeyDefinition.HashType>
                {
                    KeyDefinition.HashType.Jenkins96,
                    KeyDefinition.HashType.Jenkins96,
                    KeyDefinition.HashType.Jenkins96,
                    KeyDefinition.HashType.Jenkins96,
                    KeyDefinition.HashType.Jenkins96,
                    KeyDefinition.HashType.Jenkins96,
                }
            };

            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;


            var xmlFormat = new XmlSerializer(typeof(KeyDefinition));

            using (Stream fStream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
            xmlFormat.Serialize(fStream, def);
            }
            Console.WriteLine("=> Saved car in XML format!");
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
