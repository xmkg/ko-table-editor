/**
 * ______________________________________________________
 * This file is part of ko-table-editor project.
 * 
 * @author       Mustafa Kemal Gılor <mustafagilor@gmail.com> (2017)
 * .
 * SPDX-License-Identifier:	MIT
 * ______________________________________________________
 */


using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using KOTableEditor.Auxillary.Encryption;

namespace KOTableEditor.Auxillary
{
    public sealed class KOTableFile : IDisposable
    {

        public KOTableFile(FileInfo fi, DataTable tbl, KOEncryptionBase encryption)
        {
            Trace.Assert(fi != null, "KOTableFile() - File information is null!");
            Trace.Assert(tbl != null, "KOTableFile() - DataTable is null!");
            Trace.Assert(encryption != null, "KOTable() - Encryption is null!");

            FileInformation = fi;
            Table = tbl;
            Encryption = encryption;
            Name = FileInformation.Name;
            UnknownInteger = encryption.UnknownInteger;
            UnknownByte = encryption.UnknownByte;
            Padding = encryption.Padding;
            Altered = false;
            SavePath = FileInformation.DirectoryName + "\\" + Name;

        }

        public string Name { get; private set; }
        public string FullName => FileInformation.FullName;
        public FileInfo FileInformation { get; private set; }
        public DataTable Table { get; set; }
        public bool Altered { get; set; }

        private int UnknownInteger { get; set; }
        private byte UnknownByte { get; set; }
        private byte[] Padding = null;

        public KOEncryptionBase Encryption { get; private set; }

        private string SavePath { get; set; }
        public void Dispose()
        {
            Table.Dispose();
        }

        public void SetEncryption(KOEncryptionBase enc)
        {
            Encryption = enc;
        }

        public void SaveAs(string fileName)
        {
            SavePath = fileName;
            Save();
        }

        public void Save()
        {
           using (var fs = new FileStream(SavePath, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
           {
               fs.Seek(0, SeekOrigin.Begin);
                using (var bw = new BinaryWriter(fs))
                {
                     if (Encryption.NewTableStructure())
                     {
                         bw.Write(UnknownInteger);
                         bw.Write(UnknownByte);
                     }

                    #region Write column information

                    bw.Write(BitConverter.GetBytes((int) Table.Columns.Count));
                    foreach (DataColumn column in Table.Columns)
                    {
                        bw.Write((int) ColumnTypes.GetColumnTypeFromFullName(column.DataType.FullName));
                    }

                    #endregion

                    #region Write row information

                    bw.Write(BitConverter.GetBytes((int) Table.Rows.Count));
                    foreach (DataRow row in Table.Rows)
                    {
                        int columnIndex = 0;
                        foreach (var cell in row.ItemArray)
                        {
                            var col = Table.Columns[columnIndex++];

                            switch (col.DataType.FullName)
                            {
                                case "System.UInt64":
                                    bw.Write(BitConverter.GetBytes((UInt64) cell));
                                    break;
                                case "System.Int64":
                                    bw.Write(BitConverter.GetBytes((Int64) cell));
                                    break;
                                case "System.Double":
                                    bw.Write(BitConverter.GetBytes((Double) cell));
                                    break;
                                case "System.Single":
                                    bw.Write(BitConverter.GetBytes((Single) cell));
                                    break;
                                case "System.UInt32":
                                    bw.Write(BitConverter.GetBytes((UInt32) cell));
                                    break;
                                case "System.Int32":
                                    bw.Write(BitConverter.GetBytes((Int32) cell));
                                    break;
                                case "System.UInt16":
                                    bw.Write(BitConverter.GetBytes((UInt16) cell));
                                    break;
                                case "System.Int16":
                                    bw.Write(BitConverter.GetBytes((Int16) cell));
                                    break;
                                case "System.SByte":
                                    bw.Write((SByte) cell);
                                    break;
                                case "System.Byte":
                                    bw.Write((Byte) cell);
                                    break;
                                case "System.String":
                                    string val = cell as string;
                                    if (val == null)
                                        bw.Write((int) 0);
                                    else
                                    {
                                        if (!string.IsNullOrEmpty(val))
                                        {
                                            var chArray = Encoding.GetEncoding("EUC-KR").GetBytes(val);
                                            bw.Write((int)chArray.Length);
                                            foreach (var c in chArray)
                                                bw.Write(c);
                                        }
                                        else
                                            bw.Write((int)0);
                                      
                                   
                                    }
                                    break;
                                default:
                                    Trace.Assert(false, "KOTableFile::Save() - Unknown type.");
                                    break;
                            } /* EOF cell type switch */
                        } /* EOF cell iteration */
                    } /* EOF foreach - datarow */

                    #endregion
                    // new KOEncryptionStandart().Encode(fs);
                    /* debug dump before encode */
                    {
                     
                        
                        
                      //  fs = new FileStream(SavePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                    }

                    /* Encrypt the file. */
                    if (!(Padding == null)) {
                        bw.Write(Padding, 0, Padding.Length);
                    }
                   
                    // fs.Close();
                   //    File.Copy(SavePath, SavePath + "encdump");
                    Encryption.Encode(fs);

                } /* EOF binary yıldırım writer */
            }
        
        }

      
       

    }    /* EOF CLASS */
}   /* EOF NAMESPACE */
