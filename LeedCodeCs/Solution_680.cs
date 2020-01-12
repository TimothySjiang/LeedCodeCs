using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_680
    {
        public bool ValidPalindrome(string s)
        {
            int p1 = 0;
            int p2 = s.Length - 1;
            while (p1 < p2)
            {
                if (s[p1] == s[p2])
                {
                    p1++;
                    p2--;

                }
                else
                    return HelpValid(s, p1 + 1, p2) || HelpValid(s, p1, p2 - 1);
            }
            return true;
        }

        private bool HelpValid(string s, int start, int end)
        {
            int p1 = start;
            int p2 = end;

            while (p1 < p2)
            {
                if (s[p1++] != s[p2--])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
