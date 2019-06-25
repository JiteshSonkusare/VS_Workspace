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
    class DictHashFrequencyQueries
    {
        static List<int> freqQuery(List<List<int>> queries)
        {
            var structure = new Dictionary<int, int>();
            var frequencies = new Dictionary<int, int>();
            var res = new List<int>();
            for (int queryIndex = 0; queryIndex < queries.Count(); queryIndex++)
            {
                var operation = queries[queryIndex][0];
                var operand = queries[queryIndex][1];

                if (operation == 1)
                {
                    var structureContainsOperand = structure.ContainsKey(operand);
                    var currentFrequency = structureContainsOperand ? structure[operand] : 0;

                    if (structureContainsOperand)
                        structure[operand]++;
                    else
                        structure.Add(operand, 1);

                    if (frequencies.ContainsKey(currentFrequency))
                        frequencies[currentFrequency]--;

                    if (frequencies.ContainsKey(currentFrequency + 1))
                        frequencies[currentFrequency + 1]++;
                    else
                        frequencies.Add(currentFrequency + 1, 1);

                }
                else if (operation == 2)
                {
                    var structureContainsOperand = structure.ContainsKey(operand);
                    var currentFrequency = structureContainsOperand ? structure[operand] : 0;

                    if (structureContainsOperand && structure[operand] > 0)
                        structure[operand]--;

                    if (frequencies.ContainsKey(currentFrequency))
                        frequencies[currentFrequency]--;

                    if (frequencies.ContainsKey(currentFrequency - 1))
                        frequencies[currentFrequency - 1]++;
                    else
                        frequencies.Add(currentFrequency - 1, 1);

                }
                else if (operation == 3)
                {
                    if (frequencies.ContainsKey(operand) && frequencies[operand] > 0)
                        res.Add(1);
                    else
                        res.Add(0);
                }
            }

            return res;

        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int q = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<List<int>> queries = new List<List<int>>();

        //    for (int i = 0; i < q; i++)
        //    {
        //        queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        //    }

        //    List<int> ans = freqQuery(queries);

        //    textWriter.WriteLine(String.Join("\n", ans));
        //    Console.WriteLine(String.Join("\n", ans));

        //    textWriter.Flush();
        //    textWriter.Close();
        //    Console.ReadLine();
        //}
    }
}
