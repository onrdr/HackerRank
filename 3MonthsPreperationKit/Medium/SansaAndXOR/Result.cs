


class Result
{ 
    public static int SansaXor(List<int> arr)
    { 
        if (arr.Count % 2 == 0)
            return 0;

        int res = 0;
        for (int i = 0; i < arr.Count; i+=2) 
            res ^= arr[i];   
        return res;
    }

}