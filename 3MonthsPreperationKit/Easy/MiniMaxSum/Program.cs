namespace MiniMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new() { 7, 69, 2, 221, 8974 };

            Result.MiniMaxSum(list);

            Console.ReadKey();
        }

    }
}