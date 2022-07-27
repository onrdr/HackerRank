
using System.Globalization;

namespace CamelCase
{
    class Combine
    {
        internal static List<string> CombineClass(string str)
        {
            str = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(str);
            return str.Split(' ').ToList();
        }
        internal static List<string> CombineVariable(string str)
        {
            var list = CombineClass(str);
            list[0] = list[0].ToLower();
            return list;
        }
        internal static List<string> CombineMethod(string str)
        {
            var list = CombineVariable(str);
            list[^1] += "()";
            return list;
        } 
    }

}

