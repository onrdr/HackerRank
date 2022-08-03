namespace Week4_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Result.Anagram("aaabbb"));
            Console.WriteLine(Result.Anagram("ab"));
            Console.WriteLine(Result.Anagram("abc"));
            Console.WriteLine(Result.Anagram("mnop"));
            Console.WriteLine(Result.Anagram("xyyx"));
            Console.WriteLine(Result.Anagram("xaxbbbxx"));

            Console.ReadKey();
        }
    }
}