

class Result
{
    public static List<int> MissingNumbers(List<int> arr, List<int> brr)
    { 
        arr.ForEach(i => brr.Remove(i));
        return brr.Distinct().OrderBy(i => i).ToList();
    }

}