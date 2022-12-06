using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day4.Puzzle2
{

    public static class Puzzle
    {

        public static void Solution()
        {
            int sum = 0;
            foreach (string line in File.ReadLines(@"C:\Users\akki4\source\repos\AdventOfCode\AdventOfCode\Day4\Puzzle1\input.txt"))
            {
                string[] ranges = line.Split(',');
                

                string[] numbers1 = ranges[0].Split("-");
                string[] numbers2 = ranges[1].Split("-");



                int start1 = int.Parse(numbers1[0]);
                int end1 = int.Parse(numbers1[1]);

                int start2 = int.Parse(numbers2[0]);
                int end2 = int.Parse(numbers2[1]);




                if (start1 == start2 || end1==end2)
                {
                    sum++;
                }
                else if (start2 < start1)
                {
                    if(end2 >= start1)
                    {
                        sum++;
                    }
                }
                else if(start1<start2)
                {
                    if(end1>=start2)
                    {
                        sum++;
                    }
                }
            }


            Console.WriteLine(sum);
        }
    }
}
