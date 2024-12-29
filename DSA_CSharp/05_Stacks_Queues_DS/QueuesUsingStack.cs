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
        private Stack<int> pushStack = new Stack<int>();
        private Stack<int> popStack = new Stack<int>();

        //Enqueue
        public void Enqueue(int value)
        {
            pushStack.Push(value);
        }

        //Dequeue
        public int Dequeue()
        {
            if(popStack.Count == 0)
            {
                while(pushStack.Count > 0)
                {
                    popStack.Push(pushStack.Pop());
                }
            }
            if (popStack.Count == 0) return -1;
            return popStack.Pop();
        }

        ////Peek
        public int Peek()
        {
            if (popStack.Count == 0)
            {
                while (pushStack.Count > 0)
                {
                    popStack.Push(pushStack.Pop());
                }
            }
            if (popStack.Count == 0) return -1;
            return popStack.Peek();
        }

        public bool IsEmpty()
        {
            return pushStack.Count == 0 && popStack.Count == 0;
        }
       
    }
}
