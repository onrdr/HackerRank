namespace Week3_BetweenTwoSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new() { 1 };
            List<int> l2 = new() { 100 };

            Console.WriteLine(Result.GetTotalX(l1, l2));

            Console.ReadKey();
        }
    } 
}