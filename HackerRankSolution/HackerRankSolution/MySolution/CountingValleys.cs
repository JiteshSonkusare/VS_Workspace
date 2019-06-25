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
    class CountingValleys
    {
        static int countingValleys(int n, string s)
        {
            int sLevel = 0;
            int climb = 0;
            char[] valleys = s.ToCharArray();

            foreach (var ch in valleys)
            {
                if (ch.ToString() == "U")
                {
                    sLevel += 1;
                }
                else if (ch.ToString() == "D")
                {
                    sLevel -= 1;
                }

                if (sLevel == 0 && ch.ToString() == "U")
                {
                    climb += 1;
                }
            }

            return climb;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    string s = Console.ReadLine();

        //    int result = countingValleys(n, s);

        //    textWriter.WriteLine(result);
        //    Console.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //    Console.ReadLine();
        //}
    }
}
