namespace XORStrings3
{
    public class Result
    {

        public static string StringsXOR(string s, string t)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                {
                    res += "0";
                    continue;
                }
                res += "1";
            } 
            return res;
        }  
    }
}