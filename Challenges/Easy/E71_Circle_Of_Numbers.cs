using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/5b85bc2bb6415039901fa9d4/circle-of-numbers
    public class E71_Circle_Of_Numbers
    {
        public static void Main(string[] args)
        {
        //main number divided by two would be looks like this
        // 1 2 3  1 2 3 4  1 2 3 4 5 6
        // 6 5 4  5 6 7 8  7 8 9 10 11 12
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
            int peopleCount = inputs[0];
            if(4 > peopleCount || peopleCount > 20) Console.WriteLine("It's Overlimit");
            else{
                int oppositeNumber = inputs[1];
                if(oppositeNumber > peopleCount || 1 > oppositeNumber) Console.WriteLine("It's Over people count number");
                else{
                    /* my failed
                    int middle = peopleCount/2;
                    int resultOppositeNumber = -1;
                    if(oppositeNumber > middle) resultOppositeNumber = oppositeNumber - middle;
                    else if(oppositeNumber <= middle) resultOppositeNumber = middle + oppositeNumber;
                    else{
                        Console.WriteLine("WTF");
                    }
                    Console.WriteLine(resultOppositeNumber);
                    */
                    // https://programmingcode4life.blogspot.com/2016/09/circle-of-numbers-codefight.html
                    Console.WriteLine((oppositeNumber+(peopleCount/2)) % peopleCount);
                }
            }
        }
    }
}