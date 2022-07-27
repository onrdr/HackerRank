namespace CamelCase
{
    class Display
    {
        internal static void SplitList(List<string> list)
        {
            list.ForEach(x => Console.Write($"{x} "));
        }

        internal static void CombineList(List<string> list)
        {
            list.ForEach(x => Console.Write(x));
        }
    }

}

