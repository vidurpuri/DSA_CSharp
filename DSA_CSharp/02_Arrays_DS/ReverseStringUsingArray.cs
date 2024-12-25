﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._02_Arrays_DS
{
    public class ReverseStringUsingArray
    {
        public string word = "Kaira not sleeping";

        public string Reverse()
        {
            string reversed = string.Empty;
            char[] chars = word.ToCharArray();
            foreach (var item in chars)
            {
                var character = item;
                reversed = item.ToString() + reversed;
            }

            return new string(reversed);
            
        }
    }
}
