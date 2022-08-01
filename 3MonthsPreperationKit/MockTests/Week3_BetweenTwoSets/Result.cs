namespace Week3_BetweenTwoSets
{
    class Result
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            int result = 0;
            int startNum = a[^1];
            int endNum = b[0];
            bool flag = true;

            while (startNum <= endNum)
            {
                foreach (var i in a)
                {
                    flag = startNum % i == 0;
                    if (!flag)
                        break;
                } 
                if (flag)
                {
                    foreach (var i in b)
                    {
                        flag = i % startNum == 0;
                        if (!flag)
                            break;
                    } 
                }
                if (flag)
                    result++;
                startNum++;
            }
            return result;
        } 
    }
}