namespace LonelyInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new() { 1, 2, 3, 2, 3, 1, 4, 122 };
            Console.WriteLine($"XOR Solution        : {Result.LonelyIntegerFirstWay(list)}");
            Console.WriteLine($"IndexOf Solution    : {Result.LonelyIntegerSecondWay(list)}");
            Console.WriteLine($"Dictionary Solution : {Result.LonelyIntegerThirdWay(list)}");

            Console.ReadKey();
        }
    }
}