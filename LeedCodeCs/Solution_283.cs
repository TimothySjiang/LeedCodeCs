using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_283
    {
        public void MoveZeroes(int[] nums)
        {
            int p1 = 0;
            int p2 = 0;
            while (p2 < nums.Length)
            {
                if (nums[p2] != 0)
                {
                    nums[p1++] = nums[p2];
                }
                p2++;
            }

            while (p1 < nums.Length)
            {
                nums[p1++] = 0;
            }


        }
    }
}
