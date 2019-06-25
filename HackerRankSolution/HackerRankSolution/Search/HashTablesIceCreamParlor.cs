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

namespace HackerRankSolution.Search
{
    class HashTablesIceCreamParlor
    {
        static void whatFlavors(int[] cost, int money)
        {
            // Solution 1:
            //Dictionary<int, int> map = new Dictionary<int, int>();
            //for (int i = 0; i < cost.Length; i++)
            //{
            //    int complement = money - cost[i];
            //    if (map.ContainsKey(complement))
            //    {
            //        System.Console.WriteLine((map[complement] + 1) + " " + (i + 1));
            //        return;
            //    }
            //    map.Add(cost[i], i);
            //}

            int z = 0, x = 0;
            for (int i = 0; i < cost.Length; i++)
            {
                z = cost[i];
                for (int j = 0; j < cost.Length; j++)
                {
                    if (i == j) continue;

                    x = cost[j];
                    if (z + x == money)
                    {
                        z = i + 1;
                        x = j + 1;
                        i = cost.Length;
                        break;
                    }
                }
            }

            string result = (z <= x) ? z + " " + x : x + " " + z;
            Console.WriteLine(result);
        }

        //static void Main(string[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());

        //    for (int tItr = 0; tItr < t; tItr++)
        //    {
        //        int money = Convert.ToInt32(Console.ReadLine());

        //        int n = Convert.ToInt32(Console.ReadLine());

        //        int[] cost = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), costTemp => Convert.ToInt32(costTemp));

        //        whatFlavors(cost, money);
        //    }
        //}
    }
}
