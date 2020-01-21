using System;
using System.Collections.Generic;

namespace csharp
{
    /*
    Input  = [73, 74, 75, 71, 69, 72, 76, 73]
    Output = [1, 1, 4, 2, 1, 1, 0, 0]
    */

    public class Solution 
    {
        // My Solution
        public int[] DailyTemperatures(int[] T) 
        {
            Stack<int> stackTemperature = new Stack<int>();
            int[] result = new int[T.Length];

            for (int i = T.Length - 1; i >= 0; i--)
            {
                int j = 1;
                while(stackTemperature.Count > 0 && T[i] >= stackTemperature.Peek())
                {
                    stackTemperature.Pop();
                    j++;
                }

                if (stackTemperature.Count == 0)
                {
                    result[i] = 0;
                    stackTemperature.Push(T[i]);
                }
                else
                {
                    result[i] = j;
                    for (int k = 1; k <= j; k++) 
                    {
                        stackTemperature.Push(T[i]);
                    }
                }
            }
            

            return result;
        }

        // Leetcode Solution
        public int[] DailyTemperatures2(int[] T) 
        {
            int[] result = new int[T.Length];
            Stack<int> rec = new Stack<int>();

            for(int i = T.Length - 1; i >= 0; --i)
            {
                while(!(rec.Count == 0) && T[i] >= T[rec.Peek()] )
                {
                    rec.Pop();
                }
                result[i] = rec.Count == 0 ? 0 : rec.Peek() - i;
                rec.Push(i);
            }

            return result;
        }

        // My Final Solution
        public int[] DailyTemperatures3(int[] T) 
        {
            Stack<int> stackTemperature = new Stack<int>();
            int[] result = new int[T.Length];

            for (int i = T.Length - 1; i >= 0; i--)
            {
                while(stackTemperature.Count > 0 && T[i] >= T[stackTemperature.Peek()])
                {
                    stackTemperature.Pop();
                }

                result[i] = (stackTemperature.Count == 0) ? 0 : stackTemperature.Peek() - i;
                stackTemperature.Push(i);
            }
            
            return result;
        }
    }
}
