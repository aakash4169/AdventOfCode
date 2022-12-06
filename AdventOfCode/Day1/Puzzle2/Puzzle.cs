using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day1.Puzzle2
{
    public static class Puzzle
    {
        static int max1 = 0;
        static int max2 = 0;
        static int max3 = 0;
        public static void Solution()
        {
            int tempMax = 0;
            foreach (string line in File.ReadLines(@"C:\Users\akki4\source\repos\AdventOfCode\AdventOfCode\Day1\Puzzle2\input.txt"))
            {
                if (line == "")
                {
                    if (tempMax > max3)
                    {
                        if (tempMax > max2)
                        {
                            if (tempMax > max1)
                            {
                                max3 = max2;
                                max2 = max1;
                                max1 = tempMax;
                            }
                            else
                            {
                                max3 = max2;
                                max2 = tempMax;
                            }
                        }
                        else
                        {
                            max3 = tempMax;
                        }
                    }
                    tempMax = 0;
                }
                else
                {
                    int cal = int.Parse(line);
                    tempMax += cal;
                }

            }

            Console.WriteLine(max1 + max2 + max3);
        }
    }
}
