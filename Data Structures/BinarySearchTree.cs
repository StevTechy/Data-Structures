using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    /// <summary>
    /// Root = uppermost node, a tree can only have one
    /// Child = under root, has parent node(s) and child node(s)
    /// Leaf = bottom of tree, has parent node(s) but no child node(s)
    /// Binary tree = each node as no more than 2 child nodes
    /// Binary search tree = the values in nodes increase from left to right
    /// Take a number, e.g. 17. Start at root. Is 17 bigger than current node (root)? If so, search the next node to the right, else, search the next node to the left
    /// </summary>
    public class BinarySearchTree
    {
        internal class Node
        {
            public Node Left, Right;
            public int Data;
            public enum Traversal { Preorder, Inorder, Postorder };

            public Node(int data)
            {
                this.Data = data;
            }

            public void Insert(int value)
            {
                if (value <= Data)
                {
                    //Search to left
                    if (Left == null)
                    {
                        Left = new Node(value);
                    }
                    else
                    {
                        //Recursive action, the value will be pushed to next node to left which will check whether value should go left or right, and so on
                        Left.Insert(value);
                    }
                }
                else
                {
                    //Search to right
                    if (Right == null)
                    {
                        Right = new Node(value);
                    }
                    else
                    {
                        Left.Insert(value);
                    }
                }
            }

            public Node Find(int value)
            {
                if (value == Data) return this;
                else if (value < Data)
                {
                    if (Left == null) return null;
                    return Left.Find(value);
                }
                else
                {
                    if (Right == null) return null;
                    return Right.Find(value);
                }
            }

            public void PrintInOrder(Traversal traversal)
            {
                if (traversal == Traversal.Inorder)
                {
                    if (Left != null)
                    {
                        Left.PrintInOrder(traversal);
                    }
                    Console.WriteLine(Data);
                    if (Right != null)
                    {
                        Right.PrintInOrder(traversal);
                    }
                }
                else if (traversal == Traversal.Preorder)
                {
                    Console.WriteLine(Data);
                    if (Left != null)
                    {
                        Left.PrintInOrder(traversal);
                    }
                    if (Right != null)
                    {
                        Right.PrintInOrder(traversal);
                    }
                }
                else if (traversal == Traversal.Postorder)
                {
                    if (Left != null)
                    {
                        Left.PrintInOrder(traversal);
                    }
                    if (Right != null)
                    {
                        Right.PrintInOrder(traversal);
                    }
                    Console.WriteLine(Data);
                }
            }
        }

    }
}
