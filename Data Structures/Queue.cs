﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Queue
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

        private Node head; //remove from
        private Node tail; //add to

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Peek()
        {
            return head.Data;
        }

        public void Add(int data)
        {
            var node = new Node(data);

            if (tail != null)
            {
                tail.Next = node;
            }
            
            tail = node;

            if (head == null)
            {
                //As tail is a permanent variable within this class, head will pick up all of tails child properties (.Next) whenever they are added
                head = tail;
            }
        }

        public int Remove()
        {
            int data = head.Data;
            head = head.Next;
            if (head == null) tail = null;
            return data;
        }
    }
}
