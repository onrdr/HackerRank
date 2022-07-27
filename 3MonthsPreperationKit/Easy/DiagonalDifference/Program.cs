namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<List<int>> list = new()
            {
                new List<int> { 11, 2, 4 },
                new List<int> { 4, 5, 6 },
                new List<int> { 10, 8, -12 }
            };
            
            Console.WriteLine(Result.DiagonalDifference(list));  

            Console.ReadKey();
        }
    }
}