using System;
using System.Security.Cryptography;
using System.Text;

namespace SHA1
{
    class Program
    {
        static string Hash(string input)
        {
            //string source = "Hello World!";
            using (SHA1Managed sha1Hash = new SHA1Managed()) //SHA1Managed sha1 = new SHA1Managed()
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                Console.WriteLine("The SHA1 hash of " + input + " is: " + hash);
            }
            return null;
        }
        static void Main(string[] args)
        {
            Hash("Do not use your bag");

            Console.ReadKey();
        }
    }
}
