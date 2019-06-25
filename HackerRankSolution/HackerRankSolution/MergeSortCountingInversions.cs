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
    class MergeSortCountingInversions
    {
        static long countInversions(int[] arr)
        {
            return MergeSort(arr, 0, arr.Length);
        }

        private static long MergeSort(int[] a, int low, int high)
        {
            var n = high - low;
            if (n <= 1)
            {
                return 0;
            }

            var mid = low + n / 2;

            var swapsLeft = MergeSort(a, low, mid);
            var swapsRight = MergeSort(a, mid, high);
            long swaps = 0;

            var temp = new int[n];
            var i = low;
            var j = mid;
            for (var k = 0; k < n; k++)
            {
                if (i == mid)
                {
                    temp[k] = a[j++];
                }
                else if (j == high)
                {
                    temp[k] = a[i++];
                }
                else if (a[i] > a[j])
                {
                    temp[k] = a[j++];
                    swaps += mid - i;
                }
                else
                {
                    temp[k] = a[i++];
                }
            }

            for (var k = 0; k < n; k++)
            {
                a[low + k] = temp[k];
            }

            return swapsLeft + swapsRight + swaps;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int t = Convert.ToInt32(Console.ReadLine());

        //    for (int tItr = 0; tItr < t; tItr++)
        //    {
        //        int n = Convert.ToInt32(Console.ReadLine());

        //        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        //        ;
        //        long result = countInversions(arr);

        //        textWriter.WriteLine(result);
        //    }

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
