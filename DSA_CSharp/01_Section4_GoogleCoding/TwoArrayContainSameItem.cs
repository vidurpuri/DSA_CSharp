using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._01_Section4_GoogleCoding
{
    public static class TwoArrayContainSameItem
    {
        ///Inputs
        //string[] arr1 = new string[] { "a", "b", "c", "d" };
        //string[] arr2 = new string[] { "z", "y", "x" };
        public static bool ContainSameItemNesteLoops(string[] arrOne, string[] arrTwo)
        {
            bool result = false;
            for(int i = 0; i<arrOne.Length; i++)
            {
                for (int j = 0; j < arrTwo.Length; j++)
                {
                    if(arrOne[i] == arrTwo[j])
                    {
                        result = true;
                        return result;
                        break;
                    }
                }
            }
            return result;
        } //Big O = 0(a*b) --> Bad Approach

        public static bool ContainSameItemDifferentLoops(string[] arrOne, string[] arrTwo)
        {
            //Object[] obj = {}
            return false;
        }

       
    }
}
