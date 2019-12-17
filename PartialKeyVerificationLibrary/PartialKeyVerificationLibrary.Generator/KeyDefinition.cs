using System;
using System.Collections.Generic;
using System.Linq;
using PartialKeyVerification.Checksum;
using PartialKeyVerification.Hash;

namespace PartialKeyVerification.Generator
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
        public byte Spacing { get; set; }
        public string Mask { get; set; }

        public KeyDefinition()
        {
            BaseKeys = new List<uint>();
            HashFunctions = new List<HashType>();
        }

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

        internal uint[] GetBaseKeys()
        {
            return BaseKeys.ToArray();
        }

        public IChecksum16 GetChecksum()
        {
            switch (Checksum)
            {
                case ChecksumType.Adler16:
                    return new Adler16();

                case ChecksumType.Crc16:
                    return new Crc16();

                case ChecksumType.CrcCcitt:
                    return new CrcCcitt();
                
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public List<IHash> GetHashFunctions()
        {
            return HashFunctions.Select<HashType, IHash>(type =>
            {
                switch (type)
                {
                    case HashType.Crc32:
                        return new Crc32();
                    case HashType.Fnv1A:
                        return new Fnv1A();
                    case HashType.GeneralizedCrc:
                        return new GeneralizedCrc();
                    case HashType.Jenkins06:
                        throw new ArgumentOutOfRangeException("type");
                        //return new Jenkins06(0);
                    case HashType.Jenkins96:
                        return new Jenkins96();
                    case HashType.OneAtATime:
                        return new OneAtATime();
                    case HashType.SuperFast:
                        return new SuperFast();
                    default:
                        throw new ArgumentOutOfRangeException("type");
                }
            }).ToList();
        }
    }
}