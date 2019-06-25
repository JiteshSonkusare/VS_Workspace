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
    class HashTablesRansomNote
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            int mg = magazine.Length;
            int nt = note.Length;
            Array.Sort(magazine);
            Array.Sort(note);
            int ctr = 0;
            int match = 0;
            while (ctr < mg && match < nt)
            {
                if (note[match] == magazine[ctr]) { match++; }
                ctr++;
            }
            if (match == nt)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        //static void Main(string[] args)
        //{
        //    string[] mn = Console.ReadLine().Split(' ');

        //    int m = Convert.ToInt32(mn[0]);

        //    int n = Convert.ToInt32(mn[1]);

        //    string[] magazine = Console.ReadLine().Split(' ');

        //    string[] note = Console.ReadLine().Split(' ');

        //    checkMagazine(magazine, note);
        //}
    }
}
