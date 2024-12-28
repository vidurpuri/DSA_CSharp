using DSA_CSharp._04_LinkedLists_DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._04_LinkedLists_DS
{
    public class Node
    {
        public int value { get; set; }
        public Node next { get; set; }


        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }

    }


    public class LinkedListImplementation   
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int length;

        public LinkedListImplementation(int value)
        {
            this.Head = new Node(value);
            this.Tail = this.Head;
            this.length = 1;
        }

        //[10,5,20]
        //Append
        public void Append(int value)
        {
            var newNode = new Node(value);
            this.Tail.next = newNode;
            this.Tail = newNode;
            this.length++;
            
        }

        //[2 --> 10,5,20]
        //PrePend
        public void Prepend(int value)
        {
            var newNode = new Node(value);
            newNode.next = this.Head;
            this.Head = newNode;
            this.length++;
        }

        //[10,5,20]
        //Traverse
        private Node TraverseToIndex(int index)
        {
            int counter = 0;
            var currentNode = this.Head;
            while(counter != index)
            {
                currentNode = currentNode.next;
                counter++;
            }
            return currentNode;
        }

        //[10,5,15,20] index 1, 8
        // 10 --> 8 --> 5
        //Insert
        public void Insert(int index, int value)
        {
            //If first item to insert
            if(index == 0)
                this.Prepend(value);

            //if last item to insert
            if(index >= this.length)
                this.Append(value);

            //Insert in between list
            if(index > 0 && index < this.length)
            {
                var newNode = new Node(value);
                var leader = this.TraverseToIndex(index - 1);
                var nodeToBePushed = leader.next;
                leader.next = newNode;
                newNode.next = nodeToBePushed;
                this.length++;
            }
        }

        //[5,10,15]
        //Remove
        public void Remove(int index)
        {
            //First Element to remove 
            if(index == 0)
            {
                this.Head = Head.next;
            }


            //Last element to remove
            if(index >= this.length)
            {
                var leade = this.TraverseToIndex(index - 1);
                this.Tail = leade;
                this.length--;
            }


            //in between node to be removed 
            var leader = this.TraverseToIndex(index - 1);
            var nodeToBeRemoved = leader.next;
            leader.next = nodeToBeRemoved.next;
            this.length--;
        }


        //printData
        public void PrintData()
        {
            if (this.Head == null)
                return;
            var node = this.Head;
            while(node != null)
            {
                Console.Write(node.value+"--->" );
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}


//Void Main Method call

//LinkedListImplementation linkedList = new(10);
//linkedList.Append(5);
//linkedList.Append(2);
//linkedList.Prepend(3);
//linkedList.Insert(2, 25);
//linkedList.Remove(2);
//linkedList.PrintData();