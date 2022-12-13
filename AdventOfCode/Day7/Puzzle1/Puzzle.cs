using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode.Day7.Puzzle1
{
public static class Puzzle
{
        static int sum = 0;
        
        public class TreeNode
        {
            public int size;
            public string name;
            public List<TreeNode> children=new List<TreeNode>();

            public TreeNode(string name)
            {
                this.name = name;
            }

            public void updateSize(int size)
            {
                this.size += size;
            }
        }
    public static void Solution()
    {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode root = new TreeNode("/");
            HashSet<TreeNode> visited = new HashSet<TreeNode>();
          //  root.name = "/";
            stack.Push(root);

            foreach (string line in File.ReadLines(@"..\..\..\..\AdventOfCode\Day7\Puzzle1\input.txt"))
            {
                TreeNode node=stack.Peek();
                string[] input = line.Split(' ');

                if (input[0].Equals("$"))
                {
                    if (input[1].Equals("cd"))
                    {
                        if (input[2].Equals("/"))
                        {
                            //stack.Push(node);
                        }
                        else
                        {
                            if (input[2].Equals(".."))
                            { 
                                stack.Pop();
                            }
                            else
                            {
                                TreeNode node2 = node.children.Find(x => x.name.Equals(input[2]));
                                stack.Push(node2);
                            }
                           
                        }
                        
                    }
                }
                else if (Regex.IsMatch(input[0], "^\\d"))
                {
                    node.updateSize(int.Parse(input[0]));
                }
                else if (input[0].Equals("dir"))
                {
                    node.children.Add(new TreeNode(input[1]));
                    //visited.Add(node);
                }
            }


            root.size=calculateSum(root);
            

            Console.WriteLine(sum);
            
        }

        static int calculateSum(TreeNode root)
        {
            if(root==null)
                return root.size;

            foreach (var item in root.children)
            {
                root.size+=calculateSum(item);
                

            }
            if (root.size <= 100000)
            {

                sum += root.size;
            }
            return root.size;
        }
    }
}
