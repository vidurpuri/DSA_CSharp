using DSA_CSharp._05_Stacks_Queues_DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._05_Stacks_Queues_DS
{
    public class StacksUsingArray
    {
        private int[] elements;
        private int top;
        private int length;

        public StacksUsingArray(int size)
        {
            elements = new int[size];
            top = -1;
            length = size;
        }

        //Push
        public void Push(int value)
        {
            if(top == length - 1)
            {
                Console.WriteLine("Stack Full");
                return;
            }
            elements[++top] = value;
        }

        //Pop
        public int Pop()
        {
            if(this.top == -1)
            {
                Console.WriteLine("Stack Empty");
                return -1;
            }

            return elements[top--];
        }


        //Peek
        public int Peek()
        {
            if (this.top == -1)
            {
                Console.WriteLine("Stack Empty");
                return -1;
            }
            return elements[top];
        }

        public void Print()
        {
            if (this.top == -1)
            {
                Console.WriteLine("Stack Empty");
                return ;
            }

            for(int i = 0; i <=top; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}


///Void Main Method
///

//StacksUsingArray stacksUsingArray = new StacksUsingArray(5);
//stacksUsingArray.Push(1);
//stacksUsingArray.Push(2);
//stacksUsingArray.Push(3);
//stacksUsingArray.Push(5);
//stacksUsingArray.Print();

//Console.WriteLine("Peek Value" + " " + stacksUsingArray.Peek());

//stacksUsingArray.Pop();
//stacksUsingArray.Print();