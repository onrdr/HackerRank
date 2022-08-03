
namespace SeperateTheNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            string s1 = "1234567";
            string s2 = "910111213";
            string s3 = "66666666666666666666666666666666";
            string s4 = "99100101102103104";
            string s5 = "999100010011002100310041005";
            string s6 = "55555555555555555555555555555555";
            string s7 = "37893790379137923793";
            string s8 = "77777777777777777777777777777777";
            string s9 = "8888888888888888888888888888888888888";
            string s10 = "10001001100210031004100510061007";
            Result.SeparateNumbers(s1);
            Result.SeparateNumbers(s2);
            Result.SeparateNumbers(s3);
            Result.SeparateNumbers(s4);
            Result.SeparateNumbers(s5);
            Result.SeparateNumbers(s6);
            Result.SeparateNumbers(s7);
            Result.SeparateNumbers(s8);
            Result.SeparateNumbers(s9);
            Result.SeparateNumbers(s10); 
            
            Console.ReadKey();
        }
    }
}