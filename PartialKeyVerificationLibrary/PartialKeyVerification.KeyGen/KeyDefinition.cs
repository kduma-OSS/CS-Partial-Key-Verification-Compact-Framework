using System;
using System.Collections.Generic;
using PartialKeyVerification.Checksum;
using PartialKeyVerification.Hash;

namespace PartialKeyVerification.KeyGen
{
    [Serializable]
    public class KeyDefinition
    {
        public enum ChecksumType
        {
            Adler16, Crc16, CrcCcitt
        }

        public enum HashType
        {
            Crc32, Fnv1A, GeneralizedCrc, Jenkins06, Jenkins96, OneAtATime, SuperFast
        }

        public List<uint> BaseKeys { get; set; }
        public ChecksumType Checksum { get; set; }
        public List<HashType> HashFunctions { get; set; }

        public KeyDefinition()
        {}

//        public KeyDefinition(IChecksum16 checksum, IHash hash, IEnumerable<uint> baseKeys)
//            : this(checksum, new[] {hash}, baseKeys)
//        {
//        }
//
//        public KeyDefinition(IChecksum16 checksum, IEnumerable<IHash> hashFunctions, IEnumerable<uint> baseKeys)
//        {
//            if (checksum == null)
//            {
//                throw new ArgumentNullException("checksum");
//            }
//            if (hashFunctions == null)
//            {
//                throw new ArgumentNullException("hashFunctions");
//            }
//            if (baseKeys == null)
//            {
//                throw new ArgumentNullException("baseKeys");
//            }
//
//            Checksum = checksum;
//            BaseKeys = new List<uint>();
//            HashFunctions = new List<IHash>();
//
//            foreach (var hash in hashFunctions)
//            {
//                HashFunctions.Add(hash);
//            }
//
//            foreach (var key in baseKeys)
//            {
//                BaseKeys.Add(key);
//            }
//        }
    }
}