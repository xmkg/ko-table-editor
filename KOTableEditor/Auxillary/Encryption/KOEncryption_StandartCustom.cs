/**
 * ______________________________________________________
 * This file is part of ko-table-editor project.
 * 
 * @author       Mustafa Kemal Gılor <mustafagilor@gmail.com> (2017)
 * .
 * SPDX-License-Identifier:	MIT
 * ______________________________________________________
 */

using System.IO;

namespace KOTableEditor.Auxillary.Encryption
{
    public sealed class KOEncryptionStandartCustom :KOEncryptionBase
    {

        private readonly string _name;
        private readonly string _desc;
        private readonly ushort _volatileKey, _cipherKey1, _cipherKey2;

        public KOEncryptionStandartCustom(string name, string desc, ushort vkey, ushort ckey1, ushort ckey2)
        {
            _name = name;
            _desc = desc;
            _volatileKey = vkey;
            _cipherKey1 = ckey1;
            _cipherKey2 = ckey2;
        }
        public override string Name()
        {
            return _name;
        }

        public override string Description()
        {
            return _desc;
        }

        public override void Decode(ref byte[] data)
        {
            ushort volatikekey = _volatileKey;
            for (int i = 0; i < data.Length; i++)
            {
                byte rawByte = data[i];
                byte temporaryKey = (byte)((volatikekey & 0xff00) >> 8);
                byte encryptedByte = (byte)(temporaryKey ^ rawByte);
                volatikekey = (ushort)((rawByte + volatikekey) * _cipherKey1+ _cipherKey2);
                data[i] = encryptedByte;
            }
        }

        public override void Encode(FileStream plainStream)
        {
            plainStream.Seek(0, SeekOrigin.Begin);
            var plainByte = plainStream.ReadByte();

            ushort vkey = _volatileKey;

            while (plainByte != -1)
            {
                plainStream.Seek(-1L, SeekOrigin.Current);
                byte rawByte = (byte)(plainByte & 0xFF);
                byte temporaryKey = (byte)((vkey & 0xff00) >> 8);
                byte encryptedByte = (byte)(temporaryKey ^ rawByte);
                vkey = (ushort)((encryptedByte + vkey) * _cipherKey1 + _cipherKey2);
                plainStream.WriteByte(encryptedByte);
                plainByte = plainStream.ReadByte();
            }

            AfterEncode(plainStream);

        }

        public override bool NewTableStructure()
        {
           return false;
        }
    }
}
