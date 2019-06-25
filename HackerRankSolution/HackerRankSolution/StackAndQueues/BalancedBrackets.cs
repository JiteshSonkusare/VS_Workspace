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
    class BalancedBrackets
    {
        static string isBalanced(string s)
        {
            if (s.Length % 2 == 1)
                return "NO";
            Char[] bc = s.ToCharArray();
            int[] b = new int[bc.Length];

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = Convert.ToInt32(bc[i]);
            }

            Stack<int> sta = new Stack<int>();
            int c;
            for (int i = 0; i < b.Length; i++)
            {
                if (sta.Count == 0)
                {
                    if (b[i] == 125 || b[i] == 93 || b[i] == 41)
                        return "NO";
                    sta.Push(b[i]);
                    continue;
                }
                c = sta.Peek();
                switch (b[i])
                {
                    case 125:
                    case 93:
                        if (c != b[i] - 2) return "NO";
                        sta.Pop();
                        break;
                    case 41:
                        if (c != 40) return "NO";
                        sta.Pop();
                        break;
                    default: sta.Push(b[i]); break;
                }
            }
            return (sta.Count > 0) ? "NO" : "YES";
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int t = Convert.ToInt32(Console.ReadLine());

        //    for (int tItr = 0; tItr < t; tItr++)
        //    {
        //        string s = Console.ReadLine();

        //        string result = isBalanced(s);

        //        textWriter.WriteLine(result);
        //        Console.WriteLine(result);
        //    }

        //    textWriter.Flush();
        //    textWriter.Close();
        //    Console.ReadLine();
        //}
    }
}
