﻿using Microsoft.VisualBasic;
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Security.Cryptography; 
using System.Text; 
using System.Threading.Tasks; 

namespace Datos
{
    public class security
    {
        public string getMd5Hash(string input)
        {
            // Create a new instance of the MD5 object.
            MD5 md5Hasher = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            int i;
            for (i = 0; i <= data.Length - 1; i++)
                sBuilder.Append(data[i].ToString("x2"));
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        // Verify a hash against a string.
        public bool verifyMd5Hash(string input, string hash)
        {
            // Hash the input.
            string hashOfInput = getMd5Hash(input);
            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
                return true;
            else
                return false;
        }
        public string EncryptText(string strText, string strPwd)
        {
            int i;
            int C;
            string strBuff = "";
            strPwd = Strings.UCase(strPwd);
            // 
            // Encrypt string
            if (Strings.Len(strPwd) > 0)
            {
                for (i = 1; i <= Strings.Len(strText); i++)
                {
                    C = Strings.Asc(Strings.Mid(strText, i, 1));
                    C += Strings.Asc(Strings.Mid(strPwd, (i % Strings.Len(strPwd)) + 1, 1));
                    strBuff += Strings.Chr(C & 0xFF);
                }
            }
            else
                strBuff = strText;
            return strBuff;
        }
        public string DecryptText(string strText, string strPwd)
        {
            int i;
            int C;
            string strBuff = "";
            strPwd = Strings.UCase(strPwd);
            // Decrypt string
            if (Strings.Len(strPwd) > 0)
            {
                for (i = 1; i <= Strings.Len(strText); i++)
                {
                    C = Strings.Asc(Strings.Mid(strText, i, 1));
                    C -= Strings.Asc(Strings.Mid(strPwd, (i % Strings.Len(strPwd)) + 1, 1));
                    strBuff += Strings.Chr(C & 0xFF);
                }
            }
            else
                strBuff = strText;
            return strBuff;
        }

    }
}