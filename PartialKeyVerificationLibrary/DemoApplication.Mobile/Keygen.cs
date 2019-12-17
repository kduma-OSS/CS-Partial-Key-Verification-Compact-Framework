using System;
using System.Windows.Forms;
using PartialKeyVerification.Generator;
using PartialKeyVerificationLibrary.Verificator;
using PartialKeyVerificationLibrary.Verificator.Checksum;
using PartialKeyVerificationLibrary.Verificator.Hash;

namespace DemoApplication.Mobile
{
    public partial class Keygen : Form
    {
        private static readonly PartialKeyGenerator PartialKeyGenerator = new PartialKeyGenerator(new Adler16(), new Jenkins96(), new uint[] { 1, 2, 3, 4 }) { Spacing = 6 };

        public Keygen()
        {
            InitializeComponent();
        }

        private void Keygen_Load(object sender, EventArgs e)
        {
            GenerateKeyAndSeed();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            GenerateKeyAndSeed();
        }

        private void GenerateKeyAndSeed()
        {
            keyTextBox.Text = PartialKeyGenerator.Generate(userNameTextBox.Text);
            seedTextBox.Text = PartialKeyValidator.GetSerialNumberFromSeed(userNameTextBox.Text).ToString();
        }

        private void testValidationMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DemoValidator(userNameTextBox.Text, keyTextBox.Text);

            form.ShowDialog();
        }

        private void invalidTestMenuItem_Click(object sender, EventArgs e)
        {
            var key = (new PartialKeyGenerator(new Adler16(), new Jenkins96(), new uint[] { 1, 0, 0, 0 }) { Spacing = 6 })
                .Generate(userNameTextBox.Text);

            var form = new DemoValidator(userNameTextBox.Text, key);

            form.ShowDialog();
        }
    }
}