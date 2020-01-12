using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_443
    {
        public int Compress(char[] chars)
        {
            int p1 = 0;
            int p2 = 0;
            int p = 0;
            int count = 0;

            while (p2 < chars.Length)
            {
                while (p2 < chars.Length && chars[p1] == chars[p2])
                {
                    p2 += 1;
                    count += 1;
                }
                if (count > 1)
                {
                    chars[p++] = chars[p1];
                    foreach (char c in count.ToString().ToCharArray())
                        chars[p++] = c;
                    count = 0;
                }
                else
                {
                    chars[p++] = chars[p1];
                    count = 0;
                }

                p1 = p2;
            }

            return p;
        }
    }
}
