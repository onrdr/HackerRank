namespace MiminumAbsoluteDifferenceInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { -2, 2, 4 };

            Console.WriteLine(Result.MinimumAbsoluteDifference(list));

            Console.ReadKey(); 
        }
    }
}