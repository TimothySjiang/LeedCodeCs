using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> intStore = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (intStore.ContainsKey(target - nums[i]))
                {
                    return new int[] { intStore[target - nums[i]], i };
                }
                intStore[nums[i]] = i;
            }
            return null;
        }
    }
}