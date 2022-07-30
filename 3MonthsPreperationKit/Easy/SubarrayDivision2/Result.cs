namespace SubarrayDivision2
{
    internal partial class Program
    {
        class Result
        {
            // 5 ms 
            public static int Birthday(List<int> s, int d, int m)
            {
                int startIndex = 0;
                int lastIndex = s.Count + 1 - m;
                int counter = 0;

                while (startIndex < lastIndex)
                {
                    int sum = 0;
                    for (int i = startIndex; i < m + startIndex; i++)
                        sum += s[i];

                    if (sum == d)
                        counter++;
                    startIndex++;
                }
                return counter;
            }

            // 5 ms 
            public static int Birthday2(List<int> s, int d, int m)
            {
                int startIndex = 0;
                int endIndex = m - 1;
                int length = s.Count;
                int result = 0;
                int sum = 0;

                for (int i = startIndex; i <= endIndex; i++)
                    sum += s[i];

                if (sum == d) result++;

                if (endIndex == length - 1) return result;

                while (endIndex < length - 1)
                {
                    sum += s[++endIndex] - s[startIndex++];
                    if (sum == d) result++;
                }
                return result;
            }

            // 12 ms 
            public static int Birthday3(List<int> s, int d, int m)
            {
                int count = 0;

                for (int i = 0; i < s.Count; i++)
                {
                    if (d == s.Skip(i).Take(m).ToList().Sum())
                        count++;
                }
                return count;
            }

            // 12 ms 
            public static int Birthday4(List<int> s, int d, int m)
            {
                return Enumerable
                    .Range(0, s.Count + 1 - m)
                    .Count(x => Enumerable
                        .Range(0, m)
                        .Select(y => s[x + y])
                        .Sum() == d);
            }
        }
        
    }
}