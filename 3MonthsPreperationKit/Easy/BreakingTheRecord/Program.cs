namespace BreakingTheRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new() { 12, 22, 22, 24, 10, 2, 0 };

            List<int> output = Result.BreakingRecords(input);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}