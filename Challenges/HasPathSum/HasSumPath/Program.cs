using System;
using Tree.Classes;

namespace HasSumPath
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree2 = new BinaryTree();
            tree2.root = new Tree.Classes.Node(1);
            tree2.root.Left = new Node(2);
            tree2.root.Right = new Node(4);

            int sum = 3;
            if (Program.hasSumPath(tree2.root, sum))
            {
                Console.WriteLine("There is a root to leaf " +
                                      "path with sum " + sum);
            }
            else
            {
                Console.WriteLine("There is no root to leaf " +
                                       "path with sum " + sum);
            }
        }
        /// <summary>
        /// check if the sum of any path add-up to given sum
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static bool hasSumPath(Node root, int sum)
        {
            // if root is null sum is 0
            if (root == null)
                return sum == 0;
            else
            {
                // create a boolean return answer
                bool ans = false;
                //create an int variable whose value is sum minus root value
                int pathTotal = sum - root.Value;
                // if path total is zero and there are no more nodes remain either in left or right return true
                if (pathTotal == 0 && root.Right == null && root.Left == null)
                    return true;
                // do recursive in left side
                if (root.Left != null)
                    ans = ans || hasSumPath(root.Left, pathTotal);
                // do recursive check in right side
                if (root.Right != null)
                    ans = ans || hasSumPath(root.Right, pathTotal);
                // return the boolean ans
                return ans;
            }
        }
    }
}
