namespace SparseArrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> strings = new() { "aba", "baba", "aba", "xzxb" };
            List<string> queries = new() { "aba", "xzxb", "ab" };

            var list = Result.MatchingStrings(strings, queries);

            list.ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    } 
}