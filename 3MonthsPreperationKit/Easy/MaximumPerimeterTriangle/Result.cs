namespace MaximumPerimeterTriangle
{
    class Result
    {
        public static List<int> MaximumPerimeterTriangle(List<int> sticks)
        {
            sticks.Sort();
            sticks.Reverse();

            for (int i = 0; i < sticks.Count - 2; i++)
            {
                if (sticks[i] < sticks[i + 1] + sticks[i + 2]) 
                    return new List<int> { sticks[i], sticks[i + 2] }; 
            }
            return new List<int> { -1 };
        }

    }

}