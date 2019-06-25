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
    class FraudulentActivityNotifications
    {
        internal class SortedList<T>
        {
            private readonly List<T> src;

            public SortedList() => this.src = new List<T>();

            public int Count => src.Count;

            public void Add(T item)
            {
                int insertIndex = src.BinarySearch(item);
                if (insertIndex < 0) insertIndex = ~insertIndex;
                src.Insert(insertIndex, item);
            }

            public T this[int index] => src[index];

            public bool Remove(T item)
            {
                int index = src.BinarySearch(item);
                if (index < 0) return false;
                src.RemoveAt(index);
                return true;
            }
        }

        public static double Median(SortedList<int> ar)
        {
            int n = ar.Count;
            double median = (ar[n / 2] + ar[(n - 1) / 2]) / 2.0;
            return median;
        }

        public static int activityNotifications(int[] expenditure, int d)
        {
            int notifications = 0;
            var previousExpenditures = new SortedList<int>();
            for (int i = 0; i < d; i++) 
            {
                previousExpenditures.Add(expenditure[i]);
            }
            for (int i = d; i < expenditure.Length; i++)
            {
                if (expenditure[i] >= 2 * Median(previousExpenditures))
                {
                    notifications++;
                }
                previousExpenditures.Remove(expenditure[i - d]);
                previousExpenditures.Add(expenditure[i]);
            }
            return notifications;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string[] nd = Console.ReadLine().Split(' ');

        //    int n = Convert.ToInt32(nd[0]);

        //    int d = Convert.ToInt32(nd[1]);

        //    int[] expenditure = Array.ConvertAll(Console.ReadLine().Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp))
        //    ;
        //    int result = activityNotifications(expenditure, d);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
