using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Rijndael_CFB_ISO10116
{
    public class CryptService
    {
        private static readonly byte[] SALT = new byte[] { 0x26, 0xdc, 0xff, 0x00,
                                                            0xad, 0xed, 0x7a, 0xee,
                                                            0xc5, 0xfe, 0x07, 0xaf,
                                                            0x4d, 0x08, 0x22, 0x3c };
        private static RijndaelManaged RijndaelProvider;

        private static Rfc2898DeriveBytes Pwd_bytes;

        static CryptService()
        {
            RijndaelProvider = new RijndaelManaged();
            RijndaelProvider.Mode = CipherMode.CFB;
            RijndaelProvider.Padding = PaddingMode.ISO10126;
        }

        private static void SetPwd(string pwd)
        {
            Pwd_bytes = new Rfc2898DeriveBytes(pwd, SALT);
        }

        private static void SetKey()
        {
            RijndaelProvider.Key = Pwd_bytes.GetBytes(32);
        }

        private static void GenerateIV()
        {
            RijndaelProvider.IV = Pwd_bytes.GetBytes(16);
        }

        public static byte[] Encrypt(byte[] source, string pwd)
        {
            //SetPwd(pwd);
            //SetKey();
            //GenerateIV();
            //MemoryStream memStream = new MemoryStream();
            //CryptoStream cryptoStream = new CryptoStream(memStream, RijndaelProvider.CreateEncryptor(), CryptoStreamMode.Write);
            //cryptoStream.Write(source, 0, source.Length);
            //cryptoStream.Close();
            //byte[] cipher = memStream.ToArray();
            //memStream.Close();
            //return cipher;
            using (var encryptor = RijndaelProvider.CreateEncryptor())
            {
                return encryptor.TransformFinalBlock(source, 0, source.Length);
            }
        }

        public static byte[] Decrypt(byte[] cipher, string pwd)
        {
            //SetPwd(pwd);
            //SetKey();
            //GenerateIV();
            //MemoryStream memStream = new MemoryStream();
            //CryptoStream cryptoStream = new CryptoStream(memStream, RijndaelProvider.CreateDecryptor(), CryptoStreamMode.Read);
            //cryptoStream.Read(cipher, 0, cipher.Length);
            //cryptoStream.Close();
            //byte[] decipher = memStream.ToArray();
            //memStream.Close();
            //return decipher;
            using (var decryptor = RijndaelProvider.CreateDecryptor())
            {
                return decryptor.TransformFinalBlock(cipher, 0, cipher.Length);
            }
        }

        public static byte[] GetSecretKey()
        {
            return RijndaelProvider.Key;
        }

        public static String GetSecretKeyString()
        {
            return ByteArrayToStringView(RijndaelProvider.Key);
        }

        public static byte[] GetIV()
        {
            return RijndaelProvider.IV;
        }

        public static String GetIVString()
        {
            return ByteArrayToStringView(RijndaelProvider.IV);
        }

        public static String GetInfo()
        {
            string info = "";
            info += "Mode: " + RijndaelProvider.Mode;
            info += "\nKey length: " + RijndaelProvider.KeySize;
            info += "\nBlock size: " + RijndaelProvider.BlockSize;
            info += "\nBlock fill method: " + RijndaelProvider.Padding;
            info += "\nValid key length: " + RijndaelProvider.LegalKeySizes[0].MinSize + " - " + RijndaelProvider.LegalKeySizes[0].MaxSize;
            info += "\nValid block size: " + RijndaelProvider.LegalBlockSizes[0].MinSize + " - " + RijndaelProvider.LegalBlockSizes[0].MaxSize;
            return info;
        }

        public static String ByteArrayToStringView(byte[] key)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in key)
            {
                sb.Append(" ");
                sb.Append(b.ToString());
            }

            return sb.ToString();
        }

        public static byte[] StringToByteArray(string str)
        {
            return Encoding.Unicode.GetBytes(str);
        }

        public static String ByteArrayToString(byte[] array)
        {
            return Encoding.Unicode.GetString(array);
        }

    }
}
