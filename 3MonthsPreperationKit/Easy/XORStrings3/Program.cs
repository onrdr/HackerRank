using System.Text;

namespace XORStrings3
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            string? s = "111010";
            string? t = "010011"; 

            Console.WriteLine(Result.StringsXOR(s, t));

            Console.ReadKey();
        }
    }
}