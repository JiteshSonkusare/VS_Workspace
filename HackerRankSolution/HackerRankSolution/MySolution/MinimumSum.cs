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

class Result
{
    /*
     * Complete the 'minSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY num
     *  2. INTEGER k
     */

    public static int minSum(List<int> num, int k)
    {
        List<int> temp = new List<int>();

        for (int i = 0; i < k; i++)
        {
            if (num.Count > i)
            {
                temp.Add((int)Math.Round((decimal)num[i] / 2));
            }
            else
            {
                int maxValue = temp.Max();
                decimal cal = Math.Round((decimal)maxValue / 2);
                int index = temp.IndexOf(maxValue);

                if (index > -1)
                    temp[index] = (int)cal;
            }
        }

        return temp.Sum(x => Convert.ToInt32(x));
    }
}

class Solution
{
    //public static void Main(string[] args)
    //{
    //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //    int numCount = Convert.ToInt32(Console.ReadLine().Trim());

    //    List<int> num = new List<int>();

    //    for (int i = 0; i < numCount; i++)
    //    {
    //        int numItem = Convert.ToInt32(Console.ReadLine().Trim());
    //        num.Add(numItem);
    //    }

    //    int k = Convert.ToInt32(Console.ReadLine().Trim());

    //    int result = Result.minSum(num, k);

    //    textWriter.WriteLine(result);
    //    Console.WriteLine(result);

    //    textWriter.Flush();
    //    textWriter.Close();
    //    Console.ReadLine();
    //}
}

