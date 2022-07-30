namespace SalesByMatch
{
    class Result
    {  
        public static int SockMerchant(int n, List<int> list)
        {
            list.Sort();
            int counter = 0; 

            for (int i = 0; i < n - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    counter++;
                    i++;
                }
            }
            return counter;
        }
    }
}