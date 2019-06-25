using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace HackerRankSolution.Search
{
    class SwapNodesAlgo
    {
        public class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int value)
            {
                this.value = value;
            }
        }

        public static void Swap(int k, int cur, Node n)
        {
            if (n == null)
                return;

            if (cur < k)
            {
                Swap(k, cur + 1, n.left);
                Swap(k, cur + 1, n.right);
                return;
            }

            Node temp = n.left;
            n.left = n.right;
            n.right = temp;

            Swap(k, 1, n.left);
            Swap(k, 1, n.right);
        }

        public static void TraverseNodes(Node n, List<int> lst)
        {
            if (n == null)
                return;

            if (n.left != null)
                TraverseNodes(n.left, lst);

            lst.Add(n.value);

            if (n.right != null)
                TraverseNodes(n.right, lst);
        }

        static int[][] swapNodes(int[][] indexes, int[] queries)
        {

            Node root = new Node(1);
            Node cur;
            Queue<Node> q = new Queue<Node>();
            int[][] result = new int[queries.Length][];

            q.Enqueue(root);
            for (int i = 0; i < indexes.Length; i++)
            {
                cur = q.Dequeue();

                if (indexes[i][0] != -1)
                {
                    cur.left = new Node(indexes[i][0]);
                    q.Enqueue(cur.left);
                }

                if (indexes[i][1] != -1)
                {
                    cur.right = new Node(indexes[i][1]);
                    q.Enqueue(cur.right);
                }
            }

            List<int> lst;
            for (int i = 0; i < queries.Length; i++)
            {
                Swap(queries[i], 1, root);
                lst = new List<int>();
                TraverseNodes(root, lst);
                result[i] = lst.ToArray();
            }

            return result;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[][] indexes = new int[n][];

        //    for (int indexesRowItr = 0; indexesRowItr < n; indexesRowItr++)
        //    {
        //        indexes[indexesRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), indexesTemp => Convert.ToInt32(indexesTemp));
        //    }

        //    int queriesCount = Convert.ToInt32(Console.ReadLine());

        //    int[] queries = new int[queriesCount];

        //    for (int queriesItr = 0; queriesItr < queriesCount; queriesItr++)
        //    {
        //        int queriesItem = Convert.ToInt32(Console.ReadLine());
        //        queries[queriesItr] = queriesItem;
        //    }

        //    int[][] result = swapNodes(indexes, queries);

        //    textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));
        //    Console.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));

        //    textWriter.Flush();
        //    textWriter.Close();
        //    Console.ReadLine();
        //}
    }
}
