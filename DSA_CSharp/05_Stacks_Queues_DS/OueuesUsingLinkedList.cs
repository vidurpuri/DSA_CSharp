using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._05_Stacks_Queues_DS
{
    public class Nodes
    {
        public int value { get; set; }
        public Nodes next { get; set; }

        public Nodes(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
    public class OueuesUsingLinkedList
    {
        private Nodes First { get; set; }
        private Nodes Last { get; set; }
        private int length;

        public OueuesUsingLinkedList()
        {
            this.First = null;
            this.Last = null;
            this.length = 0;
        }

        //Enqueue
        //[1,2]
        public void Enqueue(int value)
        {
            var newNode = new Nodes(value);
            if(length == 0)
            {
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.next = newNode;
                this.Last = newNode;
            }
            this.length++;


        }

        //DeQueue
        public void Dequeue()
        {
            if (length == 0)
                Console.WriteLine("Queue Empty");

            var follower = this.First.next;
            this.First = follower;
            this.length--;
        }


        //Peek
        public int Peek()
        {
            if (length == 0)
                return 0;
            return this.First.value;
        }


        //Print
        public void Print()
        {
            if (this.First == null)
                return;
            var node = this.First;
            while (node != null)
            {
                Console.Write(node.value + "--->");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}
