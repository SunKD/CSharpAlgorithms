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
    public class CrossWordFinder
    {
        static void Main(string[] args)
        {
            char[][] letters = new char[][] {new []{'g', 'f', 'c', 'r', 'y'},
                                            new []{'i', 'h', 'o', 'm', 'e'},
                                            new []{'u', 'j', 'd', 'w', 'b'},
                                            new []{'z', 'x', 'v', 'q', 'r'},
                                            new []{'o', 's', 'l', 'n', 'p'}};
            System.Console.WriteLine(isWordThere(letters, "row") + " expected output: false");
            System.Console.WriteLine(isWordThere(letters, "chow") + " expected output: false");
            System.Console.WriteLine(isWordThere(letters, "home") + " expected output: true");
            System.Console.WriteLine(isWordThere(letters, "cry") + " expected output: true");
        }
        public static bool isWordThere(char[][] arr, string word)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == word[0])
                    {
                        int countVer = 1;
                        int countHor = 1;
                        for (int k = 1; k < word.Length; k++)
                        {
                            if (j + k < arr[i].Length)
                            {
                                if (arr[i][j + k] == word[k])
                                {
                                    countHor++;
                                }
                            }
                            if (i + k < arr.Length)
                            {
                                if (arr[i + k][j] == word[k])
                                {
                                    countVer++;
                                }
                            }
                            if (countHor == word.Length || countVer == word.Length)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}




