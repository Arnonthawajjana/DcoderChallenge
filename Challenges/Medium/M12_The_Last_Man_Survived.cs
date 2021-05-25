using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge
    //https://code.dcoder.tech/challenges/57c362347b6a33c622e8e1fe/the-last-man-survived
  public class M12_The_Last_Man_Survived
  {
    public static void Main(string[] args)
    {
        //Resource
        //http://puzzles.nigelcoldwell.co.uk/sixtyfour.htm got Formula | 2 * (X - Y) + 1 | X=number of survivor Y= power of 2 that close to X
        //https://www.quora.com/100-people-standing-in-a-circle-in-an-order-1-to-100-No-1-has-a-sword-He-kills-the-next-person-i-e-No-2-and-gives-the-sword-to-the-next
        //-i-e-No-3-All-people-do-the-same-until-only-1-survives-Which-number-survives-at-the-last-I-want-C++-program-for-this
        // Sanket Sapkal, studied Computer Engineering answer

        var numberOfSurvivorsEachCases = new List<int>();
        var testCaseNumber = Convert.ToInt32(Console.ReadLine());

        for(int i=0; i < testCaseNumber;i++)//Inset to List
            numberOfSurvivorsEachCases.Add(Convert.ToInt32(Console.ReadLine()));

        foreach(var suvivorCase in numberOfSurvivorsEachCases) //2 * (X - (Y)) + 1
            Console.WriteLine(2 * (suvivorCase - Math.Pow(2, Math.Floor(Math.Log(suvivorCase)/Math.Log(2)))) +1  );
    }
  }
}