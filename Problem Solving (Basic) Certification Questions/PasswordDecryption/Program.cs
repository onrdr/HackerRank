namespace PasswordDecryption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalPassword = "aP1pL5e";
            string encryptedPassword = "51Pa*0Lp*0e"; 

            Console.WriteLine($"Original Password : {Result.DecryptPassword(encryptedPassword)}");
            Console.WriteLine($"After Encryption : {Result.EncryptPassword(originalPassword)}");
            

            Console.ReadKey();
        }
    }
}