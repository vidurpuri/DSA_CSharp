using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._02_Arrays_DS
{
    public class TwoSum
    {
        public int[] TwoSumExercise(int[] nums, int target)
        {
            for(int i = 0; i <nums.Length;i++)
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }

        ///Javascript Solution Below
       
                //var twoSum = function(nums, target) {
                //    let result = [];
                //    for(let i = 0; i<nums.length; i++){
                //        for(let j = i +1; j<nums.length; j++){
                //            if(nums[i] + nums[j] === target){
                //                return result = [i, j];
                //            }
                //        }
                //    }
                //    return result;
                //};
    }
}
