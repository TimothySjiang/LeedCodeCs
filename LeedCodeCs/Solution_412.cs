using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_412
    {
        public IList<string> FizzBuzz(int n)
        {
            List<String> ans = new List<String>();
            for (int i = 1; i < n + 1; i++)
            {
                bool divisibleBy3 = (i % 3 == 0);
                bool divisibleBy5 = (i % 5 == 0);

                String numAnsStr = "";

                if (divisibleBy3)
                {
                    numAnsStr += "Fizz";
                }

                if (divisibleBy5)
                {
                    numAnsStr += "Buzz";
                }

                if (numAnsStr == "")
                {
                    numAnsStr += i.ToString();
                }

                ans.Add(numAnsStr);
            }
            return ans;
        }
    }
}
