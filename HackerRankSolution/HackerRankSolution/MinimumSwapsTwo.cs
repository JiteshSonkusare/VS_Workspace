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
    class MinimumSwapsTwo
    {
        static int minimumSwaps(int[] arr)
        {
            int swap = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 != arr[i])
                {
                    int t = i;
                    while (arr[t] != i + 1)
                    {
                        t++;
                    }
                    int temp = arr[t];
                    arr[t] = arr[i];
                    arr[i] = temp;
                    swap++;
                }
            }
            return swap;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        //    ;
        //    int res = minimumSwaps(arr);

        //    textWriter.WriteLine(res);

        //    textWriter.Flush();
        //    textWriter.Close();

        //    Console.WriteLine(res);
        //    Console.ReadLine();
        //}
    }
}
