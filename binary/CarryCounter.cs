using System;
using System.Collections.Generic;

namespace Carry
{

    public class Carry
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(CarryCounter(293, 8) + " Expected: 2");
            System.Console.WriteLine(CarryCounter(993, 28) + " Expected: 3");
            System.Console.WriteLine(CarryCounter(345, 234) + " Expected: 0");
            System.Console.WriteLine(CarryCounter(2345, 535) + " Expected: 1");
        }

        static int CarryCounter(int num1, int num2){
            bool carry = false;
            int count = 0;
            
            List<int> num1List = new List<int>();
            List<int> num2List = new List<int>();
            while(num1 > 10){
                num1List.Add(num1 % 10);
                num1 = num1 / 10; 
            }
            num1List.Add(num1);
            while(num2 > 10){
                num2List.Add(num2 % 10);
                num2 = num2 / 10; 
            }
            num2List.Add(num2);

            List<int> shorterLen = num1List.Count > num2List.Count? num2List: num1List;
            List<int> longerLen = num1List.Count <= num2List.Count? num2List: num1List;

            int p = 0;
            while(p < shorterLen.Count){
                carry = false;
                if(shorterLen[p] + longerLen[p] >= 10){
                    carry = true;
                    count++;
                }
                p++;
            }
            if(carry && shorterLen.Count != longerLen.Count){
                if(longerLen[p] + 1 >= 10){
                    count++;
                }
            }
            return count;
        }
    }
}