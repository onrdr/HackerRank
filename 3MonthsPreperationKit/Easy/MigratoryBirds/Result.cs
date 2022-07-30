namespace MigratoryBirds
{
    class Result
    {
        public static int MigratoryBirds(List<int> list)
        {
            int[] arr = new int[6];
            int mostRepeatedNum = 0;
            int maxRepeatCounter = 0;

            foreach (var i in list)
                arr[i]++; 

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > maxRepeatCounter)
                {
                    maxRepeatCounter = arr[i];
                    mostRepeatedNum = i;
                }
            return mostRepeatedNum; 
        }
    }
}