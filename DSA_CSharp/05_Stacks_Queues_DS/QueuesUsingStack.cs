using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._05_Stacks_Queues_DS
{
    public class QueuesUsingStack
    {
        private Stack<int> s1 = new Stack<int>();
        private Stack<int> s2 = new Stack<int>();

        //Enqueue
        public void Enqueue(int value)
        {
            this.s1.Push(value);
        }

        //Dequeue
        public int Dequeue()
        {
            fill_S2With_S1();
            int value = s2.Peek();
            fill_S1With_S2();
            return value;
        }

        //Peek
        public int Peek()
        {
            fill_S2With_S1();
            int value = s2.Peek();
            fill_S1With_S2();
            return value;
        }

        public void printQueue()
        {
            if (s1.Count == 0)
            {
                return;
            }

            fill_S2With_S1();
            foreach (var i in s2)
            {
                Console.Write("-->" + i);
            }
            Console.WriteLine();
            fill_S1With_S2();
        }

        private void fill_S2With_S1()
        {
            while (s1.Count > 0)
            { //Making the "auxiliaryStack" stack as queue of "Stack"
                s2.Push(s1.Pop());
            }
        }

        private void fill_S1With_S2()
        {
            while (s2.Count > 0)
            { //Return stack to the original state
                s1.Push(s2.Pop());
            }
        }
    }
}
