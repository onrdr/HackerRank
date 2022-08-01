namespace Week2_FlippingTheMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrix = new List<List<int>>()
            {
                new List<int> { 112, 42, 83, 119 },
                new List<int> { 56, 125, 56, 49 },
                new List<int> { 15, 78, 101, 43 },
                new List<int> { 62, 98, 114, 108 },
            };

            Console.WriteLine(Result.FlippingMatrix(matrix));
        }
    }
}