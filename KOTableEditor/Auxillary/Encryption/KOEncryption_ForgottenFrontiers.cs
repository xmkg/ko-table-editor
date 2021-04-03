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
    public sealed class KOEncryptionForgottenFrontiers : KOEncryptionBase
    {
        private ushort _volatileKey = 0x0418;
        private const ushort CipherKey1 = 0x8041;
        private const ushort CipherKey2 = 0x1804;

        public override string Name() { return "Standart Encryption(Forgotten Frontiers)"; }
        public override string Description() { return "Standart encryption used by Knight OnLine client versions 1705 to 1799."; }

        public override void Decode(ref byte[] data)
        {
            _volatileKey = 0x0816;
            for (int i = 0; i < data.Length; i++)
            {
                byte rawByte = data[i];
                byte temporaryKey = (byte)((_volatileKey & 0xff00) >> 8);
                byte encryptedByte = (byte)(temporaryKey ^ rawByte);
                _volatileKey = (ushort)((rawByte + _volatileKey) * CipherKey1 + CipherKey2);
                data[i] = encryptedByte;
            }
        }


        public override void Encode(FileStream plainStream)
        {
            plainStream.Seek(0, SeekOrigin.Begin);
            var plainByte = plainStream.ReadByte();

            _volatileKey = 0x0816;

            while (plainByte != -1)
            {
                plainStream.Seek(-1L, SeekOrigin.Current);
                byte rawByte = (byte)(plainByte & 0xFF);
                byte temporaryKey = (byte)((_volatileKey & 0xff00) >> 8);
                byte encryptedByte = (byte)(temporaryKey ^ rawByte);
                _volatileKey = (ushort)((encryptedByte + _volatileKey) * CipherKey1 + CipherKey2);
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
