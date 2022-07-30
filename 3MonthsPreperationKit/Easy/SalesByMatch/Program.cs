namespace SalesByMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            var list = new List<int>() { 1, 2, 1, 2, 1, 3, 2 };

            Console.WriteLine(Result.SockMerchant(7, list)); 

            Console.ReadKey();
        }
    }
}