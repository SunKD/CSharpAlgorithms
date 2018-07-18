using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
    // Given two integers n and m. The problem is to find the number closest to n and divisible by m. 
    // If there are more than one such number, then output the one having maximum absolute value. 
    // Time complexity of O(1) is required.
    public class ClosestNum
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(ClosestNumber(13, 4) + " expected: 12");
            System.Console.WriteLine(ClosestNumber(15, 4) + " expected: 16");
            System.Console.WriteLine(ClosestNumber(-13, 6) + " expected: -12");
            System.Console.WriteLine(ClosestNumber(-15, 6) + " expected: -18");
        }

        static double ClosestNumber(int n, int m)
        {
            double num = (double)n / m;
            if (Math.Abs(n % m) >= (m / 2))
            {
                if (n < 0)
                {
                    return (Math.Floor(num)) * m;
                }
                return Math.Ceiling(num) * m;
            }
            else
            {
                if (n < 0)
                {
                    return (Math.Ceiling(num)) * m;
                }
                return (Math.Floor(num)) * m;
            }
        }
    }
}