using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._02_Arrays_DS
{
    public class ArrayImplementation
    {
        public int length;
        public Object[] data;

        public ArrayImplementation()
        {
            this.length = 0;
            this.data = new Object[1];
        }

        public Object Get(int index)
        {
            return this.data[index];
        }

        public Object[] Push(Object item)
        {
            if(this.data.Length == this.length)
            {
                Console.WriteLine("Hi");
            }
            this.data[this.length] = item;
            this.length++;
            return this.data;
            //for (int i = 0; i < this.data.Length; i++)
            //{
            //    Console.WriteLine(this.data[i].ToString());
            //}

        }


        //ArrayImplementation arrayImplementation = new();
        //        arrayImplementation.Push("b");
        //for (int i = 0; i<arrayImplementation.length; i++)
        //{
        //    Console.WriteLine(arrayImplementation.Get(i));




    }
}
