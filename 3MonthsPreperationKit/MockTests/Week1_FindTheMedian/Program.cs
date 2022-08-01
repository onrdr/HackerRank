namespace Week1_FindTheMedian
{
    internal class Program
    {
        static void Main(string[] args) { 
                     
            var list = new List<int>() { 16, 32, 96, 43, 67, 37, 12 };

            Console.WriteLine(Result.FindMedian(list));

            Console.ReadKey();
        }
    }
}