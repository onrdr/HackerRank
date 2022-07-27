namespace Pangrams
{
    class Result
    {
        public static string Pangrams(string s)
        {
            bool flag = true;

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                if (!s.ToLower().Contains(letter))
                {
                    flag = false;
                    break;
                }
            }
            return flag ? "pangram" : "not pangram";
        }

        public static string Pangrams2(string s)
        {
            return "abcdefghijklmnopqrstuvwxyz".Intersect(s.ToLower()).Count() == 26 ? "pangram" : "not pangram";
        }

        public static string Pangrams3(string s)
        {
            return s.ToLower().Where(x => Char.IsLetter(x)).GroupBy(x => x).Count() == 26 ? "pangram" : "not pangram";
        }

        public static string Pangrams4(string s)
        {
            var list = new List<char>(); 

            foreach (var item in s.ToLower())
            {
                if (!list.Contains(item) && !item.Equals(' ')) 
                    list.Add(item); 
            }
            return list.Count == 26 ? "pangram" : "not pangram";
        }
    }
}