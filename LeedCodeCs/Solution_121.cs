using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    class Solution_121
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int buyPrice = Int32.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                maxProfit = Math.Max(maxProfit, prices[i] - buyPrice);
                buyPrice = Math.Min(buyPrice, prices[i]);
            }
            return maxProfit;
        }
    }
}
