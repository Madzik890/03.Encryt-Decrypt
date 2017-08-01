using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    abstract public class Enciphering
    {
        public class Etime
        {
            public enum Type
            {
                decrypt,
                encrypt
            }
            public Etime(double time, Type type, int lenght) { this.time = time; this.type = type; this.lenght = lenght; }
            readonly public double time;//time to do
            readonly public Type type;//type of operation
            readonly public int lenght;//lenght of decrypted/encrypted text
        }

        public abstract string Decrypt(string input);//function for decrypting
        public abstract string Encrypt(string input);//function for decrypting
        public abstract string ReverseDecrypt(string input);//reverse decrypting
        public abstract string ReverseEncrypt(string input);//reverse encrypting
    }
}
