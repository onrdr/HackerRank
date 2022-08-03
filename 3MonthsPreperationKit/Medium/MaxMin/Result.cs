namespace MaxMin
{
    class Result
    {
        public static int MaxMin(int k, List<int> arr)
        {
            arr.Sort();
            int min = int.MaxValue;

            for (int i = 0; i < arr.Count - k + 1; i++)
            {
                int diff = arr[k - 1 + i] - arr[i];
                if (diff < min) 
                    min = diff; 
            }  
            return min;
        }

    }

}