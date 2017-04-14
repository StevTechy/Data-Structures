﻿namespace Data_Structures
{
    public class LinkedList
    {
        Node head;

        public void Append(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            Node current = head;
            while (current.Next != null) current = current.Next;
            current.Next = new Node(data);
        }

        public void Prepend(int data)
        {
            Node newHead = new Node(data);
            newHead.Next = head;
            head = newHead;
        }

        public void DeleteWithValue(int data)
        {
            if (head == null) return;

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;

            while (current.Next != null)
            {
                if(current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                }
                current = current.Next;
            }

            if (current != null) current = null;
        }

        internal class Node
        {
            public Node Next;
            public int Data;

            public Node(int data)
            {
                this.Data = data;
            } 
        }
    }
}