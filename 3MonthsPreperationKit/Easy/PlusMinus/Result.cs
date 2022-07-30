namespace PlusMinus
{
    internal class Result
    {
        public static void PlusMinus(List<int> arr)
        {
            float zeroCount = 0, positiveCounter = 0, negativeCounter = 0;

            arr.ForEach(x =>
            {
                switch (x)
                {
                    case 0:
                        zeroCount++;
                        break;
                    case > 0:
                        positiveCounter++;
                        break;
                    case < 0:
                        negativeCounter++;
                        break;
                }
            });
            Console.WriteLine($"Ratio of positive elements: {positiveCounter / arr.Count:N6}");
            Console.WriteLine($"Ratio of negative elements: {negativeCounter / arr.Count:N6}");
            Console.WriteLine($"Ratio of zero elements: {zeroCount / arr.Count:N6}");
        }
    }
}