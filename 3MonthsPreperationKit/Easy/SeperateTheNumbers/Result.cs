
namespace SeperateTheNumbers
{
    class Result
    { 
        public static void SeparateNumbers(string s)
        { 
            string startingStr;
            string tempStr;
            long tempNum;

            for (int i = 0; i < s.Length / 2; i++)
            {
                startingStr = s.Substring(0, i + 1);
                tempNum = Convert.ToInt64(startingStr);
                tempStr = "";

                while (tempStr.Length < s.Length) 
                    tempStr += tempNum++;  

                if (s == tempStr)
                {
                    Console.WriteLine($"YES {startingStr}");
                    return;
                }
            }
            Console.WriteLine("NO");
        }

    }
}