using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day3.Puzzle2
{
    
    public static class Puzzle
    {
        static Dictionary<char, int> prioritize = new Dictionary<char, int>();
        static int sum = 0;
        static Puzzle()
        {
            
            char a = 'a';
            for (int i = 1; i <= 26; i++)
            {
                prioritize[a] = i;
                a++;
            }

                a = 'A';

            for (int i = 27; i <= 52; i++)
            {
                prioritize[a] = i;
                a++;
            }
            
        }

        public static void Solution()
        {
            HashSet<char> charsInString1 = new HashSet<char>();
            HashSet<char> charsInString2 = new HashSet<char>();
            int inputGroupCounter = 1;
           
            int sum = 0;
            foreach (string line in File.ReadLines(@"C:\Users\akki4\source\repos\AdventOfCode\AdventOfCode\Day3\Puzzle2\input.txt"))
            {
                if(inputGroupCounter==1)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        charsInString1.Add(line[i]);
                    }
                    inputGroupCounter++;
                }
                else if(inputGroupCounter== 2)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        charsInString2.Add(line[i]);
                    }
                    inputGroupCounter++;
                }
                else if (inputGroupCounter == 3)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (charsInString1.Contains(line[i]) && charsInString2.Contains(line[i]))
                        {
                           
                                inputGroupCounter=1;
                                sum += prioritize[line[i]];
                                charsInString1.Clear();
                            charsInString2.Clear();
                            break;
                           
                            
                        }
                    }
                }




            }
            

            Console.WriteLine(sum);
        }
    }
}
