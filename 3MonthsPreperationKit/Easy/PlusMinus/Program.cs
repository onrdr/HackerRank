namespace PlusMinus
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            List<int> exampleList = new() { -1, 2, -3, 0, 5, 0, 7 };

            Result.PlusMinus(exampleList);  

            Console.ReadKey();
        } 
    }
}