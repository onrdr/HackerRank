namespace ClosestNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var list = new List<int> { 18, 46, 72, 83, 94, 105 };
            Result.ClosestNumbers2(list).ForEach(x => Console.Write($"{x} "));
 
            Console.ReadKey();
        }
    }
}