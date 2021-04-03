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

namespace KOTableEditor.Auxillary.Encryption
{
    /* Base encryption class */
    internal static class ColumnTypes
    {
        public const int SignedByte = 1;
        public const int UnsignedByte = 2;
        public const int SignedShort = 3;
        public const int UnsignedShort = 4;
        public const int SignedInteger = 5;
        public const int UnsignedInteger = 6;
        public const int String = 7;
        public const int Float = 8;
        public const int Double = 9;
        public const int SignedLong = 10;
        public const int UnsignedLong = 11;

        public static string GetColumnTypeNameFromFullName(string name)
        {
            switch (name)
            {
                case "System.UInt64":
                    return "(unsigned long)";
                case "System.Int64":
                    return "(signed long)";
                case "System.Double":
                    return "(double)";
                case "System.Single":
                    return "(float)";
                case "System.UInt32":
                    return "(unsigned integer)";
                case "System.Int32":
                    return "(signed integer)";
                case "System.UInt16":
                    return "(unsigned short)";
                case "System.Int16":
                    return "(signed short)";
                case "System.SByte":
                    return "(signed byte)";
                case "System.Byte":
                    return "(unsigned byte)";
                case "System.String":
                    return "(string)";
                default:
                    return "(unknown)";
            }
        }

        public static int GetColumnTypeFromFullName(string name)
        {
            switch (name)
            {
                case "System.UInt64":
                    return UnsignedLong;
                case "System.Int64":
                   return SignedLong;
                case "System.Double":
                    return Double;
                case "System.Single":
                    return Float;
                case "System.UInt32":
                    return UnsignedInteger;
                case "System.Int32":
                    return SignedInteger;
                case "System.UInt16":
                    return UnsignedShort;
                case "System.Int16":
                    return SignedShort;
                case "System.SByte":
                    return SignedByte;
                case "System.Byte":
                    return UnsignedByte;
                case "System.String":
                    return String;
                default:
                    Trace.Assert(false, "GetColumnTypeFromFullName() - Unknown type.");
                    return -1;
            }
        }
    }

    public abstract class KOEncryptionBase
    {
        public static char[] SignatureOfAuthor = { 'E', 'D', 'I', 'T', 'E', 'D', 'W', 'I', 'T', 'H', 'P', 'E', 'N', 'T', 'A', 'G', 'R', 'A', 'M', 'T', 'B', 'L', 'E', 'D', 'I', 'T', 'O', 'R', 'H', 'T', 'T', 'P', 'S', ':', '\\', '\\', 'W', 'W', 'W', '.', 'K', 'O', 'D', 'E', 'V', 'E', 'L', 'O', 'P', 'E', 'R', 'S', '.', 'C', 'O', 'M' };


        public abstract String Name();
        public abstract String Description();
        public abstract void Decode(ref byte[] data);
        public abstract void Encode(FileStream plainStream);
        public void AfterEncode(FileStream plainStream)
        {
            foreach (byte t in SignatureOfAuthor)
                plainStream.WriteByte(t);

        }
        public abstract bool NewTableStructure();
        public int UnknownInteger { get; private set; }
        public byte UnknownByte { get; private set; }
        public byte[] Padding = null;
 
        /* 
         * Decodes the given file, and returns byte array of decoded file. 
         */
        public byte[] DecodeFileIntoByteArray(string fileName)
        {/* Load the file */
            var buffer = File.ReadAllBytes(fileName);
            Decode(ref buffer);
            if (NewTableStructure())
            {
                Trace.WriteLine(string.Format("Integer : {0} , Byte {1}", BitConverter.ToInt32(buffer, 0), buffer[4]));
            }
            return buffer;


        }

        private  DataTable GetTableFromDecodedBytes(byte[] fileData, string tableName)
        {
            using (var ms = new MemoryStream(fileData))
            {
                using (var br = new BinaryReader(ms))
                {
                    #region Read column information

                    if (NewTableStructure())
                    {
                        UnknownInteger = br.ReadInt32();
                        UnknownByte = br.ReadByte();
                    }

                    var columnCount = br.ReadInt32();
                    if (columnCount <= 0)
                        throw new Exception("Invalid column count value. Probably the specified table is corrupt.");
                    var columnData = new int[columnCount];
                    var _temporaryTable = new DataTable(tableName);

                    for (var i = 0; i < columnCount; i++)
                    {
                        var columnType = br.ReadInt32();
                        columnData[i] = columnType;
                        string columnHeader = "";
                        Type _columnType = typeof(void);

                        #region Determine column type
                        switch (columnType)
                        {
                            case ColumnTypes.SignedByte:
                                _columnType = typeof(sbyte);
                                columnHeader += "(signed byte)";
                                break;case ColumnTypes.UnsignedByte:
                                _columnType = typeof(byte);
                                columnHeader += "(unsigned byte)";
                                break;
                            case ColumnTypes.SignedShort:
                                _columnType = typeof(short);
                                columnHeader += "(signed short)";
                                break;
                            case ColumnTypes.UnsignedShort:
                                _columnType = typeof(ushort);
                                columnHeader += "(unsigned short)";
                                break;
                            case ColumnTypes.SignedInteger:
                                _columnType = typeof(int);
                                columnHeader += "(signed integer)";
                                break;
                            case ColumnTypes.UnsignedInteger:
                                _columnType = typeof(uint);
                                columnHeader += "(unsigned integer)";
                                break;
                            case ColumnTypes.String:
                                _columnType = typeof(string);
                                columnHeader += "(string)";
                                break;
                            case ColumnTypes.Float:
                                _columnType = typeof(float);
                                columnHeader += "(float)";
                                break;
                            case ColumnTypes.Double:
                                _columnType = typeof (double);
                                columnHeader += "(double)";
                                break;
                            case ColumnTypes.SignedLong:
                                _columnType = typeof (Int64);
                                columnHeader += "(signed long)";
                                break;
                            case ColumnTypes.UnsignedLong:
                                _columnType = typeof (UInt64);
                                columnHeader += "(unsigned long)";
                                break;
                            default:
                                throw new Exception($"Invalid column type ({columnType})");
                        }
                        #endregion

                        var columnTitle = $"[{i}]\n{columnHeader}";
                        var temporaryColumn = new DataColumn(columnTitle, _columnType)
                        {
                            DefaultValue = _columnType.GetDefault(),
                            Caption = columnTitle,
                        };

                        _temporaryTable.Columns.Add(temporaryColumn);

                    }

                    #endregion

                    #region Read value information

                    var rowCount = br.ReadInt32();
                    if (rowCount <= 0)
                        throw new Exception("Invalid row count value. Probably the specified table is corrupt.");

                    for (var i = 0; i < rowCount; i++)
                    {
                        DataRow _temporaryRow = _temporaryTable.NewRow();
                        for (var j = 0; j < columnCount; j++)
                        {
                            switch (columnData[j])
                            {
                                case ColumnTypes.SignedByte:
                                    _temporaryRow[j] = br.ReadSByte();
                                    break;
                                case ColumnTypes.UnsignedByte:
                                    _temporaryRow[j] = br.ReadByte();
                                    break;
                                case ColumnTypes.SignedShort:
                                    _temporaryRow[j] = br.ReadInt16();
                                    break;
                                case ColumnTypes.UnsignedShort:
                                    _temporaryRow[j] = br.ReadUInt16();
                                    break;
                                case ColumnTypes.SignedInteger:
                                    _temporaryRow[j] = br.ReadInt32();
                                    break;
                                case ColumnTypes.UnsignedInteger:
                                    _temporaryRow[j] = br.ReadUInt32();
                                    break;
                                case ColumnTypes.String:
                                    /* string */
                                    var strlen = br.ReadInt32();
                                    if (strlen > 0)
                                    {
                                        var chArray = Encoding.GetEncoding("EUC-KR").GetChars(br.ReadBytes(strlen));
                                        _temporaryRow[j] = new string(chArray);
                                    }

                                    break;
                                case ColumnTypes.Float:
                                    _temporaryRow[j] = br.ReadSingle();
                                    break;
                                case ColumnTypes.Double:
                                    _temporaryRow[j] = br.ReadDouble();
                                    break;
                                case ColumnTypes.SignedLong:
                                    _temporaryRow[j] = br.ReadInt64();
                                    break;
                                case ColumnTypes.UnsignedLong:
                                    _temporaryRow[j] = br.ReadUInt64();
                                    break;
                                default:
                                    throw new Exception(string.Format("Invalid column type ({0})", columnData[j]));
                            }
                        }
                        _temporaryTable.Rows.Add(_temporaryRow);}

                    #endregion
                   // Trace.Assert(ms.Length - 1 == ms.Position, "Did not read all the data!");
                    
                    return _temporaryTable;
                }
            }
        }

        public DataTable GetDataTableFromFile(string fileName, string tableName)
        {
            try
            {
                return GetTableFromDecodedBytes(DecodeFileIntoByteArray(fileName), tableName);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
