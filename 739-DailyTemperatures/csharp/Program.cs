using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[8]{73, 74, 75, 71, 69, 72, 76, 73};
            Solution solution = new Solution();
            int[] ouput = solution.DailyTemperatures3(input);
        }
    }
}
