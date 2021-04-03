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
    class KOEncryptionNoEncryption : KOEncryptionBase
    {
        public override string Name()
        {
            return "Not encrypted (plain)";
        }

        public override string Description()
        {
            return "Plain table without encryption.";
        }

        public override void Decode(ref byte[] data)
        {
            return;}

        public override void Encode(FileStream plainStream)
        {
            // noop
        }

        public override bool NewTableStructure()
        {
            return false;
        }
    }
}
