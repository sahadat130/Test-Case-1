using System;
using System.Collections.Generic;

namespace Test_Case_1
{
    public class Program
    {
        List<int> LIST = new List<int>();
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1, "right")
            {
                left = new TreeNode(2, "left")
                {
                    left = new TreeNode(4, "left")
                },
                right = new TreeNode(3, "right")
                {
                    left = new TreeNode(5, "left")
                    {
                        right = new TreeNode(7, "right")
                    },
                    right = new TreeNode(6, "right")
                }
            };
        }
    }

    internal class TreeNode
    {
        private int v;

        public List<int> GetRightmostNodes(TreeNode root)
        {
            int res = Convert.ToInt32(root.right);

            int val = Convert.ToInt32(Console.ReadLine());
            if (res == val)
            {
                Console.WriteLine("Right Value :"+ res);
                Console.ReadLine();
            }
            return null;
        }
        public TreeNode(int v, string mood)
        {
            this.v = v;

            TreeNode obj = new TreeNode();
            if (mood == "right")
            {
                obj.right = v;
                GetRightmostNodes(obj);
            }
        }

        public TreeNode()
        {
        }

        public object left { get; set; }
        public object right { get; set; }
    }
}
