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
using System.IO;
using System.Security.Cryptography;

namespace KOTableEditor.Auxillary.Encryption
{
    public sealed class KOEncryptionChaosExpansion : KOEncryptionBase
    {

        private ushort _volatileKey = 0x0418;
        private const ushort CipherKey1 = 0x8041;
        private const ushort CipherKey2 = 0x1804;

        // encryption key : 8sgpV&22dsdLg3k
        /*38DDF857830FD7F89024879E1EAFF65D34C7FE740F6EC0E96B876C02FD4FC8D8BFAE95B0B5AB7AC94F63A67EA35ECA183CB347908C7E235C7FCD9E94ED61F41966F996CFB93BD805DF33338265B6AF9ECDAD2B855B72CEF242D3750EFDF3A946*/

        /*768 bit key */
        private readonly byte[] _key =
        { 
            0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 
            1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 1, 1, 
            1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 
            1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 
            1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 
            1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 
            0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 
            1, 1, 1, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 1, 
            0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 
            1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 0, 
            0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 
            1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 
            0, 1, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 
            0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 
            1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1, 1, 
            1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 
            1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 
            1, 0, 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 
            1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 
            0, 1, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 1, 
            0, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 
            1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 
            1, 0, 1, 0, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0, 
            1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 
            0, 0, 1, 1, 1, 1, 0, 0, 1, 0, 1, 1, 0, 0, 1, 1, 
            0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 
            1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 
            0, 0, 1, 0, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1, 0, 0, 
            0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 
            1, 0, 0, 1, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 
            1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 
            1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 
            0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 
            1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 
            1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 1, 1, 
            1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 
            1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 
            0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 
            0, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 0, 
            1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 
            1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 
            0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 
            0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1, 0, 
            1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 
            0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 1, 1, 
            0, 1, 1, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 
            1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 
            1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0
        };

        static readonly byte[] ExpansionOperationMatrix = 
        {
                32, 1,  2,  3,  4,  5,
                4,  5,  6,  7,  8,  9,
                8,  9,  10, 11, 12, 13,
                12, 13, 14, 15, 16, 17,
                16, 17, 18, 19, 20, 21,
                20, 21, 22, 23, 24, 25,
                24, 25, 26, 27, 28, 29,
                28, 29, 30, 31, 32, 1
       };

        static readonly byte[] Permutation =
        {
            16, 7, 20, 21, 29, 12, 28, 17,
            1, 15, 23, 26, 5, 18, 31, 10,
            2, 8, 24, 14, 32, 27, 3, 9,
            19, 13, 30, 6, 22, 11, 4, 25
        };


        private static int GetRealLength(byte[] buffer, int p1)
        {
            return ((((buffer[p1] << 24) + (buffer[p1 + 1] << 16)) + (buffer[p1 + 2] << 8)) + buffer[p1 + 3]);
        }

        private static void InitialDecode_Sub(ref byte[] p0, byte[] p1, int p2)
        {
            int num = 0;
            int num2 = 15;
            var numArray = new uint[8];
            var buffer = new byte[48];

          


            var numArray2 = new uint[] { 
                0x10101, 0x100, 0x1000101, 0x1000000, 0x10000, 0x1010101, 0x1010001, 1, 0x1010000, 0x10001, 0x10100, 0x101, 0x1000100, 0x1000001, 0, 0x1010100, 
                0, 0x1010101, 0x1010100, 0x100, 0x10101, 0x10000, 0x1000101, 0x1000000, 0x10001, 0x10100, 0x101, 0x1010001, 0x1000001, 0x1000100, 0x1010000, 1, 
                0x100, 0x1000000, 0x10101, 1, 0x1000101, 0x10100, 0x10000, 0x1010001, 0x1010101, 0x101, 0x1000001, 0x1010100, 0x1010000, 0x10001, 0x1000100, 0, 
                0x1010101, 0x101, 1, 0x10000, 0x100, 0x1000001, 0x1000000, 0x1010100, 0x1000100, 0x1010001, 0x1010000, 0x10101, 0x10001, 0, 0x10100, 0x1000101
             };
            var numArray3 = new uint[] { 
                0x1010101, 0x1000000, 1, 0x10101, 0x10100, 0x1010001, 0x1010000, 0x100, 0x1000001, 0x1010100, 0x10000, 0x1000101, 0x101, 0, 0x1000100, 0x10001, 
                0x1010000, 0x1000101, 0x100, 0x1010100, 0x1010101, 0x10000, 1, 0x10101, 0x101, 0, 0x1000000, 0x10001, 0x10100, 0x1000001, 0x1010001, 0x1000100, 
                0, 0x10101, 0x1010100, 0x1010001, 0x10001, 0x100, 0x1000101, 0x1000000, 0x1000100, 1, 0x101, 0x10100, 0x1000001, 0x1010000, 0x10000, 0x1010101, 
                0x1000101, 1, 0x10001, 0x1000000, 0x1010000, 0x1010101, 0x100, 0x10000, 0x1010001, 0x10100, 0x1010100, 0x101, 0, 0x1000100, 0x10101, 0x1000001
             };
            var numArray4 = new uint[] { 
                0x10001, 0, 0x1000001, 0x10101, 0x10100, 0x1010000, 0x1010101, 0x1000100, 0x1000000, 0x1000101, 0x101, 0x1010100, 0x1010001, 0x100, 0x10000, 1, 
                0x1000101, 0x1010100, 0, 0x1000001, 0x1010000, 0x100, 0x10100, 0x10001, 0x10000, 1, 0x1000100, 0x10101, 0x101, 0x1010001, 0x1010101, 0x1000000, 
                0x1000101, 0x10100, 0x100, 0x1000001, 1, 0x1010101, 0x1010000, 0, 0x1010001, 0x1000000, 0x10000, 0x101, 0x1000100, 0x10001, 0x10101, 0x1010100, 
                0x1000000, 0x10001, 0x1000101, 0, 0x10100, 0x1000001, 1, 0x1010100, 0x100, 0x1010101, 0x10101, 0x1010000, 0x1010001, 0x1000100, 0x10000, 0x101
             };
            var numArray5 = new uint[] { 
                0x1010100, 0x1000101, 0x10101, 0x1010000, 0, 0x10100, 0x1000001, 0x10001, 0x1000000, 0x10000, 1, 0x1000100, 0x1010001, 0x101, 0x100, 0x1010101, 
                0x1000101, 1, 0x1010001, 0x1000100, 0x10100, 0x1010101, 0, 0x1010000, 0x100, 0x1010100, 0x10000, 0x101, 0x1000000, 0x10001, 0x10101, 0x1000001, 
                0x10001, 0x10100, 0x1000001, 0, 0x101, 0x1010001, 0x1010100, 0x1000101, 0x1010101, 0x1000000, 0x1010000, 0x10101, 0x1000100, 0x10000, 1, 0x100, 
                0x1010000, 0x1010101, 0, 0x10100, 0x10001, 0x1000000, 0x1000101, 1, 0x1000001, 0x100, 0x1000100, 0x1010001, 0x101, 0x1010100, 0x10000, 0x10101
             };
            var numArray6 = new uint[] { 
                0x10000, 0x101, 0x100, 0x1000000, 0x1010100, 0x10001, 0x1010001, 0x10100, 1, 0x1000100, 0x1010000, 0x1010101, 0x1000101, 0, 0x10101, 0x1000001, 
                0x10101, 0x1010001, 0x10000, 0x101, 0x100, 0x1010100, 0x1000101, 0x1000000, 0x1000100, 0, 0x1010101, 0x10001, 0x1010000, 0x1000001, 1, 0x10100, 
                0x100, 0x10000, 0x1000000, 0x1010001, 0x10001, 0x1000101, 0x1010100, 1, 0x1010101, 0x1000001, 0x101, 0x1000100, 0x10100, 0x1010000, 0, 0x10101, 
                0x1010001, 1, 0x101, 0x1010100, 0x1000000, 0x10101, 0x10000, 0x1000101, 0x10100, 0x1010101, 0, 0x1000001, 0x10001, 0x100, 0x1000100, 0x1010000
             };
           var numArray7 = new uint[] { 
                0x101, 0x1000000, 0x10001, 0x1010101, 0x1000001, 0x10000, 0x10100, 1, 0, 0x1000101, 0x1010000, 0x100, 0x10101, 0x1010100, 0x1000100, 0x1010001, 
                0x10001, 0x1010101, 0x100, 0x10000, 0x1010100, 0x101, 0x1000001, 0x1000100, 0x10100, 0x1000000, 0x1000101, 0x10101, 0, 0x1010001, 0x1010000, 1, 
                0x1000001, 0x10101, 0x1010101, 0x1000100, 0x10000, 1, 0x101, 0x1010000, 0x1010100, 0, 0x100, 0x10001, 0x1000000, 0x1000101, 0x1010001, 0x10100, 
                0x100, 0x1010000, 0x10000, 0x101, 0x1000001, 0x1000100, 0x1010101, 0x10001, 0x1010001, 0x10101, 0x1000000, 0x1010100, 0x10100, 0, 1, 0x1000101
             };
            var numArray8 = new uint[] { 
                0x100, 0x1010001, 0x10000, 0x10101, 0x1010101, 0, 1, 0x1000101, 0x1010000, 0x101, 0x1000001, 0x1010100, 0x1000100, 0x10001, 0x10100, 0x1000000, 
                0x1000101, 0, 0x1010001, 0x1010100, 0x100, 0x1000001, 0x1000000, 0x10001, 0x10101, 0x1010000, 0x1000100, 0x101, 0x10000, 0x1010101, 1, 0x10100, 
                0x1000000, 0x100, 0x1010001, 0x1000101, 0x101, 0x1010000, 0x1010100, 0x10101, 0x10001, 0x1010101, 0x10100, 1, 0, 0x1000100, 0x1000001, 0x10000, 
                0x10100, 0x1010001, 0x1000101, 1, 0x1000000, 0x100, 0x10001, 0x1010100, 0x1000001, 0x1000100, 0, 0x1010101, 0x10101, 0x10000, 0x1010000, 0x101
             };
            var numArray9 = new uint[] { 
                0x1000101, 0x10000, 1, 0x100, 0x10100, 0x1010101, 0x1010001, 0x1000000, 0x10001, 0x1000001, 0x1010000, 0x10101, 0x1000100, 0, 0x101, 0x1010100, 
                0x1000000, 0x1010101, 0x1000101, 1, 0x10001, 0x1010000, 0x1010100, 0x100, 0x101, 0x1000100, 0x10100, 0x1010001, 0, 0x10101, 0x1000001, 0x10000, 
                0x1010100, 0x1010001, 0x100, 0x1000000, 0x1000001, 0x101, 0x10101, 0x10000, 0, 0x10100, 0x10001, 0x1000101, 0x1010101, 0x1010000, 0x1000100, 1, 
                0x10000, 0x1000000, 0x10101, 0x1010100, 0x100, 0x10001, 1, 0x1000101, 0x1010101, 0x101, 0x1000001, 0, 0x1010000, 0x1000100, 0x10100, 0x1010001
             };
            /* 32-bit permutation function P used on the output of the S-boxes */
            
            do
            {
                /* KEY EXPANSION */
                int index = 0;
                do
                {
                    int num4 = num;
                    if (p2 == 0)
                    {
                        num4 = num2;
                    }
                    byte num5 = (byte) (p0[(48*num4) + index] ^ p1[ExpansionOperationMatrix[index] + 31]);
                    index++;
                    buffer[index - 1] = num5;
                }
                while (index < 48);



                numArray[0] = numArray2[buffer[4] | (2 * (buffer[3] | (2 * (buffer[2] | (2 * (buffer[1] | (2 * (buffer[5] | (2 * buffer[0])))))))))];
                numArray[1] = numArray3[buffer[10] | (2 * (buffer[9] | (2 * (buffer[8] | (2 * (buffer[7] | (2 * (buffer[11] | (2 * buffer[6])))))))))];
                numArray[2] = numArray4[buffer[16] | (2 * (buffer[15] | (2 * (buffer[14] | (2 * (buffer[13] | (2 * (buffer[17] | (2 * buffer[12])))))))))];
                numArray[3] = numArray5[buffer[22] | (2 * (buffer[21] | (2 * (buffer[20] | (2 * (buffer[19] | (2 * (buffer[23] | (2 * buffer[18])))))))))];
                numArray[4] = numArray6[buffer[28] | (2 * (buffer[27] | (2 * (buffer[26] | (2 * (buffer[25] | (2 * (buffer[29] | (2 * buffer[24])))))))))];
                numArray[5] = numArray7[buffer[34] | (2 * (buffer[0x21] | (2 * (buffer[32] | (2 * (buffer[31] | (2 * (buffer[0x23] | (2 * buffer[30])))))))))];
                numArray[6] = numArray8[buffer[40] | (2 * (buffer[39] | (2 * (buffer[38] | (2 * (buffer[37] | (2 * (buffer[41] | (2 * buffer[36])))))))))];
                numArray[7] = numArray9[buffer[46] | (2 * (buffer[45] | (2 * (buffer[44] | (2 * (buffer[43] | (2 * (buffer[0x2f] | (2 * buffer[42])))))))))];
                var destinationArray = new byte[32];
                for (var i = 0; i < 8; i++)
                {
                    Array.Copy(BitConverter.GetBytes(numArray[i]), 0, destinationArray, i * 4, 4);
                }
                var num7 = 0;
                if (num2 <= 0)
                {
                    int num8 = 32;
                    do
                    {
                        p1[num7] = (byte)(p1[num7] ^ destinationArray[Permutation[num7] - 1]);
                        num7++;
                        num8--;
                    }
                    while (num8 > 0);
                }
                else
                {
                    var num9 = 32;
                    do
                    {
                        byte num10 = p1[num7 + 32];
                        byte num11 = (byte)(p1[num7] ^ destinationArray[Permutation[num7] - 1]);
                        num7++;
                        num9--;
                        p1[num7 + 31] = num11;
                        p1[num7 - 1] = num10;
                    }
                    while (num9 > 0);
                }
                num2--;
                num++;
            }
            while (num2 > -1);
        }
        

        private static void EncodeLayer1(byte[] key, byte[] inputBuffer, int bufferLen, ref byte[] outputBuffer)
        {
            //var length = bufferLen - 20;
            /* bütün dosyayı 8 ayrı parça olarak işliyor sanırım */
            var mainCounter = (bufferLen+7) >> 3;
            var num3 = 0;
            var outputIndex = 0;
            var plainByteBlock = new byte[64];

            /* ilk 20 byteyi pas geçiyor */
            Array.Copy(inputBuffer, 0, outputBuffer, 0, bufferLen);
            int c = 0;
     
            do
            {
                Array.Clear(plainByteBlock, 0, 64);
                int index = 0;
                int counter = 8;

                /* Seperate current byte to bits. */
                do
                {
                    byte num8 = outputBuffer[num3++];
                    plainByteBlock[index] = (byte)((num8 >> 7) & 1);
                    int num9 = index + 1;
                    plainByteBlock[num9++] = (byte)((num8 >> 6) & 1);
                    plainByteBlock[num9++] = (byte)((num8 >> 5) & 1);
                    plainByteBlock[num9++] = (byte)((num8 >> 4) & 1);
                    plainByteBlock[num9++] = (byte)((num8 >> 3) & 1);
                    plainByteBlock[num9++] = (byte)((num8 >> 2) & 1);
                    plainByteBlock[num9++] = (byte)((num8 >> 1) & 1);
                    plainByteBlock[num9] = (byte)(num8 & 1);
                    index = num9 + 1;
                    counter--;
                }
                while (counter > 0);
                /* Process byte block */
                InitialDecode_Sub(ref key, plainByteBlock, 1);
                int counter2 = 0;
                /* Merge processed bits to byte.*/
                do
                {
                    byte processedByte = (byte)(plainByteBlock[counter2 + 7] | (2 * (plainByteBlock[counter2 + 6] | (2 * (plainByteBlock[counter2 + 5] | (2 * (plainByteBlock[counter2 + 4] | (2 * (plainByteBlock[counter2 + 3] | (2 * (plainByteBlock[counter2 + 2] | (2 * (plainByteBlock[counter2 + 1] | (2 * plainByteBlock[counter2]))))))))))))));
                    counter2 += 8;
                    outputBuffer[outputIndex++] = processedByte;
                    //c++;
                }
                while (counter2 < 64);
            }
            while (mainCounter-- != 1);
        }


        private static void DecodeLayer1(byte[] key, byte[] inputBuffer, int bufferLen, ref byte[] outputBuffer)
        {
            var length = bufferLen - 20;
            /* bütün dosyayı 8 ayrı parça olarak işliyor sanırım */
            var mainCounter = (length + 7) >> 3;
            var num3 = 0;
            var outputIndex = 0;
            var plainByteBlock = new byte[64];

            /* ilk 20 byteyi pas geçiyor */
            Array.Copy(inputBuffer, 20, outputBuffer, 0, length);

            do
            {
               Array.Clear(plainByteBlock, 0, 64);
               int index = 0;
                int counter = 8;

                /* Seperate current byte to bits. */
                do
                {
                    byte num8 = outputBuffer[num3++];
                    plainByteBlock[index] = (byte)((num8 >> 7) & 1);
                    int num9 = index + 1;
                    plainByteBlock[num9++] = (byte)((num8 >> 6) & 1);
                    plainByteBlock[num9++] = (byte)((num8 >> 5) & 1);
                    plainByteBlock[num9++] = (byte)((num8 >> 4) & 1);
                    plainByteBlock[num9++] = (byte)((num8 >> 3) & 1);
                    plainByteBlock[num9++] = (byte)((num8 >> 2) & 1);
                    plainByteBlock[num9++] = (byte)((num8 >> 1) & 1);
                    plainByteBlock[num9] = (byte)(num8 & 1);
                    index = num9 + 1;
                    counter--;
                }
                while (counter > 0);
                /* Process byte block */
                InitialDecode_Sub(ref key, plainByteBlock, 0);
                int counter2 = 0;
                /* Merge processed bits to byte.*/
                do
                {
                    byte processedByte = (byte)(plainByteBlock[counter2 + 7] | (2 * (plainByteBlock[counter2 + 6] | (2 * (plainByteBlock[counter2 + 5] | (2 * (plainByteBlock[counter2 + 4] | (2 * (plainByteBlock[counter2 + 3] | (2 * (plainByteBlock[counter2 + 2] | (2 * (plainByteBlock[counter2 + 1] | (2 * plainByteBlock[counter2]))))))))))))));
                    counter2 += 8;
                    outputBuffer[outputIndex++] = processedByte;
                }
                while (counter2 < 64);
            }
            while (mainCounter-- != 1);
        }




        public override string Name()
        {
            return "Double Encryption (1886 and above)";
        }

        public override string Description()
        {
            return "The encryption used by the USKO";
        }

        public override void Decode(ref byte[] data)
        {

            int decodeBufferLen = data.Length;
            var decodeBuffer = new byte[data.Length];
            decodeBuffer = new byte[decodeBufferLen];

            using (Stream stream = new MemoryStream(data))
            {
                stream.Read(decodeBuffer, 0, (int)data.Length);
            }

            int len2 = BitConverter.ToInt32(decodeBuffer, 16);
            int length = GetRealLength(decodeBuffer, 16);

            byte[] buffer = new byte[decodeBufferLen-20];
            // decodebuffer ilk 20 byte pas geçiyor
            DecodeLayer1(_key, decodeBuffer, decodeBufferLen, ref buffer);

            /*
             * Debug-dump decoded file 
             */
            using (FileStream fs = File.Create("DEBUG_decrypted_l1.bin"))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        bw.Write(buffer[i]);
                    }
                }
            }

            _volatileKey = 0x0418;
            for (int i = 0; i < buffer.Length; i++)
            {
                byte rawByte = buffer[i];
                byte temporaryKey = (byte)((_volatileKey & 0xff00) >> 8);
                byte encryptedByte = (byte)(temporaryKey ^ rawByte);
                _volatileKey = (ushort)((rawByte + _volatileKey) * CipherKey1 + CipherKey2);
                buffer[i] = encryptedByte;
            }

            /*
            * Debug-dump decoded file 
            */
            using (FileStream fs = File.Create("DEBUG_decrypted_full.bin"))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        bw.Write(buffer[i]);
                    }
                }
            }

            data = new byte[length];
            Array.Copy(buffer, 0, data, 0, length);
            if(length+20 != decodeBufferLen)
            {
                
                //Padding = new byte[decodeBufferLen - length];
              //  Array.Copy(buffer, length, Padding, 0, decodeBufferLen - length);
            }
          //  File.WriteAllBytes("wtf.ddump", buffer);
        }

        public override void Encode(FileStream plainStream)
        {
            /* plainStream'de sadece sütun ve satır verisi var.*/
            var fileHeader = new byte[]
            {
                0x4C, 0x26, 0x43, 0x7F, 0x80, 0xF1, 0x57, 0x98, 0x79, 0xFC, 0xAF, 0x26, 0x86, 0xD6, 0x20, 0x8E
            };

            var plainLength = plainStream.Length;

            var encodedFileSize = new byte[4];
            encodedFileSize[3] = (byte) (plainLength & 0x000000ff);
            encodedFileSize[2] = (byte) ((plainLength & 0x0000ff00) >> 8);
            encodedFileSize[1] = (byte) ((plainLength & 0x00ff0000) >> 16);
            encodedFileSize[0] = (byte) ((plainLength & 0xff000000) >> 24);

            var leeee = GetRealLength(encodedFileSize,0);

            /* Encrypt with layer 2 schema */

            EncodeStandart(plainStream);
            /* Encrypt with layer 1 schema */
            plainStream.Seek(0, SeekOrigin.Begin);

            var plain_len = plainStream.Length;
            // int length = (int) decodeBufferLen;
            var encodedbuffer = new byte[plain_len];
            plainStream.Read(encodedbuffer, 0, (int)plain_len);
            byte[] buffer = new byte[plain_len + (8-(plain_len % 8))];
            EncodeLayer1(_key, encodedbuffer, (int)plain_len, ref buffer);

          
            /* Erase stream content */
            plainStream.Flush();
            plainStream.Seek(0, SeekOrigin.Begin);


            foreach (byte t in fileHeader)
                plainStream.WriteByte(t);

            foreach (byte t in encodedFileSize)
                plainStream.WriteByte(t);

            /* Write encoded buffer */

            plainStream.Write(buffer, 0, buffer.Length);

            AfterEncode(plainStream);
        
        }

        private  void EncodeStandart(FileStream plainStream)
        {
            plainStream.Seek(0, SeekOrigin.Begin);
            var plainByte = plainStream.ReadByte();

            _volatileKey = 0x0418;

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
        }

        public override bool NewTableStructure()
        {
            return true;
        }
    }
}
