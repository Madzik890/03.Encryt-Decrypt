using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    public class Caesar : Enciphering
    {
        

        private char[] alphabet = {
            'a','b','c','d','e','f',
            'g','h','i','j','k',
            'l','m','n','o','p',
            'q','r','s','t','u',
            'v','w','x','y','z',
            'A','B','C','D','E','F',
            'G','H','I','J','K',
            'L','M','N','O','P',
            'Q','R','S','T','U',
            'V','W','X','Y','Z',
            ' '};

        public uint key;

        public List<Etime> elapsed_time = new List<Etime>();
        
        public Caesar(uint key){ this.key = key; }

        public override string Decrypt(string input)
        {
            string output = "";//creating temp string for decrypting all char 
            double first_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
            for (int i = 0; i <= input.Length - 1; i++)//for 
            {
                output += decrypt_letter(input[i]);//decrypting all letter
            }
            double end_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
            elapsed_time.Add(new Etime(end_time - first_time, Etime.Type.encrypt, output.Length));

            return output;
        }
        public override string Encrypt(string input)
        {
           string output = "";//creating temp string for decrypting all char 
           double first_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
           for (int i =0;i <= input.Length - 1;i++)//for
           {
                output += encrypt_letter(input[i]);//encrypting all letter
           }
           double end_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
           elapsed_time.Add(new Etime(end_time - first_time,Etime.Type.encrypt,output.Length));

           return output;
        }
        public override string ReverseDecrypt(string input)//reverse decrypting
        {
            string output = "";//temp 
            double first_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
            for (int i = input.Length - 1; i >= 0; i--)//reverse loop 
            {
                output += decrypt_letter(input[i]);
            }
            double end_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
            elapsed_time.Add(new Etime(end_time - first_time, Etime.Type.encrypt, output.Length));

            return output;
        }
        public override string ReverseEncrypt(string input)//reverse encrypting
        {
            string output = "";
            double first_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
            for (int i = input.Length -1; i >= 0; i--)//reverse loop
            {
                output += encrypt_letter(input[i]);
            }
            double end_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
            elapsed_time.Add(new Etime(end_time - first_time, Etime.Type.encrypt, output.Length));

            return output;
        }

        public void ChangeAlphabet(char[] alph)//changing alphabet
        {
            this.alphabet = alph;
        }
        public char[] GetAlphabet()//returing actual alphabet
        {
            return alphabet;
        }

        private char encrypt_letter(char letter)//encrypting a letter
        {
            for(int i=0;i <= alphabet.Length -1;i++)
            {
                if(letter == alphabet[i])//if letter will be found
                {
                    if(i+key > alphabet.Length - 1)//calculate if lenght movement isn't to long
                    {
                        int temp = alphabet.Length - i;

                        return alphabet[(int)key - temp];
                    }
                    else
                        return alphabet[i + key];
                }

            }
            return '+';
        }
        private char decrypt_letter(char letter)
        {
            for (int i = 0; i <= alphabet.Length - 1; i++)
            {
                if (letter == alphabet[i])//if letter will be found
                {
                    if (i - key < 0)//calculate if lenght movement isn't to long
                    {
                        int temp = (int)key - i;

                        return alphabet[alphabet.Length - temp];
                    }
                    else
                        return alphabet[i - key];
                }

            }
            return '+';
        }//decrypting a letter
    }
}
