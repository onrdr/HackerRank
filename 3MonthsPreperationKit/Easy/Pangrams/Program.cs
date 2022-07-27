namespace Pangrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pangram test 
            Console.WriteLine(Result.Pangrams("We promptly judged antique ivory buckles for the next prize"));

            // Not pangram test
            Console.WriteLine(Result.Pangrams("We promptly judged antique ivory buckles for the prize"));

            Console.ReadKey();
        }
    }
}