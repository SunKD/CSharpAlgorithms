using System;
using System.Collections.Generic;
using System.Text;

// Given an integer, convert it to a roman numeral. Input can be any value between 1 to 999.
// Roman symbols: 
// I, V, X, L, C, D and M.
// e.g 
// Input : 746
// Output: DCCXLVI 
namespace binary
{
    public class Roman{

        static void Main(string[] args){
            System.Console.WriteLine(numToRoman(794));
            System.Console.WriteLine(numToRoman(999));
        }
        public static string numToRoman(int num){
            string[] romans = new string[] {"I", "V", "X", "L", "C", "D", "M"};
            int [] numbers = new int[]{1, 5, 10, 50, 100, 500, 1000};
            List<int> result = new List<int>();
            for(int i = numbers.Length-1; i >= 0; i--){
                result.Add(num/numbers[i]);
                num = num % numbers[i];
            }
            StringBuilder resultStr = new StringBuilder();
            for(int i = romans.Length-1, j = 0; i >=0; i--, j++){
                if(result[j]== 4){
                    resultStr.Append(romans[i]).Append(romans[i+1]);
                    continue;
                }
                if(result[j]+ result[j+1] == 5){
                    resultStr.Append(romans[i-1]).Append(romans[i+1]);
                    i--;
                    j++;
                    continue;
                }
                if(result[j] != 0){
                    for(int k = 0; k <result[j]; k++){
                        resultStr.Append(romans[i]);
                    }
                }
            }
            return resultStr.ToString();
        }


    }
}

    