
using System;
using System.Collections.Generic;

// Given an array of integers of size N. Assume ‘0’ as invalid number and all other as valid number. 
//Write a program that modifies the array in such a way that if next number is  valid number and is same as current number, 
//double the current number value and replace the next number with 0. 
//After the modification, rearrange the array such that all 0’s are shifted to the end 
//and the sequence of the valid number or new doubled number is maintained as in the original array.

namespace binary
{
    static public class EaseArr
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 2, 0, 4, 0, 8 };
            int[] arr2 = { 0, 2, 2, 2, 0, 6, 6, 0, 0, 8 };
            int[] result = easeArr(arr2);
            for (int i = 0; i < result.Length; i++)
            {
                System.Console.WriteLine(result[i]);
            }
        }

        static int[] easeArr(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != 0 && arr[i] == arr[i + 1])
                {
                    arr[i] = arr[i] * 2;
                    arr[i + 1] = 0;
                }
            }
            int sortedIdk = 0;
            int runner = 0;
            while (runner < arr.Length)
            {
                if (arr[sortedIdk] != 0)
                {
                    sortedIdk++;
                    runner++;
                }
                if (arr[runner] == 0)
                {
                    runner++;
                }
                if (arr[sortedIdk] != arr[runner])
                {
                    int temp = 0;
                    arr[sortedIdk] = arr[runner];
                    arr[runner] = temp;
                    sortedIdk++;
                    runner++;
                }
            }
            return arr;
        }
    }
}
