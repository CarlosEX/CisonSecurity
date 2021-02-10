using System;
using Cison.Security.Encryption;

namespace ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ASCIIBasicEncryption.Encrypt("OLÁ MUNDO!"));
        }
    }
}
