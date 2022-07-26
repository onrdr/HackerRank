namespace SparseArrays
{
    class Result
    {
        public static List<int> MatchingStrings(List<string> strings, List<string> queries)
        { 
            return queries.Select(q => strings.Where(x => x == q).Count()).ToList();
        } 
    } 
}