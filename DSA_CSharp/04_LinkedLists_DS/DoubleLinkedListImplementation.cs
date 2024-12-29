using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._04_LinkedLists_DS
{
    public class DoublyNode
    {
        public int value { get; set; }
        public DoublyNode next { get; set; }
        public DoublyNode previous { get; set; }


        public DoublyNode(int value)
        {
            this.value = value;
            this.next = null;
            this.previous = null;
        }

    }
    public class DoubleLinkedListImplementation
    {
        private DoublyNode Head { get; set; }
        private DoublyNode Tail { get; set; }
        private int length;

        public DoubleLinkedListImplementation(int value)
        {
            this.Head = new DoublyNode(value);
            this.Tail = this.Head;
            this.length++;
        }

        public void PrintData()
        {
            if (this.Head == null)
                return;
            var node = this.Head;
            while (node != null)
            {
                Console.Write(node.value + "--->");
                node = node.next;
            }
            Console.WriteLine();
        }

        //[3,5,6 --> 7]
        //Append
        public void Append(int value)
        {
            var newNode = new DoublyNode(value);
            newNode.previous = this.Tail;
            this.Tail.next = newNode;
            this.Tail = newNode;
            this.length++;
            
        }

        //PrePend
        //[1 --> 3,5,6]
        public void Prepend(int value)
        {
            var newNode = new DoublyNode(value);
            newNode.next = this.Head;
            this.Head.previous = newNode;
            this.Head = newNode;
            this.length++;
        }

        private DoublyNode TraverseToIndex(int index)
        {
            int counter = 0;
            var currentNode = this.Head;
            while (counter != index)
            {
                currentNode = currentNode.next;
                counter++;
            }
            return currentNode;
        }

        //[3,5,6] index =1 , value 7 ---> New Node [3,5,7,6]
        public void Insert(int index, int value)
        {
            if(index == 0)
                this.Prepend(value);
            if(index > this.length)
                this.Append(value);

            var newNode = new DoublyNode(value);
            var leader = this.TraverseToIndex(index - 1);
            var follower = leader.next;
            leader.next = newNode;
            newNode.previous = leader;
            newNode.next = follower;
            follower.previous = newNode;
            this.length++;

        }

        //[3,5,6,7,8] index = 2 --> New Node = [3,5,7,8]
        public void Remove(int index)
        {
            //First Element to remove 
            if (index == 0)
            {
                this.Head = Head.next;
            }
            //Last element to remove
            if (index >= this.length)
            {
                var leade = this.TraverseToIndex(index - 1);
                this.Tail = leade;
                this.length--;
            }
            //in between node to be removed 
            var leader = this.TraverseToIndex(index - 1);
            var nodeToBeRemoved = leader.next;
            var follwer = nodeToBeRemoved.next;
            leader.next = follwer;
            follwer.previous = leader;
            this.length--;
        }

        //[2,5,3,7,5]
        public void Reverse()
        {
            // Start of list Grab Head Node i.e 2
            var current = this.Head;
            // Previous value be null initally
            DoublyNode previous = null;

            //loop through till current has value
            while (current != null)
            {
                var temp = current.next; // Grab Second node
                current.next = previous; // Break pointer of 1 --> 2 and point 1 --> prvious
                current.previous = previous;
                previous = current; // Now reverse logic to point previous to current as in baove step current became previous
                current = temp; // to continue looping current has to be moved to nect node  
            }
            // as above logic goes reverse everything by pointing list in reverse , we just need to point tail to head 
            // so that we can grab full list.
            this.Head = this.Tail;

        }
    }
}
