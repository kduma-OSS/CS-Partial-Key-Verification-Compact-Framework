using System;
using System.Globalization;
using System.Windows.Forms;
using PartialKeyVerification.Generator;
using PartialKeyVerificationLibrary.Generator;
using PartialKeyVerificationLibrary.Verificator;
using CodeGenerator = KeyGenerator.Desktop.CodeGenerator;

namespace KeyGenerator.Desktop
{
    public partial class KeyGenerator : Form
    {
        private PartialKeyGenerator _generator;
        private KeyDefinition _definition;
        private readonly string _fileToOpen;

        public KeyGenerator()
        {
            InitializeComponent();
        }

        public KeyGenerator(string fileToOpen)
        {
            InitializeComponent();
            _fileToOpen = fileToOpen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_fileToOpen))
                LoadDefinitionFile(_fileToOpen);

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

        private void loadKeyDefinitionButton_Click(object sender, EventArgs e)
        {
            if (keyDefinitionOpenFileDialog.ShowDialog() != DialogResult.OK) return;

            LoadDefinitionFile(keyDefinitionOpenFileDialog.FileName);
        }

        private void generateCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new CodeGenerator(_definition))
            {
                dialog.ShowDialog();
            }
        }

        private void newDefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new MakeDefinition())
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                LoadDefinitionFile(dialog.FileName);
            }
        }

        private void ClearSeedAndKey()
        {
            seedTextBox.Text = "";
            generatedKeyMaskedTextBox.Text = "";
            generatedKeyMaskedTextBox.Mask = "";
        }

        private bool ValidateForm()
        {
            var isValid = _definition!=null && !String.IsNullOrEmpty(userNameTextBox.Text);
            if (isValid || _definition == null)
                errorProvider.SetError(userNameTextBox, "");
            else
                errorProvider.SetError(userNameTextBox, "User Name is required");
            return isValid;
        }

        private void GenerateAndSetSeedAndKey()
        {
            var seed = PartialKeyValidator.GetSerialNumberFromSeed(userNameTextBox.Text);
            seedTextBox.Text = seed.ToString(CultureInfo.InvariantCulture);
            generatedKeyMaskedTextBox.Mask = _definition.Mask;
            generatedKeyMaskedTextBox.Text = _generator.Generate(seed);
        }

        private void LoadDefinitionFile(string fileName)
        {
            _definition = DefinitionPersister.LoadFromFile(fileName);
            _generator = new PartialKeyGenerator(_definition);
            keyDefinitionTextBox.Text = fileName;
            userNameTextBox.Enabled = true;
            keyDefinitionTextBox.Enabled = true;
            seedTextBox.Enabled = true;
            generatedKeyMaskedTextBox.Enabled = true;
            generateCodeToolStripMenuItem.Enabled = true;
            userNameTextBox.Focus();
        }
    }
}
