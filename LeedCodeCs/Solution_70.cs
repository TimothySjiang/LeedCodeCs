using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_70
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            int first = 1;
            int second = 2;
            int now = 0;
            for (int i = 3; i <= n; i++)
            {
                now = first + second;
                first = second;
                second = now;
            }
            return now;
        }
    }
}
