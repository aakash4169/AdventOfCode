using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day2.Puzzle2
{
    public static class Puzzle
    {
        static Dictionary<char, char> winnerMapping = new Dictionary<char, char>();
        static Dictionary<char, char> drawMapping = new Dictionary<char, char>();
        static Dictionary<char, char> loseMapping = new Dictionary<char, char>();
        static Dictionary<char, int> pointsMapping = new Dictionary<char, int>();
        static int totalPoints = 0;
        public static void Solution()
        {
            winnerMapping.Add('A', 'Y');
            winnerMapping.Add('B', 'Z');
            winnerMapping.Add('C', 'X');

            drawMapping.Add('A', 'X');
            drawMapping.Add('B', 'Y');
            drawMapping.Add('C', 'Z');

            loseMapping.Add('A', 'Z');
            loseMapping.Add('B', 'X');
            loseMapping.Add('C', 'Y');

            pointsMapping.Add('X', 1);
            pointsMapping.Add('Y', 2);
            pointsMapping.Add('Z', 3);

            foreach (string line in File.ReadLines(@"C:\Users\akki4\source\repos\AdventOfCode\AdventOfCode\Day2\Puzzle2\input.txt"))
            {
                char toDo = line[2];
                char moveToPlay = '\0';

                if(toDo=='X')
                {
                     moveToPlay = loseMapping[line[0]];
                    

                }
                else if (toDo =='Y')
                {
                    totalPoints += 3;
                     moveToPlay = drawMapping[line[0]];
                    
                }
                else
                {
                    totalPoints += 6;
                     moveToPlay = winnerMapping[line[0]];
                    
                }

                totalPoints += pointsMapping[moveToPlay];

                // break;

            }
            Console.WriteLine(totalPoints);
        }
    }
}
