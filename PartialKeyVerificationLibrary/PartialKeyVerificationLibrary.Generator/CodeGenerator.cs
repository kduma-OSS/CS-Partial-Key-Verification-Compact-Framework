using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PartialKeyVerification.Generator
{
    public class CodeGenerator
    {
        public bool ValidateUsername { get; set; }
        public KeyDefinition Definition { get; private set; }
        public List<int> VerifiedKeys { get; private set; }
        public List<uint> BlacklistedSerials { get; set; }

        public CodeGenerator(KeyDefinition definition)
        {
            Definition = definition;
            VerifiedKeys = new List<int>();
            BlacklistedSerials = new List<uint>();
        }

        public override string ToString()
        {
            if (VerifiedKeys.Count == 0)
                return "";

            var code = new StringBuilder();

            code.AppendFormat(
                "private static bool ValidateKey({0}string key) {{\r\n", 
                 ValidateUsername ? "string userName, " : ""
            );

            if (BlacklistedSerials.Count != 0)
            {
                code.Append("\tvar seed = PartialKeyValidator.GetSerialNumberFromKey(key);\r\n");
                code.Append("\tvar blacklist = new List<uint> {");

                foreach (var serial in BlacklistedSerials)
                {
                    code.AppendFormat(
                        "{0}, ",
                        serial.ToString(CultureInfo.InvariantCulture)
                    );
                }

                code.Append("};\r\n");
                code.Append("\tif(blacklist.Contains(seed))\r\n");
                code.AppendLine("\t\treturn false;");
                code.AppendLine("\t");
            }

            foreach (var key in VerifiedKeys)
            {
                code.AppendFormat(
                    "\t// Validation for key with index {0}\r\n",
                    key.ToString(CultureInfo.InvariantCulture)
                );
                code.AppendFormat(
                    "\tif(!PartialKeyValidator.ValidateKey(new {0}(), new {1}(), key, {2}, {3}{4}))\r\n",
                    Definition.Checksum.ToString(),
                    Definition.HashFunctions[key].ToString(),
                    key.ToString(CultureInfo.InvariantCulture),
                    Definition.BaseKeys[key].ToString(CultureInfo.InvariantCulture),
                    ValidateUsername ? ", userName" : ""
                );

                code.AppendLine("\t\treturn false;");
                code.AppendLine("\t");
            }
            
            code.AppendLine("\treturn true;");
            code.AppendLine("}");

            return code.ToString();
        }

        public void SetVerifiedKeys(IEnumerable<int> enabledKeys)
        {
            VerifiedKeys.Clear();

            foreach (var key in enabledKeys)
            {
                VerifiedKeys.Add(key);
            }
        }
    }
}