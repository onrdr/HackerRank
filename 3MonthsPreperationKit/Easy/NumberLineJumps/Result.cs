namespace NumberLineJumps
{
    class Result
    {
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2 && Math.Abs(x1 - x2) % Math.Abs(v1 - v2) == 0)
                return "YES"; 

            return "NO";
        }

    }
}