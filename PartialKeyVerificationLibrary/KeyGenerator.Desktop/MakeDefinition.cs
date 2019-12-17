using System;
using System.Globalization;
using System.Windows.Forms;
using PartialKeyVerification.Generator;
using PartialKeyVerificationLibrary.Generator;

namespace KeyGenerator.Desktop
{
    public partial class MakeDefinition : Form
    {
        public KeyDefinition Definition { get; private set; }

        public string FileName
        {
            get
            {
                return keyDefinitionSaveFileDialog.FileName;
            }
        }

        public MakeDefinition()
        {
            InitializeComponent();
        }

        private void numberOfKeysNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            GenerateDefinition();
        }

        private void MakeDefinition_Load(object sender, EventArgs e)
        {
            GenerateDefinition();
        }

        private void GenerateDefinition()
        {
            Definition = DefinitionGenerator.MakeDefinition((int) numberOfKeysNumericUpDown.Value);
            var generator = new PartialKeyGenerator(Definition);

            sampleCodeTextBox.Text = generator.Generate("");
            codeLengthTextBox.Text = sampleCodeTextBox.Text.Length.ToString(CultureInfo.InvariantCulture);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (keyDefinitionSaveFileDialog.ShowDialog() != DialogResult.OK) return;

            Definition = DefinitionGenerator.MakeDefinition((int)numberOfKeysNumericUpDown.Value);

            DefinitionPersister.SaveToFile(FileName, Definition);

            Close();

            DialogResult = DialogResult.OK;
        }
    }
}
