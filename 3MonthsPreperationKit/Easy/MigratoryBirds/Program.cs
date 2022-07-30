namespace MigratoryBirds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 1, 1, 2, 2, 3, 3, 3 };
            Console.WriteLine(Result.MigratoryBirds(list));
            solve(20, 10, 13);
            Console.ReadKey();
        }
        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double result = Math.Round(meal_cost + (meal_cost * tip_percent / 100) + (meal_cost * tax_percent / 100));
            Console.WriteLine(result);
        }
    }
}