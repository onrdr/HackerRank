namespace FlippingBits
{
    internal class Result
    {
        internal static long FlippingBits(long n)
        {
            // (2^32 - 1) will have all 1's in its bits and we will use it as our mask 
            return n ^ (long)(Math.Pow(2, 32) - 1);
        }
    }

}