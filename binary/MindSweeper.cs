using System;
using System.Collections.Generic;

namespace MindSweeper
{
    public class MindSweeper
    {
        //creating MindSweeper game board 

        static void Main(string[] args)
        {
            int[,] board = GetBoard(10, 10, 4);
            for(int i = 0; i < board.GetLength(0); i++){
                for(int j = 0; j < board.GetLength(1); j++){
                    System.Console.Write(board[i, j] + ", ");
                }
                System.Console.WriteLine("\n");
            }
        }

        static int[,] GetBoard(int width, int height, int mines){
            int[,] board = new int [width,height];
            Random rnd = new Random();
            int[] surCol = {-1, 0, 1,
                            -1, 0, 1,
                            -1, 0, 1};
            int [] surRow = {-1, -1, -1,
                                0, 0, 0,
                                1, 1, 1};

            while(mines > 0){
                int rndRow = rnd.Next(width);
                int rndCol = rnd.Next(height);
                if(board[rndRow, rndCol] != 9){
                    board[rndRow, rndCol] = 9;
                    mines--;
                    for(int j = 0; j < surCol.Length; j++){
                        if(rndRow+surRow[j] >= 0 && rndCol+surCol[j] >= 0 &&
                            rndRow+surRow[j] < board.GetLength(0) && rndCol+surCol[j] < board.GetLength(1)){
                            if( board[rndRow+surRow[j], rndCol+surCol[j]]==9){
                                continue;
                            }
                            if(board[rndRow+surRow[j], rndCol+surCol[j]] > 0 && board[rndRow+surRow[j], rndCol+surCol[j]]!=9){
                                board[rndRow+surRow[j], rndCol+surCol[j]]++;
                            }else if(board[rndRow+surRow[j], rndCol+surCol[j]]!=9){
                                board[rndRow+surRow[j], rndCol+surCol[j]] = 1;
                            }
                        }
                    }
                }
            }
            return board;
        }
    }
}