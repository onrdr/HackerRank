namespace MaximumPerimeterTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listIn = new List<int>() { 1, 2, 3, 4, 5, 10 };
            var listOut = Result.MaximumPerimeterTriangle(listIn);
            listOut.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();

        }
    }

}