using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._01_Section4_GoogleCoding
{
    public static class GoogleCodingInterview
    {
        //Inputs
        //int[] arr1 = new int[] {6,4,3,2,1,7 };
        //int sum = 9


        //Naive Solution with Nested Loop 
        public static bool HasPairWithSumNestedLoop(int[] arr, int sum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] + arr[j] == sum)
                        return true;
                }
            }
            return false;
        }
        //Output = True


        //Better Solution 

        //Inputs
        //int[] arr1 = new int[] {6,4,3,2,1,7 };
        //int sum = 90
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

        //Output = False

    }
}
