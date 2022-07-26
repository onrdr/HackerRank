namespace CamelCase
{
    class Input
    {
        internal static List<string> GetListOfInputStrings()
        {
            List<string> list = new();
            string input;
            while ((input = Console.ReadLine()) != null && input != "")
            {
                list.Add(input);
                Console.ReadKey();
            }
            return list;
        }
    }

}

