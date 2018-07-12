// using System;
// using System.Collections.Generic;

// namespace binary
// {
    

// // Where n is a number, sort all numbers from 1 to n in alphabetical order with out using any pre defined functions

// // e.g given 22, return: [1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,3,4,5,6,7,8,9] 



//     static public class numtoString{

//         static void Main(string[] args){
//         List<string> str = sortedNumAlphabet(37);
//         for(int i = 0; i < str.Count; i++){
//             System.Console.WriteLine(str[i]);
//         }
//     }
//         static public List<String> sortedNumAlphabet(int num){

//             List<string> sorted = new List<string>();
//             int breakPoint = 0;
            
//             for(int i = 1; i <= num; i++){
//                 sorted.Add(i.ToString());
//                 for(int j = 0; j <=9; j++){
//                     sorted.Add(i.ToString() + j.ToString());
//                     if(i.ToString() + j.ToString() == num.ToString()){
//                         breakPoint = i+1;
//                         break;
//                     }
//                 }
//                 if(breakPoint != 0){
//                     break;
//                 }
//             }
//             for(int i = breakPoint; i <= 9; i++){
//                 sorted.Add(i.ToString());
//             }
//             return sorted;
//         }
//     }
    

    
// }