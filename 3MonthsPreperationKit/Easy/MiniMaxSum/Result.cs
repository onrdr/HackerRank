namespace MiniMaxSum;

internal class Result
{ 
    public static void MiniMaxSum(List<int> arr)
    { 
        long sum = 0; 
        foreach (var n in arr)
            sum += n; 

        Console.WriteLine($"{sum - arr.Max()} {sum - arr.Min()}");
    }

}