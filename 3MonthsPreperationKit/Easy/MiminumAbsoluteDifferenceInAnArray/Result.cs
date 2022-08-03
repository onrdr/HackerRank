namespace MiminumAbsoluteDifferenceInAnArray
{
    class Result
    {
        public static int MinimumAbsoluteDifference(List<int> arr)
        {
            arr.Sort();
            int smallest = int.MaxValue;

            for (int i = 0; i < arr.Count - 1; i++) 
                smallest = Math.Min(smallest, arr[i + 1] - arr[i]);  

            return smallest;
        }

    }
}