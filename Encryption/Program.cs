using System;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Encryption aEncryption = new Encryption();
            Console.WriteLine($"Encrypted value : {aEncryption.EncryptString("kamol")}");

            Console.WriteLine($"Decrypted value: {aEncryption.DecryptString("eTgv41+/qVY=")}");

            Console.ReadKey();
        }
    }
}
