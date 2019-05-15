using System;

class demo
{
    // Binary tree 2


    //node model
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public void DisplayNode()
        {
            Console.Write(Data + " ");
        }
    }
    //binary tree model 
    public class BinarySearchTree
    {
        public Node Root;
        public BinarySearchTree()
        {
            this.Root = null;
        }
        public void Insert(int i)
        {
            Node NewNode = new Node() { Data = i };
            if (this.Root == null)
            {
                this.Root = NewNode; //end
            }
            else
            {
                Node Current = Root; // pointer = current
                Node Parent;
                while (true)
                {
                    Parent = Current;
                    if (i < Current.Data)
                    {
                        Current = Current.Left;
                        if (Current == null)
                        {
                            Parent.Left = NewNode;
                            break;
                        }
                    }
                    else
                    {
                        Current = Current.Right;
                        if (Current == null)
                        {
                            Parent.Right = NewNode;
                            break;
                        }
                    }
                }
            }

        }

        public void InOrder(Node TheRoot)
        {
            if (!(TheRoot == null))
            {
                InOrder(TheRoot.Left);
                TheRoot.DisplayNode();
                InOrder(TheRoot.Right);
            }
        }
    }

    static void Main(string[] args)
    {

        //int[] arr = new int[] { 4, 2, 3, 5, 7, 2, 1, 7, 5 };
      BinarySearchTree numbers = new BinarySearchTree();
      numbers.Insert(23);
      numbers.Insert(45);
      numbers.Insert(26);
      numbers.Insert(37);
      numbers.Insert(3);
      numbers.Insert(99);
      numbers.Insert(21);
      numbers.Insert(22);

      Console.WriteLine("InOrder Traversal:");
      numbers.InOrder(numbers.Root);
    }

}

// References https://www.youtube.com/watch?v=oSWTXtMglKE 