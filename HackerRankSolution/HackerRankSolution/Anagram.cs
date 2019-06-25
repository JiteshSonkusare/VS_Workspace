using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolution
{
    public class Solution
    {
        public static int MakeAnagram(string a, string b)
        {
            //get all the characters in both strings
            var group = string.Concat(a, b)

                //remove duplicates
                .Distinct()

                //count the times each character appears in word1 and word2, find the
                //difference, and repeat the character difference times
                .SelectMany(i => Enumerable.Repeat(i, Math.Abs(
                    a.Count(j => j == i) -
                    b.Count(j => j == i))));

            return group.Count();
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string a = Console.ReadLine();

        //    string b = Console.ReadLine();

        //    int res = MakeAnagram(a, b);

        //    textWriter.WriteLine(res);

        //    textWriter.Flush();
        //    textWriter.Close();

        //    Console.WriteLine(res);

        //    Console.ReadLine();
        //}
    }
}


