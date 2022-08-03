namespace Week4_Anagram
{
    class Result
    {
        public static int Anagram(string s)
        {
            if (s.Length % 2 != 0)
                return -1;

            string s1 = s[..(s.Length / 2)];
            string s2 = s[(s.Length / 2)..];

            foreach (char c in s1)
            {
                if (s2.Contains(c))
                    s2 = s2.Remove(s2.IndexOf(c), 1); 
            }
            return s2.Length;
        }

    }
}