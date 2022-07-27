namespace DiagonalDifference
{
    class Result
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int sumLeftToRight = 0, sumRighToLeft = 0;
            int count = arr.Count;

            for (int i = 0; i < count; i++)
            {
                sumLeftToRight += arr[i][i];
                sumRighToLeft += arr[i][count - i - 1];
            } 
            return Math.Abs(sumLeftToRight - sumRighToLeft); 
        }
    }
}