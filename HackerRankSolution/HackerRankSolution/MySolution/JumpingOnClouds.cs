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
    class JumpingOnClouds
    {
        static int jumpingOnClouds(int[] c)
        {
            List<int> temp = new List<int>();
            int jumps = 0;
            
            for (int i = 0; i < c.Length - 1; i++)
            {
                jumps++;

                if (i + 2 < c.Length && c[i + 2] == 0)
                {
                    i++;
                }
            }
            
            return jumps;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            textWriter.WriteLine(result);
            Console.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
            Console.ReadLine();
        }
    }
}
