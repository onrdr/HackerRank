namespace AppleAndOrange
{
    class Result
    {
        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            Console.WriteLine(apples.Select(i => i += a).Where(i => i >= s && i <= t).ToList().Count);
            Console.WriteLine(oranges.Select(i => i += b).Where(i => i >= s && i <= t).ToList().Count);
        }
    }
}