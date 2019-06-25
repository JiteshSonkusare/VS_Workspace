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
    class ReverseDoublyLinkedList
    {
        class DoublyLinkedListNode
        {
            public int data;
            public DoublyLinkedListNode next;
            public DoublyLinkedListNode prev;

            public DoublyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
                this.prev = null;
            }
        }

        class DoublyLinkedList
        {
            public DoublyLinkedListNode head;
            public DoublyLinkedListNode tail;

            public DoublyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                    node.prev = this.tail;
                }

                this.tail = node;
            }
        }

        static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter)
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

        // Complete the reverse function below.

        /*
         * For your reference:
         *
         * DoublyLinkedListNode {
         *     int data;
         *     DoublyLinkedListNode next;
         *     DoublyLinkedListNode prev;
         * }
         *
         */
        static DoublyLinkedListNode reverse(DoublyLinkedListNode head)
        {
            // Solution 1:
            //DoublyLinkedListNode temp = head;
            //DoublyLinkedListNode newHead = head;
            //while (temp != null)
            //{
            //    DoublyLinkedListNode prev = temp.prev;
            //    temp.prev = temp.next;
            //    temp.next = prev;
            //    newHead = temp;
            //    temp = temp.prev;
            //}
            //return newHead;

            // Solution 2:
            DoublyLinkedListNode nodeOne = head;
            DoublyLinkedListNode nodeTwo = nodeOne.next;

            nodeOne.next = null;
            nodeOne.prev = nodeTwo;

            while (nodeTwo != null)
            {
                nodeTwo.prev = nodeTwo.next;
                nodeTwo.next = nodeOne;
                nodeOne = nodeTwo;
                nodeTwo = nodeTwo.prev;
            }
            head = nodeOne;
            return head;

        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int t = Convert.ToInt32(Console.ReadLine());

        //    for (int tItr = 0; tItr < t; tItr++)
        //    {
        //        DoublyLinkedList llist = new DoublyLinkedList();

        //        int llistCount = Convert.ToInt32(Console.ReadLine());

        //        for (int i = 0; i < llistCount; i++)
        //        {
        //            int llistItem = Convert.ToInt32(Console.ReadLine());
        //            llist.InsertNode(llistItem);
        //        }

        //        DoublyLinkedListNode llist1 = reverse(llist.head);

        //        PrintDoublyLinkedList(llist1, " ", textWriter);
        //        textWriter.WriteLine();
        //    }

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
