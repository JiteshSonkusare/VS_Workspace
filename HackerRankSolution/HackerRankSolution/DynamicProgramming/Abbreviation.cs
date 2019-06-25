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
    class Abbreviation
    {
        static string abbreviation(string a, string b)
        {
            bool[,] isValid = new bool[a.Length + 1, b.Length + 1];

            isValid[0, 0] = true;
            bool containsUppercase = false;
            for (int k = 1; k <= a.Length; k++)
            {
                int i = k - 1;
                if (a[i] <= 90 && a[i] >= 65 || containsUppercase)
                {
                    containsUppercase = true;
                    isValid[k, 0] = false;
                }
                else isValid[k, 0] = true;
            }
            for (int k = 1; k <= a.Length; k++)
            {
                for (int l = 1; l <= b.Length; l++)
                {
                    int i = k - 1; int j = l - 1;
                    if (a[i] == b[j])
                    {
                        isValid[k, l] = isValid[k - 1, l - 1];
                        continue;
                    }
                    else if ((int)a[i] - 32 == (int)b[j])
                    {
                        isValid[k, l] = isValid[k - 1, l - 1] || isValid[k - 1, l];
                        continue;
                    }
                    else if (a[i] <= 90 && a[i] >= 65)
                    {
                        isValid[k, l] = false;
                        continue;
                    }
                    else
                    {
                        isValid[k, l] = isValid[k - 1, l];
                        continue;
                    }
                }
            }
            return isValid[a.Length, b.Length] ? "YES" : "NO";
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int q = Convert.ToInt32(Console.ReadLine());

        //    for (int qItr = 0; qItr < q; qItr++)
        //    {
        //        string a = Console.ReadLine();

        //        string b = Console.ReadLine();

        //        string result = abbreviation(a, b);

        //        textWriter.WriteLine(result);
        //    }

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
