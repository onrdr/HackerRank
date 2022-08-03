namespace ParallelProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 5, 3, 1 };

            Console.WriteLine(Result.MinTime(list, 5, 5));

            Console.ReadKey();
        }
    } 
}