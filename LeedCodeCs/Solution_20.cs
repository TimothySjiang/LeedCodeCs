using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    class Solution_20
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var HashMap = new Dictionary<int, int>
            {
                ['('] = ')',
                ['{'] = '}',
                ['['] = ']',
            };

            foreach (char c in s)
            {
                if (HashMap.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (stack.Count == 0 || c != HashMap[stack.Pop()])
                    return false;
            }
            return stack.Count == 0;
        }
    }
}
