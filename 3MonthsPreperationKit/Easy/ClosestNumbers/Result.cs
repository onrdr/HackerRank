namespace ClosestNumbers
{
    class Result
    {
        public static List<int> ClosestNumbers(List<int> arr)
        {
            var res = new List<int>();
            arr.Sort();
            long smallest = long.MaxValue;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                long diff = arr[i + 1] - arr[i];
                if (diff < smallest)
                    smallest = diff;
            }
            for (int i = 0; i < arr.Count - 1; i++)
            {
                int diff = arr[i + 1] - arr[i];
                if (diff == smallest)
                {
                    res.Add(arr[i]);
                    res.Add(arr[i + 1]);
                }
            }
            return res;
        }
        public static List<int> ClosestNumbers2(List<int> arr)
        {
            arr.Sort();
            var pairs = new List<int>();
            var smallest = int.MaxValue;

            for (var i = 0; i < arr.Count - 1; i++)
            {
                var diff = Math.Abs(arr[i + 1] - arr[i]);
                if (diff <= smallest)
                {
                    if (diff < smallest)
                    {
                        pairs.Clear();
                        smallest = diff;
                    }
                    pairs.Add(arr[i]);
                    pairs.Add(arr[i + 1]);
                }
            }
            return pairs;
        }

    }
}