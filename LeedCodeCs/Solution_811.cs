﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    class Solution_811
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            var dic = new Dictionary<string, int>();
            var list = new List<string>();
            foreach (var domain in cpdomains)
            {
                var arr = domain.Split(' ');
                int count = int.Parse(arr[0]);
                var sp = arr[1].Split('.');
                for (int i = 0; i < sp.Length; i++)
                {
                    var builder = new StringBuilder(sp[i]);
                    for (int j = i + 1; j < sp.Length; j++)
                        builder.Append($".{sp[j]}");
                    var d = builder.ToString();
                    if (dic.ContainsKey(d))
                        dic[d] += count;
                    else dic.Add(d, count);
                }
            }

            foreach (var d in dic)
                list.Add($"{d.Value} {d.Key}");

            return list;
        }
    }
}
