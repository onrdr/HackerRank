namespace LonelyInteger
{
    class Result
    {
        public static int LonelyIntegerFirstWay(List<int> list)
        {
            int unique = 0;
            foreach (var i in list)
                unique ^= i;
            return unique;
        }

        public static int LonelyIntegerSecondWay(List<int> a)
        {
            int lonelyNumber = 0;
            foreach (int value in a)
            {
                if (a.IndexOf(value) == a.LastIndexOf(value))
                    lonelyNumber = value;
            }
            return lonelyNumber;
        }

        public static int LonelyIntegerThirdWay(List<int> arr)
        {
            int lonelyNumber = 0;
            var numDict = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (!numDict.ContainsKey(num))
                    numDict.Add(num, 1); 
                else
                    numDict[num]++; 
            }
            foreach (var pair in numDict)
            {
                if (pair.Value == 1)
                    lonelyNumber = pair.Key; 
            }
            return lonelyNumber; 
        }
    }
}