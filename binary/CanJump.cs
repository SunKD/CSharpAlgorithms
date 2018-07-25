using System;
using System.Collections.Generic;

namespace Jump
{

    public class Jump
    {
        static void Main(string[] args)
        {
            int [] arr = {2, 1, 3, 0, 4, 8};
            int [] arr2 = {1, 1, 3, 1};
            System.Console.WriteLine(CanJump(arr) + " Expected Output : true");
            System.Console.WriteLine(CanJump(arr2) + " Expected Output : false");
        }

        static bool CanJump(int [] arr){
            if(arr == null){
                return false;
            }
            if(arr[0] > 1 && arr.Length < 2){
                return false;
            }
            int i = 0;
            while(true){
                int jump = arr[i];
                if(i+jump > arr.Length){
                    return false;
                }
                if(i+jump == arr.Length-1){
                    return true;
                }
                i += jump;
            }
        }
    }


}