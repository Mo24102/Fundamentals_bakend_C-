using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.PasswordManager
{
    public static class EncryptionUtility
    {
        public static readonly string _originalChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public static readonly string _altChars = "2MNOABCDEPQRSFGHIcdTUlmnopbefgh789ijkqrstuv34JKLwVWXYZaxyz0156";
        public static string Encrypt(String password)
        {
            var sb=new StringBuilder();
            foreach (var ch in password)
            {
                var charsIndex= _originalChars.IndexOf(ch);
                sb.Append(_altChars[charsIndex]);
            }
            return sb.ToString();
        }
        public static string Decrypt(String password)
        {
            var sb = new StringBuilder();
            foreach (var ch in password)
            {
                var charsIndex = _altChars.IndexOf(ch);
                sb.Append(_originalChars[charsIndex]);
            }
            return sb.ToString();

        }
    }
}
