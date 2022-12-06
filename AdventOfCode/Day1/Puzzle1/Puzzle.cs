using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day1.Puzzle1
{
    public static class Puzzle
    {
        static int max = 0;
        public static void Solution()
        {
            int tempMax = 0;
            foreach (string line in File.ReadLines(@"C:\Users\akki4\source\repos\AdventOfCode\AdventOfCode\Day1\Puzzle1\input.txt"))
            {
                if (line == "")
                {
                    if (tempMax > max)
                        max = tempMax;
                    tempMax = 0;
                }
                else
                {
                    int cal = int.Parse(line);
                    tempMax += cal;
                }

            }

            Console.WriteLine(max);
        }
    }
}
