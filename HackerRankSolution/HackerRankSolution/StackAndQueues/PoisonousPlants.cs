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
    class PoisonousPlants
    {
        static int poisonousPlants(int[] p) 
        {
            long n = p.Length;
            int min = p[0];
            int mdays = 0;
            for (int i = 1; i < n; i++)
            {
                min = Math.Min(min, p[i]);

                if (p[i] > p[i - 1])
                {
                    int l = p[i];
                    int k = i + 1;
                    int day = 1;
                    while (k < n && min < p[k])
                    {
                        if (p[k] <= l)
                        {
                            l = p[k];
                            ++day;
                        }
                        ++k;
                    }
                    mdays = Math.Max(mdays, day);
                }
            }

            return mdays;
        }
        
        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Int32.Parse(Console.ReadLine());

        //    int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Int32.Parse(pTemp));
            
        //    int result = poisonousPlants(p);

        //    textWriter.WriteLine(result);
        //    Console.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //    Console.ReadLine();
        //}

        // Solution 2:
        //static void Main(string[] args)
        //{
        //    int n = Int32.Parse(Console.ReadLine());
        //    string[] h1_temp = Console.ReadLine().Split(' ');
        //    int[] h1 = Array.ConvertAll(h1_temp, Int32.Parse);
        //    int min = h1[0];
        //    int mdays = 0;
        //    for (int i = 1; i < n; i++)
        //    {
        //        min = Math.Min(min, h1[i]);
        //        if (h1[i] > h1[i - 1])
        //        {
        //            int l = h1[i];
        //            int k = i + 1;
        //            int day = 1;
        //            while (k < n && min < h1[k])
        //            {
        //                if (h1[k] <= l)
        //                {
        //                    l = h1[k];
        //                    ++day;
        //                }
        //                ++k;
        //            }
        //            mdays = Math.Max(mdays, day);
        //        }
        //    }
        //    Console.WriteLine(mdays);
        //}
    }
}
