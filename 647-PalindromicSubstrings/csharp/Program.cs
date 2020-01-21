using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int count = solution.CountSubstrings("abc");
            int count2 = solution.CountSubstrings("aaa");
        }
    }

    public class Solution
    {
        // My First Method
        public int CountSubstrings(string s) 
        {
            List<string> result = new List<string>();
            List<string> palindromicList = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                result.Add(s[i].ToString());

                if (palindromicList.Count > 0)
                {
                    if (palindromicList[0].StartsWith(s[i]))
                    {
                        for (int j = 0; j < palindromicList.Count; j++)
                        {
                            palindromicList[j] += s[i];
                            result.Add(palindromicList[j]);
                        }
                    }
                    else
                    {
                        palindromicList.Clear();
                    }
                }

                palindromicList.Add(s[i].ToString());
            }

            return result.Count;
        }
    }
}
