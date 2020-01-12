using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    class Solution_88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            while (m >= 1 && n >= 1)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[m + n - 1] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[m + n - 1] = nums2[n - 1];
                    n--;
                }
            }

            if (m == 0)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    nums1[i] = nums2[i];
                }
            }
        }
    }
}
