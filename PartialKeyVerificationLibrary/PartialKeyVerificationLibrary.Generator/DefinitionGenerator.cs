using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using PartialKeyVerification.Generator;

namespace PartialKeyVerificationLibrary.Generator
{
    public static class DefinitionGenerator
    {
        public static KeyDefinition MakeDefinition(int numberOfKeys)
        {
            var definition = new KeyDefinition();

            var random = new Random();
            definition.Checksum = GetRandomChecksumFunction(random);
            for (var i = 0; i < numberOfKeys; i++)
            {
                definition.BaseKeys.Add(GetRandomUint(random));
                definition.HashFunctions.Add(GetRandomHashFunction(random));
            }

            definition.Spacing = CalculateOptimalSpacing(definition);
            definition.Mask = MakeMask(definition);

            return definition;
        }

        private static string MakeMask(KeyDefinition definition)
        {
            var mask = new StringBuilder(">");
            var generator = new PartialKeyGenerator(definition) { Spacing = 0 };
            var codeLength = generator.Generate(0).Length;

            if (definition.Spacing == 0)
            {
                mask.Append('A', codeLength);

                return mask.ToString();
            }


            while (codeLength > 0)
            {
                mask.Append('A', Math.Min(definition.Spacing, codeLength));

                if (codeLength > definition.Spacing)
                    mask.Append('-');

                codeLength -= definition.Spacing;
            }

            return mask.ToString();
        }

        private static byte CalculateOptimalSpacing(KeyDefinition definition)
        {
            var generator = new PartialKeyGenerator(definition);
            var codeLength = generator.Generate(0).Length;


            byte minimumLength;
            byte maximumLength;

            if (codeLength < 30) {
                minimumLength = 4;
                maximumLength = 9;
            } else if (codeLength < 45) {
                minimumLength = 6;
                maximumLength = 10;
            } else if (codeLength < 60) {
                minimumLength = 8;
                maximumLength = 15;
            } else if (codeLength < 85) {
                minimumLength = 10;
                maximumLength = 20;
            } else {
                return 0;
            }

            var posibilities = new Dictionary<byte, int>();

            for (var optimalLength = minimumLength; optimalLength <= maximumLength; optimalLength++)
            {
                if (codeLength%optimalLength == 0)
                    return optimalLength;

                posibilities.Add(optimalLength, Math.Abs(codeLength % optimalLength - optimalLength));
            }

            var l = posibilities.OrderBy(x => x.Value)
                    .ThenBy(x => x.Key);

            return l.First().Key;
        }

        private static KeyDefinition.HashType GetRandomHashFunction(Random random)
        {
            var values = EnumToArray(new KeyDefinition.HashType());
            KeyDefinition.HashType hashFunction;

            do
            {
                hashFunction = (KeyDefinition.HashType) values.GetValue(random.Next(values.Length));
            } while (hashFunction == KeyDefinition.HashType.Jenkins06);

            return hashFunction;
        }

        private static KeyDefinition.ChecksumType GetRandomChecksumFunction(Random random)
        {
            var values = EnumToArray(new KeyDefinition.ChecksumType());
            return (KeyDefinition.ChecksumType)values.GetValue(random.Next(values.Length));
        }

        private static uint GetRandomUint(Random random)
        {
            var number = random.Next(Int32.MinValue, Int32.MaxValue);
            return (uint)(number + (uint)Int32.MaxValue);
        }

       
        private static Enum[] EnumToArray(Enum enumeration)
        {
            var et = enumeration.GetType();
            var fi = et.GetFields(BindingFlags.Static | BindingFlags.Public);
            var values = new Enum[fi.Length];
            for (var iEnum = 0; iEnum < fi.Length; iEnum++)
            {
                values[iEnum] = (Enum)fi[iEnum].GetValue(enumeration);
            }
            return values;
        }
    }
}
