namespace Week2_FlippingTheMatrix
{
    class Result
    {
        public static int FlippingMatrix(List<List<int>> matrix)
        {
            var len = matrix.Count;
            var half = len / 2;
            var sum = 0;

            for (int i = 0; i < half; i++)
            {
                for (int j = 0; j < half; j++)
                {
                    var value1 = matrix[i][j];
                    var value2 = matrix[i][len - j - 1];
                    var value3 = matrix[len - i - 1][j];
                    var value4 = matrix[len - i - 1][len - j - 1];
                    sum += new int[] { value1, value2, value3, value4 }.Max();
                }
            }
            return sum;
        }
    }
}