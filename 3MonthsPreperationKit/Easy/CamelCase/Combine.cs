
using System.Globalization;

namespace CamelCase
{
    class Combine
    {
        internal static List<string> CombineClass(string str)
        {
            return GetStringsAsList(str);
        }
        internal static List<string> CombineVariable(string str)
        {
            var list = GetStringsAsList(str);
            list[0] = list[0].ToLower();
            return list;
        }
        internal static List<string> CombineMethod(string str)
        {
            var list = CombineVariable(str);
            list[^1] += "()";
            return list;
        }
        private static List<string> GetStringsAsList(string str)
        {
            str = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(str);
            List<string> list = str.Split(' ').ToList();
            return list;
        }
    }

}

