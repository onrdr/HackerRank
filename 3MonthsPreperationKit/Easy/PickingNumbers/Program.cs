namespace PickingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 4, 6, 5, 3, 3, 1 };
            Console.WriteLine(Result.PickingNumbers(list));

            Console.ReadKey();
        }
    }
}