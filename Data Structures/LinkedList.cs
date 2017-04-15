namespace Data_Structures
{
    public class LinkedList
    {
        Node head;

        public void Append(int data)
        {
            //If there is no head, initialize the linked list with one
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            //Assigning reference will not create distinct copy, all reference variables are referring to the same object
            //Assigning object reference variables doesn't create a distinct object, allocate memory, or create a duplicate copy
            //Reference variable is used to store the address of the object
            Node current = head;
            //head is a reference variable which contains the address of the actual Node object
            //current is another reference variable
            //current initialized with head means current and head are referring to the same object, does not create duplicate object or allocate extra memory

            //Keep going through the nodes until we reach the end, then create a new node
            while (current.Next != null) current = current.Next;

            //When updating a destination object (its Next property), which is assigned from a source object, the source object is also updated
            current.Next = new Node(data);

            //Setting current to null only sets address to null, not the object, so head will still have reference to object
            current = null;
        }

        public void Prepend(int data)
        {
            //Create a new head, setting the current head to the Next value of the new head
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
