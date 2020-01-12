using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_252
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            intervals = intervals.OrderBy(row => row[0]).ThenBy(row => row[1]).ToArray();
            for (int i = 0; i < intervals.Length - 1; i++)
            {
                if (intervals[i][1] > intervals[i + 1][0]) return false;
            }
            return true;
        }
    }
}
