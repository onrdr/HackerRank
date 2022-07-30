using System.Text.RegularExpressions;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Input.GetListOfInputStrings();

            foreach (string str in list)
            {
                Direction.ToProperFunction(str);
                Console.WriteLine();
            }

            Console.ReadKey();
        }  
    }
}

