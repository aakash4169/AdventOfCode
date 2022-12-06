using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day2.Puzzle1
{
    public static class Puzzle
    {
        static Dictionary<char, char> winnerMapping = new Dictionary<char, char>();
        static Dictionary<char, int> pointsMapping = new Dictionary<char, int>();
        static Dictionary<char, char> player1ToPlayer2Mapping = new Dictionary<char, char>();
        static int totalPoints = 0;
        public static void Solution()
        {
            winnerMapping.Add('A','Y');
            winnerMapping.Add('B', 'Z');
            winnerMapping.Add('C', 'X');

            pointsMapping.Add('X', 1);
            pointsMapping.Add('Y', 2);
            pointsMapping.Add('Z', 3);

            player1ToPlayer2Mapping.Add('A', 'X');
            player1ToPlayer2Mapping.Add('B', 'Y');
            player1ToPlayer2Mapping.Add('C', 'Z');

            foreach (string line in File.ReadLines(@"C:\Users\akki4\source\repos\AdventOfCode\AdventOfCode\Day2\Puzzle1\input.txt"))
            {
                char winner = winnerMapping[line[0]];
                if (winner == line[2])
                {
                    totalPoints += 6;
                }
                else if (player1ToPlayer2Mapping[line[0]] == line[2])
                {
                    totalPoints += 3;
                }
                int points = pointsMapping[line[2]];
                totalPoints += points;
                
               // break;
                
            }
            Console.WriteLine(totalPoints);
        }
    }
}
