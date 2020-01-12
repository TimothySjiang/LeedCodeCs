using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    class Solution_53
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] > 0)
                    nums[i] += nums[i - 1];
                maxSum = Math.Max(maxSum, nums[i]);
            }

            return maxSum;
        }
    }
}
