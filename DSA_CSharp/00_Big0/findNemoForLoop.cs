using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._00_Big0
{
    public static class findNemoForLoop
    {
        /// Implemetation using For loop 

        /// Inputs
        // Case 1 : string[] nemo = new string[] { "nemo" };
        // Case 2 : string[] largeNemo = new string[] { "Akhil", "Nitin", "Anuj", "Ankita", "Kaira" };

        ///Output
        // Case 1 : Found Nemo ( Ran one time as input is a single element in array)
        // Case 2 : Nemo Not Found !!  ( Ran 5 times as input comtain 5 elemenst in array )
                   //Nemo Not Found !!
                   //Nemo Not Found !!
                   // Nemo Not Found !!
                   // Nemo Not Found !!

        /// Big(0) Result
        /// o(n) --> Linear time --> Increase in elements == total no of operations 

        public static void FindNemo(string[] nemo)
        {
            for (int i = 0; i < nemo.Length; i++)
            {
                if (nemo[i] == "nemo")
                {
                    Console.WriteLine("Found Nemo!!");
                }
                else
                {
                    Console.WriteLine("Nemo Not Found !!");
                }
            }
        }
    }
}
    

