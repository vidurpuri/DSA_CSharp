using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._01_Section4_GoogleCoding
{
    public static class GoogleCodingInterview
    {
        //Naive Solution with Nested Loop 



        //Better Solution 
        public static bool HasPairWithSum(int[] arr, int sum)
        {
            bool result = false;
            HashSet<int> pair = new HashSet<int>();
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                if(pair.Contains(arr[i]))
                {
                    result = true;
                    return result;
                }

                pair.Add(sum - arr[i]);
            }
            return result;
        }
    }
}
