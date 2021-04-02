using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge
    //https://code.dcoder.tech/challenges/57b0a91b1e1ff69730edac3d/anything-you-can-do-i-can-do-better
  public class M08_Anything_You_Can_Do_I_Can_Do_Better
  {
    public static string MakeItBetter(string inputText)
    {
          string result = inputText;

          if(inputText.EndsWith("e")) result = result + "r";
          else if(inputText.EndsWith("y")) result = (result.Remove(result.Length-1)) + "ier";
          else if(inputText.EndsWith("er")) result = (result.Remove(result.Length-1)) + "st";
          else if(inputText.EndsWith("est")) result = result; //stay not change
          else result = result + "er";

        return result;
    }
    public static void Main(string[] args)
    {
        int numberWords = Convert.ToInt32(Console.ReadLine());
        var lines = new List<string>();

        //looping in then thorw to make it better to upscale word before store to the list.
        for(int loop=0;loop < numberWords; loop++)
            lines.Add(MakeItBetter(Console.ReadLine()));
        //Just prin it out.
        foreach(string aLine in lines)
            Console.WriteLine(aLine);
    }
  }
}