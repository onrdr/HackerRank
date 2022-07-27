namespace CamelCase
{
    class Split
    {
        internal static List<string> SplitName(string str)
        {
            List<string> list = new();
            str = str.Replace('(', ' ');
            str = str.Replace(')', ' ').Trim();

            while (true)
            {
                str = str.Replace(str[0], char.ToLower(str[0]));
                int index = Indexer.GetIndexOfUpperCaseChar(str);
                if (index == -1)
                {
                    list.Add(str);
                    break;
                }
                list.Add(str[..index]);
                str = str[index..];
            }
            return list;
        }
    }

}

