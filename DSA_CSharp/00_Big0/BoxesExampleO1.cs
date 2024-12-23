using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._00_Big0
{
    public static class BoxesExampleO1
    {
        /// Implemetation using For loop 

        /// Inputs
        // Case 1 : int[] box = new int[] {0,1,2,3,4};
        // Case 2 : int[] box = new int[] {0,1,2,3,4,5,6,7,8,9,10};

        ///Output
        // Case 1 : 0,1 ( Writes first 2 element )
        // Case 2 : 0,1 ( Writes first 2 element )

        /// Big(O) Result
        /// O(1) --> Constant time --> Increase in elements does not effect Operations --> Most Efficent & Scalable
        public static void WriteBoxes(int[] boxes)
        {
            Console.WriteLine(boxes[0]);
            Console.WriteLine(boxes[1]);
        }
    }
}
