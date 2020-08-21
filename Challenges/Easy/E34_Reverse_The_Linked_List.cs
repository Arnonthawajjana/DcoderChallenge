using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/58518f3c093111872dec3564/reverse-the-linked-list

    public class E34_Reverse_The_Linked_List
    {
        public static void Main(string[] args)
        {
            int[] inputNumber = Array.ConvertAll(Console.ReadLine().Split(" ",StringSplitOptions.None),Convert.ToInt32);
            bool foundTheEndOfLinkList = false;
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlistnode-1?view=netframework-4.5
            var anLinkedList = new LinkedList<int>();
            foreach (int item in inputNumber)
            {
                //filter over limit data out
                if(0 > item || item > 100)
                {
                    if(-1 == item)
                        foundTheEndOfLinkList = true;
                    else
                        Console.WriteLine("You Insert something over the limit");

                    break;
                }
                //Add to Linklist
                else
                    anLinkedList.AddLast(item);
            }
            if(foundTheEndOfLinkList)
            {
                var currentLinkedList = anLinkedList.Last;
                do
                {
                    if (currentLinkedList.Next!= null) Console.Write(" ");
                    Console.Write(currentLinkedList.Value);
                    currentLinkedList = currentLinkedList.Previous;
                }
                while(currentLinkedList != null);
            }
        }

    }
}