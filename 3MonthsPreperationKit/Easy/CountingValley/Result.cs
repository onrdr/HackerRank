namespace CountingValley
{
    class Result
    { 
        public static int CountingValleys(int steps, string path)
        {
            int currentHeight = 0, result = 0; 

            foreach (char c in path)
            {
                if (c.Equals('D'))
                {
                    if (currentHeight == 0) 
                        result++;
                    currentHeight--;
                    continue;
                } 
                currentHeight++;
            } 
            return result;
        } 
    }
}