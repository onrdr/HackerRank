
namespace CountingSort1
{
    class Result
    { 
        public static List<int> CountingSort(List<int> arr)
        {
            int[] range = new int[100];

            foreach (int value in arr)
                range[value]++;

            return range.ToList();
        } 
    }

}