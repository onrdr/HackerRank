namespace AppleAndOrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apples = new List<int> { 2, 4, -4 };
            var oranges = new List<int> { -2, 3, -5 };

            Result.CountApplesAndOranges(3, 7, 2, 9, apples, oranges);

            Console.ReadKey(); 
        }
    }
}