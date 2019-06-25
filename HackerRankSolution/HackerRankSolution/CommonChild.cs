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
    class CommonChild
    {
        static int commonChild(string s1, string s2)
        {
            int[,] matrix = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 0; i <= s2.Length; i++)
            {
                for (int j = 0; j <= s1.Length; j++)
                {
                    if (i == 0 || j == 0)
                        matrix[i, j] = 0;
                    else if (s1[j - 1] == s2[i - 1])
                        matrix[i, j] = matrix[i - 1, j - 1] + 1; 
                    else
                        matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
                }
            }

            return matrix[s1.Length, s2.Length];
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string s1 = Console.ReadLine();

        //    string s2 = Console.ReadLine();

        //    int result = commonChild(s1, s2);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}
    }
}
