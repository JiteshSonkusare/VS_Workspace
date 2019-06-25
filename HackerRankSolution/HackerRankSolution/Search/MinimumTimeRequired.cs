using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRankSolution.Search
{
    class MinimumTimeRequired
    {
        private static long FindDays(long[] arr, long low, long high, long goal)
        {
            while (true)
            {
                var mid = low + (high - low) / 2;
                long sum = 0;
                foreach (var x in arr)
                {
                    sum += mid / x;
                    if (sum > goal) { break; }
                }

                if (low > high) return low;
                if (sum > goal) { high = mid - 1; continue; }
                if (sum < goal) { low = mid + 1; continue; }

                high = mid;

                while (low <= high)
                {
                    mid = low + (high - low) / 2;
                    sum = arr.Sum(x => mid / x);
                    if (sum >= goal) high = mid - 1;
                    if (sum < goal) low = mid + 1;
                }

                return low;
            }
        }

        static long minTime(long[] machines, long goal)
        {
            return FindDays(machines, 0, long.MaxValue, goal);
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string[] nGoal = Console.ReadLine().Split(' ');

        //    int n = Convert.ToInt32(nGoal[0]);

        //    long goal = Convert.ToInt64(nGoal[1]);

        //    long[] machines = Array.ConvertAll(Console.ReadLine().Split(' '), machinesTemp => Convert.ToInt64(machinesTemp));
        //    long ans = minTime(machines, goal);

        //    textWriter.WriteLine(ans);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
