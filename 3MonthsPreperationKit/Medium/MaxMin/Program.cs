namespace MaxMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Result.MaxMin(3, new List<int> { 100, 200, 300, 350, 400, 401, 402})); 

            Console.ReadKey();
        }
    }

}