using System;
using System.Collections.Generic;

namespace maxArea
{
// Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). 
// n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
//Find two lines, which together with x-axis forms a container, such that the container contains the most water.

    static public class Area
    {
        static void Main(string[] args)
        {
            int [] arr = {1, 8, 6, 2, 5, 4, 8, 3, 7};
            System.Console.WriteLine(MaxArea(arr));
        }

        public static int MaxArea(int[] height) {
            int maxArea = 0;
            int left = 0; 
            int right = height.Length-1;
            while(left < right){
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right-left));
                if(height[left] < height[right]){
                    left++;
                }else{
                    right--;
                }
            } 
            return maxArea;
        } 
    }
}
