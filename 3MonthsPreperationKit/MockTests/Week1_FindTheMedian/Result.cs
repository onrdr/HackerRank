namespace Week1_FindTheMedian
{
    class Result
    { 
        public static int FindMedian(List<int> arr)
        {
            arr.Sort();
            return arr[arr.Count / 2];
        } 
    }
}