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


namespace HackerRankSolution.StackAndQueues
{
    class MinMaxRiddle
    {
        static long MaxWin(long i, long[] pair, Dictionary<long, long> maxWin) =>
        !maxWin.ContainsKey(pair[1]) || maxWin[pair[1]] < i - pair[0]
        ? i - pair[0]
        : maxWin[pair[1]];

        static long[] riddle(long[] arr)
        {
            long[] pair;

            var maxWin = new Dictionary<long, long>();
            var stack = new Stack<long[]>(); // No ValueTuples on hr
            foreach (var now in arr.Select((v, i) => new { v, i }))
            {
                pair = new[] { now.i, now.v };
                if (stack.Count == 0 || now.v > stack.Peek()[1])
                {
                    stack.Push(pair);
                }
                else
                {
                    while (stack.Count > 0 && now.v < stack.Peek()[1])
                    {
                        pair = stack.Pop();
                        maxWin[pair[1]] = MaxWin(now.i, pair, maxWin);
                    }
                    stack.Push(new[] { pair[0], now.v });
                }
            }
            while (stack.Count > 0)
            {
                pair = stack.Pop();
                maxWin[pair[1]] = MaxWin(arr.Length, pair, maxWin);
            }

            var winMax = new Dictionary<long, long>();
            foreach (var kvp in maxWin)
            {
                if (!winMax.ContainsKey(kvp.Value) || kvp.Key > winMax[kvp.Value])
                    winMax[kvp.Value] = kvp.Key;
            }

            var result = new long[arr.Length];
            var max = long.MinValue;
            for (var i = arr.Length; i >= 1; i--)
            {
                max = winMax.ContainsKey(i) && winMax[i] > max ? winMax[i] : max;
                result[i - 1] = max;
            }
            return result;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp))
        //    ;
        //    long[] res = riddle(arr);

        //    textWriter.WriteLine(string.Join(" ", res));
        //    Console.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //    Console.ReadLine();
        //}
    }
}
