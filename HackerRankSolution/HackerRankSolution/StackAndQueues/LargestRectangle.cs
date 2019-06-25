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
    class LargestRectangle
    {
        static long largestRectangle(int[] h)
        {
            // Solution 1:
            var max = 0;
            var pn = new Stack<int>();
            var ht = new Stack<int>();
            var cur = 0;

            foreach (var hist in h.Select((v, i) => new { pn = i, ht = v }))
            {
                if (pn.Count == 0 || hist.ht > ht.Peek())
                {
                    pn.Push(hist.pn);
                    ht.Push(hist.ht);
                }
                else
                {
                    var oldpn = 0;
                    do
                    {
                        oldpn = pn.Peek();
                        var area = (cur - pn.Pop()) * ht.Pop();
                        max = area > max ? area : max;
                    } while (pn.Count > 0 && hist.ht < ht.Peek());

                    pn.Push(oldpn);
                    ht.Push(hist.ht);
                }
                cur++;
            }
            while (pn.Count > 0)
            {
                var area = (cur - pn.Pop()) * ht.Pop();
                max = area > max ? area : max;
            }
            return max;

            // Solution 2:
            //long max = 0;
            //long area = 0;

            //for (int i = 0; i < h.Length; i++)
            //{
            //    int count = 1;
            //    int x = h[i];
            //    if (i > 0)
            //    {
            //        for (int j = i - 1; j >= 0; j--)
            //        {
            //            if (h[j] > x)
            //            {
            //                count++;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    for (int k = i + 1; k < h.Length; k++)
            //    {
            //        if (h[k] >= x)
            //        {
            //            count++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }

            //    area = count * x;
            //    if (area > max)
            //    {
            //        max = area;
            //    }

            //}

            //return max;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
        //    ;
        //    long result = largestRectangle(h);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
