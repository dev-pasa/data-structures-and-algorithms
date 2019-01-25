using System;
using StacksAndQueues.Classes;

namespace MultiBrackValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string check1 = "(){}[] check ";
            Console.WriteLine(check1 + " ==> " + MultiBracketValidation(check1));

            string check2 = "(){}[ check ";
            Console.WriteLine(check2 + " ==> " +  MultiBracketValidation(check2));
        }

        public static bool MultiBracketValidation(string input)
        {
           Stack stack1 = new Stack(null);
           if(input.Length == 0)
            {
                return false;
            }
           
           foreach(char vals in input)
            {
                string val = vals.ToString();
                if (val == "(")
                    stack1.Push(new Node(")"));
                if (val == "{")
                    stack1.Push(new Node("}"));
                if (val == "[")
                    stack1.Push(new Node("]"));
                if(val == "]" || val == ")" || val == "}")
                {
                    if(stack1.Top == null)
                       return false;
                    if(val != stack1.Pop().Value.ToString())
                       return false;
                }
            }
            if (stack1.Top == null)
                return true;
            else
                return false;
        }
    }
}
