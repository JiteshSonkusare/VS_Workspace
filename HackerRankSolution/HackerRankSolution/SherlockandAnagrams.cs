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
    class SherlockandAnagrams
    {
        static int sherlockAndAnagrams(string s)
        {
            var matches = 0;

            for (int i = 1; i <= s.Length - 1; i++)
            {
                var a = new List<string>();

                for (int j = 0; j <= s.Length - i; j++)
                {
                    a.Add(new string(s.Substring(j, i).OrderBy(c => c).ToArray()));
                }

                var b = (from c in a
                         group c by c into g
                         select new
                         {
                             Key = g.Key,
                             Count = g.Count()
                         })
                        .ToDictionary(g => g.Key, g => g.Count);

                foreach (var v in b.Values)
                {
                    matches += v * (v - 1) / 2;
                }
            }

            return matches;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int q = Convert.ToInt32(Console.ReadLine());

        //    for (int qItr = 0; qItr < q; qItr++)
        //    {
        //        string s = Console.ReadLine();

        //        int result = sherlockAndAnagrams(s);

        //        textWriter.WriteLine(result);
        //        Console.WriteLine(result);
        //    }

        //    textWriter.Flush();
        //    textWriter.Close();
        //    Console.ReadLine();
        //}
    }
}
