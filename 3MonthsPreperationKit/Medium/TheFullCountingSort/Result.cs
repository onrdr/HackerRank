class Result
{
    public static void CountSort(List<List<string>> arr)
    {
        for (int i = 0; i < arr.Count / 2; i++)
            arr[i][1] = "-";
        int counter = 0;

        while (counter <= arr.Count)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (int.Parse(arr[i][0]) == counter)
                    Console.Write($"{arr[i][1]} ");
            }
            counter++;
        }
    }
    public static void CountSort2(List<List<string>> arr)
    {
        for (int i = 0; i < arr.Count / 2; i++)
            arr[i][1] = "-";
        int counter = 0;

        while (counter <= arr.Count)
        {
            arr.Where(list => int.Parse(list[0]) == counter).ToList().ForEach(str => Console.Write($"{str[1]} "));
            counter++;
        }
    } 
    public static void CountSort3(List<List<string>> arr)
    {
        Console.WriteLine(String.Join(" ", arr
            .Select((x, idx) => new { num = int.Parse(x[0]), str = idx < arr.Count / 2 ? "-" : x[1] })
            .OrderBy(x => x.num)
            .Select(x => x.str)));
    }
}