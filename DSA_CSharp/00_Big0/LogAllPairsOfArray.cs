using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._00_Big0
{
    public static class LogAllPairsOfArray
    {
        //int[] boxes = new int[]{1,2,3,4,5}
        public static void LogPairs(int[] boxes)
        {
            for(int i = 0; i< boxes.Length; i++)
            {
                for(int j = 0; j < boxes.Length; j++)
                {
                    Console.WriteLine($"{boxes[i]},{boxes[j]}");
                }
            }
        }

        // Output 1,1, 1,2, 1,3, 1,4, 1,5
        //       ,2,1, 2,2, 2,3, 2,4, 2,5
        //       ,3,1, 3,2, 3,3, 3,4, 3,5
        //       ,4,1, 4,2, 4,3, 4,4, 4,5
        //       ,5,1, 5,2, 5,3, 5,4, 5,5
    }
}
