using System.Text;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Result.CaesarCipher2("middle-Outz", 2));

            Console.ReadKey();
        }
    }
    class Result
    {
        public static string CaesarCipher(string s, int k)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
            string str = "";
            foreach (var ascii in asciiBytes)
            {
                if (ascii >= 65 && ascii <= 90)
                    str += (char)(((ascii - 65 + k) % 26) + 65);
                else if (ascii >= 97 && ascii <= 122)
                    str += (char)(((ascii - 97 + k) % 26) + 97);
                else
                    str += (char)ascii;
            }
            return str;
        }

        public static string CaesarCipher2(string s, int k)
        {
            var list = s.ToList();
            string encryptedResult = "";
            k %= 26;

            for (int i = 0; i < list.Count; i++)
            {
                char tempChar = list[i];
                if (tempChar >= 'a' && tempChar <= 'z')
                {
                    tempChar = (char)(tempChar + k);
                    if (tempChar > 'z')
                        tempChar = (char)('a' + tempChar - 'z' - 1);
                }
                else if (list[i] >= 'A' && list[i] <= 'Z')
                {
                    tempChar = (char)(tempChar + k);
                    if (tempChar > 'Z')
                        tempChar = (char)('A' + tempChar - 'Z' - 1);
                }
                encryptedResult += tempChar;
            }
            return encryptedResult;
        }
    }
}