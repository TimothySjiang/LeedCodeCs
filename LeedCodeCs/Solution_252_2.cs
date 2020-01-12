using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_252_2
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            Array.Sort(intervals, new Comparator());
            for (int i = 0; i < intervals.Length - 1; i++)
            {
                if (intervals[i][1] > intervals[i + 1][0]) return false;
            }
            return true;
        }


        public class Comparator : IComparer<int[]>
        {
            public int Compare(int[] interval1, int[] interval2)
            {
                var comparisonResult = interval1[0].CompareTo(interval2[0]);
                if (comparisonResult == 0)
                {
                    comparisonResult = interval1[1].CompareTo(interval2[1]);
                }
                return comparisonResult;
            }
        }
    }
}
