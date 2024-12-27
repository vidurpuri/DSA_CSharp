using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._03_HashTables_DS
{
    public class RecurringNumber
    {
        //Input
        //int[] arr = new int[] {2,5,1,2,3,4}
        //Result = 2
        public int RecurringNum(int[] arr)
        {
            int result = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (list.Contains(arr[i]))
                {
                    return result = arr[i];
                }
                else
                {
                    list.Add(arr[i]);
                }
            }

            return result;

            ///Second Solution using Hashtables

            //Hashtable hashtable = new Hashtable();  

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if(hashtable.ContainsKey(arr[i]))
            //    {
            //        return arr[i];
            //    }
            //    hashtable.Add(arr[i], arr[i]);
            //}
            //return 0;

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i+1;j < arr.Length; j++)
            //    {
            //        var prviousValue = arr[j];
            //        if (prviousValue == arr[j])
            //            return arr[j];
            //        if (arr[i] == arr[j])
            //        {
            //            return arr[i];
            //        }

            //    }
            //}
            //return 0;
        }
    }
}
