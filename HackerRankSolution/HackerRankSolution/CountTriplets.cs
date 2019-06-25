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

namespace HackerRankSolution
{
    class CountTriplets
    {
        static long countTriplets(List<long> arr, long r)
        {
            // Solution 1: 
            //Dictionary<long, long> counts = new Dictionary<long, long>();
            //Dictionary<long, long> pairs = new Dictionary<long, long>();

            //long tripletCount = 0;

            //for (long i = arr.Count - 1; i > -1; i--)
            //{
            //    long num = arr[(int)i];
            //    long numR = num * r;

            //    if (pairs.ContainsKey(numR))
            //    {
            //        tripletCount += pairs[numR];
            //    }

            //    if (counts.ContainsKey(numR))
            //    {
            //        if (pairs.ContainsKey(num))
            //            pairs[num] += counts[numR];
            //        else
            //            pairs[num] = counts[numR];
            //    }


            //    if (counts.ContainsKey(num))
            //    {
            //        counts[num]++;
            //    }
            //    else
            //    {
            //        counts[num] = 1;
            //    }
            //}

            //return tripletCount;

            // Solution 1:
            var mp2 = new Dictionary<long, long>();
            var mp3 = new Dictionary<long, long>();
            long res = 0;
            foreach (long val in arr)
            {
                if (mp3.ContainsKey(val))
                    res += mp3[val];
                if (mp2.ContainsKey(val))
                    if (mp3.ContainsKey(val * r))
                        mp3[val * r] += mp2[val];
                    else
                        mp3[val * r] = mp2[val];
                if (mp2.ContainsKey(val * r))
                    mp2[val * r]++;
                else
                    mp2[val * r] = 1;
            }
            return res;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string[] nr = Console.ReadLine().TrimEnd().Split(' ');

        //    int n = Convert.ToInt32(nr[0]);

        //    long r = Convert.ToInt64(nr[1]);

        //    List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        //    long ans = countTriplets(arr, r);

        //    textWriter.WriteLine(ans);
        //    Console.WriteLine(ans);

        //    textWriter.Flush();
        //    textWriter.Close();
        //    Console.ReadLine();
        //}
    }
}
