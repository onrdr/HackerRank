namespace PasswordDecryption
{
    class Result
    {
        public static string DecryptPassword(string originalPassword)
        {
            var list = new List<char>();
            foreach (var c in originalPassword)
            {
                if (!c.Equals('*'))
                {
                    list.Add(c);
                }
            }

            for (int i = list.Count - 1; i > 0; i--)
            {
                if (char.IsLetter(list[i]) && char.IsLower(list[i]) && char.IsUpper(list[i - 1]))
                {
                    (list[i - 1], list[i]) = (list[i], list[i - 1]); 
                    i --;
                    continue;
                }
                if (list[i].Equals('0'))
                {
                    (list[i], list[0]) = (list[0], list[i]);
                    list.Remove('0'); 
                }
            }

            string output = "";
            list.ForEach(s => output += s);

            return output;
        }
        public static string EncryptPassword(string s)
        {
            List<char> list = s.ToCharArray().ToList(); 

            for (int i = 0; i < list.Count - 1; i++)
            { 
                if (char.IsLetter(list[i]) && char.IsLower(list[i]) && char.IsUpper(list[i + 1]))
                {
                    (list[i + 1], list[i]) = (list[i], list[i + 1]);
                    list.Insert(i + 2, '*');
                    i += 2; 
                    continue;
                }
                if (char.IsDigit(list[i]))
                {
                    list.Insert(0, list[i]);
                    list[i + 1] = '0';
                    i++;
                }
            }
            string output = "";
            list.ForEach(s => output += s);

            return output;
        } 
    }
}