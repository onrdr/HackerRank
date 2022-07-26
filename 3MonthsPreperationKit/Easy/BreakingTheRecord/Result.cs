namespace BreakingTheRecord
{
    class Result
    {  
        public static List<int> BreakingRecords(List<int> scores)
        {
            List<int> result = new();
            int maxScore = scores[0], minScore = scores[0];
            int maxScoreCount = 0, minScoreCount = 0; 

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    maxScoreCount++;
                }
                if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    minScoreCount++;
                }
            }  
            result.Add(maxScoreCount);
            result.Add(minScoreCount);
            return result;
        }

    }
}