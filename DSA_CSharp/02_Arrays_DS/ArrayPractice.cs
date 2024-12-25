using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._02_Arrays_DS
{
    public class ArrayPractice
    {
        Object[] objects = new Object[] { "a", "b", "c", "d" };
        public void AddToArray()
        {
            Object newItem = "x";
            //New Array with length + 1
            var newArr = new Object[objects.Length + 1];
            //Copy eixtsing array in new array
            Array.Copy(objects,newArr,objects.Length);
            //Add new item in last position
            newArr[newArr.Length - 1] = newItem;
            
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i].ToString());
            }
        }

        public void RemoveFromArray()
        {
            Object item = "d";

            // new array with one length short
            var newArr = new Object[objects.Length - 1];
            //make last element of existing array as null
            objects[objects.Length - 1] = null;
            // copy eixtsing arra to new
            Array.Copy(objects, newArr, newArr.Length);

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i].ToString());
            }
        }

        public void AddFirstElementinArray()
        {
            object newItem = "e";

            //New Array with length + 1
            var newArr = new Object[objects.Length + 1];

            //Add new item in first place in existing array
            newArr[0] = newItem;
            //Create new Array 
            Array.Copy(objects,0,newArr, 1, objects.Length);

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i].ToString());
            }
        }
    }
}
