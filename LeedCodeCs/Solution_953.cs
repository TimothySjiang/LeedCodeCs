using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_953
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            Dictionary<char, int> orders = new Dictionary<char, int>();
            for (int i = 0; i < order.Length; i++)
            {
                orders.Add(order[i], i);
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (!compare(words[i], words[i + 1], orders))
                {
                    return false;
                }
            }

            return true;

        }

        private bool compare(string word1, string word2, Dictionary<char, int> orders)
        {
            int p1 = 0;
            int p2 = 0;
            while (p1 < word1.Length && p2 < word2.Length)
            {
                if (orders[word1[p1]] < orders[word2[p2]])
                {
                    return true;
                }
                else if (orders[word1[p1]] == orders[word2[p2]])
                {

                    p1++;
                    p2++;
                }
                else
                {
                    return false;
                }

            }

            if (p2 == word2.Length && p1 < word1.Length)
            {
                return false;
            }

            return true;

        }
    }
}
