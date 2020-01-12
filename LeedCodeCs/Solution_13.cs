using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            var roman = new Dictionary<char, int>(){
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
        };

            int total = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (roman[s[i]] < roman[s[i + 1]])
                    total -= roman[s[i]];
                else
                    total += roman[s[i]];
            }
            return total + roman[s[s.Length - 1]];
        }
    }
}
