using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57b055771e1ff69730edabf2/the-triangle-game
  public class E09_The_Triangle_Game
  {
    public static void Main(string[] args)
    {
        string inputText = Console.ReadLine();
        //Check round number
        if(inputText.Length > 20)
            Console.WriteLine("words too long bitch");
        else
            for(int i = 0; i < inputText.Length; i++)
            {
                Console.WriteLine(inputText.Substring(0,i+1));
            }
    }
  }
}