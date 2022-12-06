using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day5.Puzzle1
{
    public static class Puzzle
    {
        static Stack<char> myStack1 = new Stack<char>("PFMQWGRT");
        static Stack<char> myStack2 = new Stack<char>("HFR");
        static Stack<char> myStack3 = new Stack<char>("PZRVGHSD");
        static Stack<char> myStack4 = new Stack<char>("QHPBFWG");


        static Stack<char> myStack5 = new Stack<char>("PSMJH");
        static Stack<char> myStack6 = new Stack<char>("MZTHSRPL");
        static Stack<char> myStack7 = new Stack<char>("PTHNML");
        static Stack<char> myStack8 = new Stack<char>("FDQR");
        static Stack<char> myStack9 = new Stack<char>("DSCNLPH");


        static Dictionary<int,Stack<char>> stackMapping=new Dictionary<int, Stack<char>>();
        static Puzzle(){
                    

            stackMapping.Add(1, myStack1);
            stackMapping.Add(2, myStack2);
            stackMapping.Add(3, myStack3);
            stackMapping.Add(4, myStack4);
            stackMapping.Add(5, myStack5);
            stackMapping.Add(6, myStack6);
            stackMapping.Add(7, myStack7);
            stackMapping.Add(8, myStack8);
            stackMapping.Add(9, myStack9);
        }
        public static void Solution()
        {
            foreach (string line in File.ReadLines(@"C:\Users\akki4\source\repos\AdventOfCode\AdventOfCode\Day5\Puzzle1\input.txt"))
            {
                string[] input = line.Split(' ');
               

                int moveNumber = int.Parse(input[1]);
                Stack<char> fromStack = stackMapping[int.Parse(input[3])];
                Stack<char> toStack = stackMapping[int.Parse(input[5])];

                while(moveNumber>0)
                {
                    char crate=fromStack.Pop();
                    toStack.Push(crate);
                    moveNumber--;
                }

            }

            Console.Write(myStack1.Peek());
            Console.Write(myStack2.Peek());
            Console.Write(myStack3.Peek());
            Console.Write(myStack4.Peek());
            Console.Write(myStack5.Peek());
            Console.Write(myStack6.Peek());
            Console.Write(myStack7.Peek());
            Console.Write(myStack8.Peek());
            Console.WriteLine(myStack9.Peek());
        }
    }
}
