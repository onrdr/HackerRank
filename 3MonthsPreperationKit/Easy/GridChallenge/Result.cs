class Result
{ 
    public static string GridChallenge(List<string> grid)
    {
        for (int i = 0; i < grid.Count; i++) 
            grid[i] =  string.Concat(grid[i].OrderBy(c => c)); 

        for (int i = 0; i < grid.Count - 1; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] > grid[i + 1][j]) 
                    return "NO"; 
            } 
        }
        return "YES"; 
    } 
}