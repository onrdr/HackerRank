
using System.Numerics;

class Result
{
    public static string FibonacciModified(BigInteger t1, BigInteger t2, BigInteger n)
    {
        BigInteger result = 0;
        for (int i = 0; i < n - 2; i++)
        {
            result = t1 + (t2 * t2);
            t1 = t2;
            t2 = result;
        }
        return result.ToString(); 
    }
}