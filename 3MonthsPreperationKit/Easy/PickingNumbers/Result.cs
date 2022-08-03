namespace PickingNumbers
{
    class Result
    {
        public static int PickingNumbers(List<int> a)
        {
            int maxSubArrSize = 0;
            a.Sort();
            for (int i = 0; i < a.Count - 1; i++)
            {
                int subArrSize = 1;
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (Math.Abs(a[i] - a[j]) <= 1) 
                        subArrSize++; 
                    else 
                        break; 
                }
                if (subArrSize > maxSubArrSize) 
                    maxSubArrSize = subArrSize; 
            }
            return maxSubArrSize;
        }

        public static int PickingNumbers2(List<int> a)
        {
            int[] arr = new int[100];

            for (int i = 0; i < a.Count; i++) 
                arr[a[i] - 1] += 1; 

            int maxSum = 0;
            for (int i = 0; i < a.Count - 1; i++)
            {
                int currentSum = arr[i] + arr[i + 1];
                if (currentSum > maxSum)
                    maxSum = currentSum;
            }
            return maxSum;
        }
    }
}