using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day3.Puzzle1
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
            HashSet<char> charsInString = new HashSet<char>();
            foreach (string line in File.ReadLines(@"C:\Users\akki4\source\repos\AdventOfCode\AdventOfCode\Day3\Puzzle1\input.txt"))
            {
                
                int mid = line.Length / 2;
                
                for(int i=0;i<mid;i++)
                {
                    charsInString.Add(line[i]);
                }
                for(int i = mid; i < line.Length; i++)
                {
                    if (charsInString.Contains(line[i]))
                    {
                       
                        sum+= prioritize[line[i]];
                        charsInString.Clear();
                        break;
                    }
                }
               
            }
            

            Console.WriteLine(sum);
        }
    }
}
