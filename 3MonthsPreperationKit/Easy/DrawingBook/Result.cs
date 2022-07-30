namespace DrawingBook
{
    class Result
    {
        public static int PageCount(int n, int p)
        { 
            if (p <= n / 2) 
                return p / 2; 
             
            if (n % 2 == 0 && n - p == 1)
                return (n - p + 1) / 2;

            return (n - p) / 2;
        }

        public static int PageCount2(int n, int p)
        {
            return ((p > n / 2) ? n / 2 - p / 2 : p / 2);
        }
    }
}