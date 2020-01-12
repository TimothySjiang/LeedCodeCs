using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_215
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var heap = new SortedList<int, int>(new KeyComparer());
            for (int i = 0; i < nums.Length; i++)
            {
                heap.Add(nums[i], nums[i]);
                if (heap.Count > k) heap.RemoveAt(k);
            }
            return heap.Values[k - 1];
        }

        public class KeyComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                var comparisonResult = x.CompareTo(y);
                if (comparisonResult == 0)
                {
                    return 1;
                }
                return comparisonResult * (-1);
            }
        }
    }
}
