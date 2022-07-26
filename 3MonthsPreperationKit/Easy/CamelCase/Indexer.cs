namespace CamelCase
{
    class Indexer
    {
        internal static int GetIndexOfUpperCaseChar(string str)
        {
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    return str.IndexOf(c);
                }
            }
            return -1;
        }
    }

}

