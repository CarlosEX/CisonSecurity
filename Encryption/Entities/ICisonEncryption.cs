using System;
namespace Cison.Security.Encryption
{
    public interface ICisonEncryption
    {
        string Encrypt();
        string Decrypt();
    } 
}