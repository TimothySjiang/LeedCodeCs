using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_9
    {
        public bool IsPalindrome(int x)
        {
            string X = x.ToString();
            int p1 = 0;
            int p2 = X.Length - 1;

            while (p1 < p2)
            {
                if (X[p1++] != X[p2--])
                {
                    return false;
                }

            }
            return true;
        }
    }
}
