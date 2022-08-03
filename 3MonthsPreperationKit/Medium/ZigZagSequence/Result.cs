namespace ZigZagSequence
{
    class Result
    {
        public static void FindZigZagSequence(List<int> list, int n)
        {
            list.Sort();
            int mid = n / 2;
            int temp = list[mid];

            list[mid] = list[n - 1];
            list[n - 1] = temp;

            int st = mid + 1;
            int ed = n - 2;
            while (st <= ed)
            {
                temp = list[st];
                list[st] = list[ed];
                list[ed] = temp;
                st++;
                ed--;
            }
            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                    Console.WriteLine(" ");
                Console.WriteLine(list[i]);
            } 
        }
    }
}