using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Stack
    {
        internal class Node
        {
            public int Data;
            public Node Next;
            public Node(int data)
            {
                this.Data = data;
            }
        }

        private Node top; //add to, remove from

        public bool IsEmpty()
        {
            return top == null;
        }

        public int Peek()
        {
            if (top == null) return -1;
            return top.Data;
        }
        
        public void Push(int data)
        {
            var node = new Node(data);

            //Set the nodes Next field to the current top. This node becomes the new top
            node.Next = top;

            //Set this node to the new top, the Next field of the new top has the old top with its Next values
            top = node;
        }

        public int Pop()
        {
            if (top == null) return -1;
            var data = top.Data;

            //Set the top to be the next Node
            top = top.Next;
            return data;
        }
    }
}
