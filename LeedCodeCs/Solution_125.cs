using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_125
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            int p1 = 0;
            int p2 = s.Length - 1;
            s = s.ToLower();
            while (p1 < p2)
            {
                while (p1 < s.Length && !Char.IsLetterOrDigit(s[p1])) p1++;
                while (p2 > -1 && !Char.IsLetterOrDigit(s[p2])) p2--;
                if (p1 < p2 && s[p1++] != s[p2--]) return false;
            }
            return true;
        }
    }
}
