namespace SubarrayDivision2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch stopwatch = new();
            stopwatch.Start();

            Console.WriteLine(Result.Birthday(new List<int>
            {
                2, 3, 4, 1, 2, 2, 5, 4, 3, 3
            }, 10, 4)); 

            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.Elapsed}");  

            Console.ReadKey();
        } 
    }
}