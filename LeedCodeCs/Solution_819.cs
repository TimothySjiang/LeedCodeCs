using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
        public class Solution_819
        {
            public string MostCommonWord(string paragraph, string[] banned)
            {
                paragraph += '.';
                var bannedSet = new HashSet<string>(banned);
                var maxRepeatWordCount = 0;
                var selectedWord = "";
                var wordDict = new Dictionary<string, int>();
                var wordCreator = new StringBuilder();
                foreach (var c in paragraph)
                {
                    if (char.IsLetter(c))
                    {
                        wordCreator.Append(c);
                    }
                    else if (wordCreator.Length > 0)
                    {
                        var newWord = wordCreator.ToString().ToLower();

                        if (!bannedSet.Contains(newWord))
                        {
                            if (wordDict.ContainsKey(newWord))
                            {
                                wordDict[newWord] = wordDict[newWord] + 1;
                            }
                            else
                            {
                                wordDict[newWord] = 1;
                            }

                            if (wordDict[newWord] >= maxRepeatWordCount)
                            {
                                maxRepeatWordCount = wordDict[newWord];
                                selectedWord = newWord;
                            }
                        }
                        wordCreator.Clear();
                    }
                }
                return selectedWord;
            }
        }
    }

