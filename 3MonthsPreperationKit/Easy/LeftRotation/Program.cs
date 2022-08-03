namespace LeftRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            Result.RotateLeft(4, list);

            list.ForEach(x => Console.Write($"{x} "));

            Console.ReadKey();
        }
    }
}