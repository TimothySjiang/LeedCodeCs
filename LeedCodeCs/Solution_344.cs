using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_344
    {
        public void ReverseString(char[] s)
        {
            int p1 = 0;
            int p2 = s.Length - 1;
            while (p1 < p2)
            {
                char temp = s[p1];
                s[p1++] = s[p2];
                s[p2--] = temp;
            }
        }
    }
}
