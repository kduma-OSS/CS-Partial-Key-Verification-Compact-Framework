using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PartialKeyVerification.Generator
{
    static public class DefinitionPersister
    {
        static public void SaveToFile(string file, KeyDefinition definition)
        {
            var xmlFormat = new XmlSerializer(typeof(KeyDefinition));

            using (Stream fStream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, definition);
            }
        }

        public static KeyDefinition LoadFromFile(string file)
        {
            var xmlFormat = new XmlSerializer(typeof(KeyDefinition));

            using (Stream fStream = File.OpenRead(file))
            {
                return (KeyDefinition)xmlFormat.Deserialize(fStream);
            }
        }
    }
}
