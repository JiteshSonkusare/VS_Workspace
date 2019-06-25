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

namespace HackerRankSolution.LinkedLists
{
    class InsertNodeAtSpecificPositionInLinkedList
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }

        // Complete the insertNodeAtPosition function below.

        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */
        static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            // Solution 1:
            SinglyLinkedListNode n = new SinglyLinkedListNode(data);

            SinglyLinkedListNode node = head;
            while (position != 1 && node.next != null)
            {
                node = node.next;
                position--;
            }
            SinglyLinkedListNode temp = node.next;
            node.next = n;
            n.next = temp;
            return head;


            // Solution 2:
            //SinglyLinkedListNode n = new SinglyLinkedListNode(data)
            //{
            //    data = data
            //};

            //if (head == null)
            //{
            //    head = n;
            //    return head;
            //}

            //if (position == 0)
            //{
            //    n.next = head;
            //    return n;
            //}

            //else
            //{
            //    int ctr = 0;

            //    SinglyLinkedListNode temp1 = head;

            //    while (ctr < position - 1 && temp1.next != null)
            //    {
            //        temp1 = temp1.next;
            //        ctr++;
            //    }

            //    SinglyLinkedListNode temp2 = temp1.next;

            //    temp1.next = n; 
            //    n.next = temp2; 

            //    return head;

            //}
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    SinglyLinkedList llist = new SinglyLinkedList();

        //    int llistCount = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < llistCount; i++)
        //    {
        //        int llistItem = Convert.ToInt32(Console.ReadLine());
        //        llist.InsertNode(llistItem);
        //    }

        //    int data = Convert.ToInt32(Console.ReadLine());

        //    int position = Convert.ToInt32(Console.ReadLine());

        //    SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

        //    PrintSinglyLinkedList(llist_head, " ", textWriter);
        //    textWriter.WriteLine();

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
