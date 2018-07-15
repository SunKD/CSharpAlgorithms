using System;
using System.Collections.Generic;

namespace binary
{
    static public class TrappingRain
    {
        static void Main(string[] args)
        {
            int [] arr = {3, 1, 0, 1, 0, 2, 0, 1};
            System.Console.WriteLine(TrappedRain(arr));
        }
        public static int TrappedRain(int [] arr){
            int result = 0;
            int [] left = new int [arr.Length];
            int [] right = new int [arr.Length];

            left[0] = arr[0];
            for(int i = 1; i < arr.Length; i++){
                if(arr[i] > left[i-1]){
                    left[i] = arr[i];
                }else{
                    left[i] = left[i-1];
                }
            }

            right[arr.Length-1] = arr[arr.Length-1];
            for(int i = arr.Length-2; i >=0; i--){
                if(arr[i] > right[i+1]){
                    right[i] = arr[i];
                }else{
                    right[i] = right[i+1];
                }
            }

            for(int i = 0; i < arr.Length; i++){
                result += Math.Min(left[i], right[i]) - arr[i];
            }
            return result;
        }
    }
}