using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using PartialKeyVerificationLibrary.Generator;

namespace KeyGenerator.Desktop
{
    public partial class CodeGenerator : Form
    {
        internal struct KeyListElement
        {
            internal int Index { get; set; }

            internal uint Key { get; set; }

            public KeyListElement(int index, uint key)
                : this()
            {
                Index = index;
                Key = key;
            }

            public override string ToString()
            {
                return string.Format(
                    "Key {0}: {1}",
                    Index.ToString(CultureInfo.InvariantCulture),
                    Key.ToString(CultureInfo.InvariantCulture)
                );
            }
        }

        public KeyDefinition Definition { get; private set; }
        public PartialKeyVerificationLibrary.Generator.CodeGenerator Generator { get; private set; }

        public CodeGenerator(KeyDefinition definition)
        {
            InitializeComponent();
            Definition = definition;
            Generator = new PartialKeyVerificationLibrary.Generator.CodeGenerator(Definition);
        }

        private void CodeGenerator_Load(object sender, EventArgs e)
        {
            GenerateCode();

            var keys = Definition.BaseKeys.Select((key, index) => new KeyValuePair<int, uint>(index, key));

            foreach (var key in keys)
            {
                verifiedKeysCheckedListBox.Items.Add(new KeyListElement(key.Key, key.Value));
            }
        }

        private void GenerateCode()
        {
            var enabledKeys = verifiedKeysCheckedListBox.CheckedItems
                .Cast<KeyListElement>()
                .Select(element => element.Index);

            Generator.SetVerifiedKeys(enabledKeys);
            Generator.ValidateUsername = true;
//            Generator.BlacklistedSerials = new List<uint> {366791766, 123456};

            generatedCodeTextBox.Text = Generator.ToString();
        }

        private void verifiedKeysCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)(GenerateCode));            
        }
    }
}
