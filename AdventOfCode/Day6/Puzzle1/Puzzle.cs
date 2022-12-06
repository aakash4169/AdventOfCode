using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day6.Puzzle1
{
public static class Puzzle
{
    public static void Solution()
    {

            foreach (string line in File.ReadLines(@"..\..\..\..\AdventOfCode\Day6\Puzzle1\input.txt"))
            {
                int leftPtr = 0;
               
                HashSet<char> pattern = new HashSet<char>();

                for (int i = 0; i < line.Length; i++)
                {
                    char temp = line[i];
                    if (pattern.Contains(temp))
                    {
                        leftPtr++;
                        i = leftPtr - 1;
                        pattern.Clear();
                        //Not happy with this solution
                        //thinking of ways to optimize this
                    }
                    else
                    {
                        pattern.Add(temp);
                        if (pattern.Count == 4)
                        {
                            Console.WriteLine(i + 1);
                            break;
                        }
                       
                    }
                }
            }
        }
    }
}
