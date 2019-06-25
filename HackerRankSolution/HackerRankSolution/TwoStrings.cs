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
    class TwoStrings
    {
        static string twoStrings(string s1, string s2)
        {
            //Solution 1:
            //var hash = new HashSet<char>(s1.Length > s2.Length ? s1 : s2);
            //return (s1.Length > s2.Length ? s2 : s1).Any(hash.Contains) ? "YES" : "NO";

            //Solution 2:
            var s1_ar = s1.ToCharArray();
            var s2_ar = s2.ToCharArray();

            HashSet<char> s1_set = new HashSet<char>(s1_ar);
            HashSet<char> s2_set = new HashSet<char>(s2_ar);

            foreach (var i in s1_set)
            {
                if (s2_set.Contains(i))
                {
                    return "YES";
                }
            }

            return "NO";
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int q = Convert.ToInt32(Console.ReadLine());

        //    for (int qItr = 0; qItr < q; qItr++)
        //    {
        //        string s1 = Console.ReadLine();

        //        string s2 = Console.ReadLine();

        //        string result = twoStrings(s1, s2);

        //        textWriter.WriteLine(result);

        //        Console.WriteLine(result);
        //    }

        //    textWriter.Flush();
        //    textWriter.Close();

        //    Console.ReadLine();
        //}
    }
}
