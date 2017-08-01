using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encryptor;

namespace Encryptor_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Encryptor.Caesar caesar = new Encryptor.Caesar(38);

            string text = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            string cry_text = caesar.Encrypt(text);
            Console.WriteLine(cry_text + " crypth time: " + caesar.elapsed_time[0].time.ToString() + " ms");

            Console.ReadKey();
        }
    }
}
