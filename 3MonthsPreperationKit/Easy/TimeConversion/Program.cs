namespace TimeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string s = "12:01:00AM";

            s = Result.TimeConversion(s);
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
