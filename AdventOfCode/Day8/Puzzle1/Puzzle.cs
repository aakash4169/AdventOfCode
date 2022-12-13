using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode.Day8.Puzzle1
{
    public static class Puzzle
    {
        public static void Solution()
        {
            
            var line1 = File.ReadLines(@"..\..\..\..\AdventOfCode\Day8\Puzzle1\input.txt");
            int[,] input = new int[line1.Count(), line1.Count()];
            int j = 0;
            foreach (string line in File.ReadLines(@"..\..\..\..\AdventOfCode\Day8\Puzzle1\input.txt"))
            {
                
                for (int i = 0; i < line.Length; i++)
                {
                    input[j,i] = int.Parse(line[i].ToString());
              
                }
                j++;

            }

            int[,] nextGreaterRightRow = new int[input.GetLength(0), input.GetLength(1)];
            int[,] nextGreaterLeftRow = new int[input.GetLength(0), input.GetLength(1)];
            int[,] nextGreaterAboveColumn = new int[input.GetLength(1), input.GetLength(0)];
            int[,] nextGreaterBelowColumn = new int[input.GetLength(1), input.GetLength(0)];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int k = 0; k < input.GetLength(1); k++)
                {
                    nextGreaterRightRow[i, k] = -1;
                    nextGreaterLeftRow[i, k] = -1;
                    nextGreaterAboveColumn[i, k] = -1;
                    nextGreaterBelowColumn[i, k] = -1;
                }

            }

            for (int i=0;i<input.GetLength(0);i++)
            {
                findNextGreaterRightRow(nextGreaterRightRow, input,i);
            }

            for (int i = 0; i < input.GetLength(0); i++)
            {
                findNextGreaterLeftRow(nextGreaterLeftRow, input, i);
            }

            int count = 0;

            int[,] transposeInput = new int[input.GetLength(1), input.GetLength(0)];

            for(int k=0;k<input.GetLength(1);k++)
            {
                for (int i = 0; i < input.GetLength(0); i++)
                {
                    transposeInput[k, i] = input[i, k];
                    
                }
               
            }

            for (int i = 0; i < input.GetLength(0); i++)
            {
                findNextGreaterLeftRow(nextGreaterAboveColumn, transposeInput, i);
            }

            for (int i = 0; i < input.GetLength(0); i++)
            {
                findNextGreaterRightRow(nextGreaterBelowColumn, transposeInput, i);
            }

            int[,] aboveGreaterTranspose = new int[nextGreaterAboveColumn.GetLength(1), nextGreaterAboveColumn.GetLength(0)];

            for (int k = 0; k < nextGreaterAboveColumn.GetLength(1); k++)
            {
                for (int i = 0; i < nextGreaterAboveColumn.GetLength(0); i++)
                {
                    aboveGreaterTranspose[i, k] = nextGreaterAboveColumn[k, i];

                }
               
            }

           

            int[,] belowGreaterTranspose = new int[nextGreaterAboveColumn.GetLength(1), nextGreaterAboveColumn.GetLength(0)];

            for (int k = 0; k < nextGreaterBelowColumn.GetLength(1); k++)
            {
                for (int i = 0; i < nextGreaterBelowColumn.GetLength(0); i++)
                {
                    belowGreaterTranspose[i, k] = nextGreaterBelowColumn[k, i];
                }
            }

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int k = 0; k < input.GetLength(1); k++)
                {
                    if (nextGreaterLeftRow[i,k]==-1 || nextGreaterRightRow[i, k] == -1 || aboveGreaterTranspose[i, k] == -1 || belowGreaterTranspose[i, k] == -1)
                    {
                        count++;
                    }
                }
            }
            
            Console.WriteLine(count);

        }

       static void findNextGreaterRightRow(int[,] nextGreaterRightRow, int[,] input,int rowIndex)
        {
            
            Stack<int> heights = new Stack<int>();
            for (int k = 0; k < input.GetLength(0); k++)
            {
                while(heights.Count()>0 && input[rowIndex,heights.Peek()] <= input[rowIndex,k])
                {
                    int index = heights.Pop();
                    nextGreaterRightRow[rowIndex, index] = input[rowIndex, k];
                }
                heights.Push(k);
            }
        }

        static void findNextGreaterLeftRow(int[,] nextGreaterLeftRow, int[,] input, int rowIndex)
        {

            Stack<int> heights = new Stack<int>();
            for (int k = input.GetLength(0)-1; k >=0; k--)
            {
                while (heights.Count() > 0 && input[rowIndex, heights.Peek()] <= input[rowIndex, k])
                {
                    int index = heights.Pop();
                    nextGreaterLeftRow[rowIndex, index] = input[rowIndex, k];
                }
                heights.Push(k);
            }
        }
    }
}