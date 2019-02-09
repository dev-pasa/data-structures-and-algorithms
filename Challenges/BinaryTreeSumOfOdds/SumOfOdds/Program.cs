using System;
using Tree.Classes;

namespace SumOfOdds
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree BT = new BinaryTree(5);
            BT.root.Left = new Node(11);
            BT.root.Left.Left = new Node(10);
            BT.root.Left.Right = new Node(15);
            BT.root.Right = new Node(12);
            BT.root.Right.Right = new Node(9);
            BT.root.Right.Left = new Node(17);
  
            Console.WriteLine(SumofOdds(BT.root));
        }
    

        public static int SumofOdds(Node root)
        {
            if (root == null) return 0;
            int sum = 0;

            if (root.Value % 2 == 1) sum = root.Value;
            return sum + SumofOdds(root.Left) + SumofOdds(root.Right);
        }
    }
}

