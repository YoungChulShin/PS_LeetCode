using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int count = solution.CountSubstrings2("abc");
            int count2 = solution.CountSubstrings2("aaa");
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

        public int CountSubstrings2(string s) 
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (result.ContainsKey(s[i]))
                {
                    result[s[i]] += 1; 
                }
                else
                {
                    result.Add(s[i], 1);
                }
            }

            int countSum = 0;
            foreach(var value in result.Values)
            {
                countSum += GetSubSum(value);
            }

            return countSum;
        }

        private int GetSubSum(int value)
        {
            int result = 0;
            while (value > 0) 
            {
                result += value;
                value--;
            }

            return result;
        }
    }
}
