namespace LeftRotation
{
    class Result
    {
        public static List<int> RotateLeft(int d, List<int> arr)
        {
            while (d-- > 0)
            {
                int firstItem = arr[0];
                arr.Remove(firstItem);
                arr.Insert(arr.Count, firstItem); 
            } 
            return arr;
        }
    }
}