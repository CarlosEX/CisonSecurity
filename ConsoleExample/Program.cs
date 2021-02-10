using System;
using Cison.Security.Encryption;

namespace ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {

            CisonASC cison = new CisonASC();
            
            
            cison.Value = "Olá meu nome é esse 23 e tenho 22 anos";
            cison.Encrypt();
            Console.WriteLine(cison.Encrypt());

            cison.Value = cison.Encrypt();
            cison.Decrypt();
            Console.WriteLine(cison.Decrypt());

        }
    }
}
