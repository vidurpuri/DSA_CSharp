using DSA_CSharp._05_Stacks_Queues_DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._05_Stacks_Queues_DS
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
    public class StacksUsingLinkedList
    {
        private Node Top {  get; set; }
        private Node Bottom { get; set; }
        private int length;
        public StacksUsingLinkedList()
        {
            this.Top = null;
            this.Bottom = null;
            this.length = 0;
        }

        //[3,2,1]
        //push
        public void Push(int value)
        {
            var newNode = new Node(value);
            if(this.Top == null)
            {
                this.Top = newNode;
                this.Bottom = newNode;
                this.length++;
                return;
            }
            newNode.next = this.Top;
            this.Top = newNode;
            this.length++;

        }

        //[3,2,1]
        //pop  
        public void Pop()
        {
            if (this.Top != null)
            {
                if(this.Top == this.Bottom)
                    {
                    this.Top = null;
                    this.Bottom = null;
                    this.length--;
                   }
                var follower = this.Top.next;
                if (follower != null)
                {
                    this.Top = follower;
                    this.length--;
                }
            }
        }


        //peek
        public int Peek()
        {
            return this.Top.value;
        }

        public void PrintData()
        {
            if (this.Top == null)
                return;
            var node = this.Top;
            while (node != null)
            {
                Console.Write(node.value + "--->");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}


/// Void Main Method 


//StacksUsingLinkedList stacksUsingLinkedList = new StacksUsingLinkedList();
//stacksUsingLinkedList.Push(1);
//stacksUsingLinkedList.Push(2);
//stacksUsingLinkedList.Push(3);
//stacksUsingLinkedList.Push(5);
//stacksUsingLinkedList.PrintData();

//Console.WriteLine("Peek Value" + " " + stacksUsingLinkedList.Peek());

//stacksUsingLinkedList.Pop();
//stacksUsingLinkedList.PrintData();