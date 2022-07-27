﻿namespace MarsExploration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Result.MarsExploration("SOSTOT"));
            Console.WriteLine(Result.MarsExploration("SOSSPSSQSSOR")); 

            Console.ReadKey();
        }
    }
    class Result
    { 
        public static int MarsExploration(string s)
        {
            string original = "SOS"; 
            int result = 0; 

            for (int i = 0; i < s.Length; i++) 
                result += (original[i%3] == s[i]) ? 0 : 1; 

            return result;
        } 
    }
}