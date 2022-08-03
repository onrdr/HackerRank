namespace ParallelProcessing
{
    class Result
    {
        public static long MinTime(List<int> files, int numCores, int limit)
        {
            long sum = 0;
            var list = new List<int>();
            long limitCounter = 0;

            if (numCores == 1 || limit == 0)
            {
                foreach (var i in files)
                    sum += i;
                return sum;
            }

            foreach (var i in files)
            {
                if (i % numCores == 0)
                {
                    list.Add(i);
                    continue;
                }
                sum += i;
            }

            list.Sort();
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                sum += (list[i] / numCores);
                limitCounter++;

                if (limitCounter == limit)
                    break;
            }

            for (int i = limit; i < list.Count; i++)
                sum += list[i];
             

            return sum;
        }
    }


}