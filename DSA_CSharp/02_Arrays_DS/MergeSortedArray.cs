using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._02_Arrays_DS
{
    public class MergeSortedArray
    {
        //Input
        // 1. Object[] arr1 = new Object[]{0,3,4,31}
        // 2. Object[] arr2 = new Object[]{4,6,30}

        //Output - Merged sorted array
        //[0,3,4,4,6,30,31]

        public Object[] MergeSortedArrayWithoutInBuildFunction(Object[] array, Object[] array2)
        {
            Object[] result = new Object[array.Length + array2.Length];

            return result;
        }

        public Object[] MergeSortedArrayExercise(Object[] array, Object[] array2)
        {
            //If First array has value and Second array Empty
            if (array.Length != 0 && array2.Length == 0)
                return array;

            //If First array Empty and Second array has value
            if (array.Length == 0 && array2.Length != 0)
                return array2;

            //Create New Array if both array has elements
            Object[] result = new Object[array.Length + array2.Length];

            //Copy First Array in Result
            Array.Copy(array,result, array.Length);
            //Copy Second Array in Result
            Array.Copy(array2, 0, result, array.Length, array2.Length);
            //Sort
            Array.Sort(result);


            //Another Probable solution
            //var r = array.Union(array2).OrderBy(i => i).ToArray();

            return result;

        }
    }
}
