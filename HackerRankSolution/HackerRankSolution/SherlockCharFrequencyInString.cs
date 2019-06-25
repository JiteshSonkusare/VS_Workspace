using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolution
{
    public class SherlockCharFrequencyInString
    {
        static string isValid(string s)
        {
            var groups = s
                .GroupBy(c => c)
                .Select(grp => grp.Count())
                .GroupBy(c => c)
                .OrderBy(grp => grp.Key)
                .Select(c => new { K = c.Key, N = c.Count() })
                .ToList();

            var min = groups.First();
            var max = groups.Last();
            var count = groups.Count();

            if (count == 1)
                return "YES";
            else if (count > 2)
                return "NO";
            else if (min.K == 1 && min.N == 1)
                return "YES";
            else if (max.N == 1 && max.K == min.K + 1)
                return "YES";
            else
                return "NO";
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string s = Console.ReadLine();

        //    string result = isValid(s);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}
    }
}

//var groupsOfChars = s.GroupBy(i => i);
//Dictionary<char, int> repeatedCharacters = new Dictionary<char, int>();

//groupsOfChars.ToList().ForEach(grpChar =>
//{
//    repeatedCharacters.Add(grpChar.Key, grpChar.Count());
//});

//var countList = repeatedCharacters
//    .GroupBy(ch => ch.Value)
//    .ToDictionary(rw => rw.Count(), rw => rw.Key).ToList();


//if (countList.Count() == 1)
//{
//    return "YES";
//}
//else if (countList.Count() == 2)
//{
//    foreach (var item in countList)
//    {
//        if (item.Key == 1)
//        {


//            return "YES";
//        }
//    }
//}

//return "NO";
