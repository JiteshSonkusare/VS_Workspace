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
    class TwoDArrayDS
    {
        static int hourglassSum(int[][] arr)
        {
            int j = 0;
            int arrMax = arr[0][0] + arr[0][1] + arr[0][2]
                            + arr[1][1] +
                        arr[2][0] + arr[2][1] + arr[2][2];

            while (j < arr.Length - 2)
            {
                for (int i = 0; i < arr.Length - 2; i++)
                {
                    int hgSum = 0;
                    hgSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                            + arr[i + 1][j + 1] +
                        arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (hgSum > arrMax)
                        arrMax = hgSum;
                }
                j++;
            }
            return arrMax;

        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int[][] arr = new int[6][];

        //    for (int i = 0; i < 6; i++)
        //    {
        //        arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //    }

        //    int result = hourglassSum(arr);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}
    }
}
