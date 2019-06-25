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

namespace HackerRankSolution.DynamicProgramming
{
    class Candies
    {
        static long candies(int n, int[] arr)
        {
            int[] candies = new int[arr.Length];

            candies[0] = 1;
            for (int i = 1; i < arr.Length; i++)
                if (arr[i - 1] < arr[i])
                    candies[i] = candies[i - 1] + 1;
                else
                    candies[i] = 1;


            long sumCandies = candies[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] > arr[i + 1])
                    candies[i] = Math.Max(candies[i + 1] + 1, candies[i]);
                sumCandies += candies[i];
            }

            return sumCandies;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] arr = new int[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        int arrItem = Convert.ToInt32(Console.ReadLine());
        //        arr[i] = arrItem;
        //    }

        //    long result = candies(n, arr);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
