﻿using System;
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

namespace PartialKeyVerification.KeyGen
{
    public partial class KeyGenerator : Form
    {
        private PartialKeyGenerator _generator;
        private KeyDefinition _definition;

        public KeyGenerator()
        {
            InitializeComponent();
            _generator = new PartialKeyGenerator(new Adler16(), new Jenkins96(), new uint[] {1, 2});// { Spacing = 6 };
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
