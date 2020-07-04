using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57b04e4c1e1ff69730edabe7/the-rock-paper-scissor-game
  public class E08_The_Rock_Paper_Scissor_Game
  {
    public static void Main(string[] args)
    {
        int roundmax = Convert.ToInt32(Console.ReadLine());
        string matchRPS = "";
        //Check round number
        if(1 > roundmax)
            Console.WriteLine("round is minus or float");
        //input RPS match
        else{
            matchRPS = Console.ReadLine().ToUpper();
        }
        //count match should be even
        if(matchRPS.Length != roundmax*2)
            Console.WriteLine("Matches is not even");
        //Main process Start here
        else{
            int index = 1;
            string result;
            for(int currentround = 0; currentround < roundmax; currentround++)
            {
                result = Wincheck(matchRPS[index-1], matchRPS[index]);
                Console.WriteLine(result);
                if(result == "FAIL!!")
                {
                    Console.WriteLine($"Break at round {currentround}");
                    break;
                }
                index+=2;
            }
       }
    }
   public static string Wincheck(char dcoder, char you)
   {
       //Validate that have RPS only
       string Validate = "RPS";
       if(Validate.IndexOf(dcoder) < 0 || Validate.IndexOf(you) < 0)
            return "FAIL!!";

       //DRAW CASE
       if(dcoder == you)
            return "Draw";
       //DCODER WIN CASE
       else if ((dcoder == 'R' && you == 'S') || (dcoder == 'S' && you == 'P') || (dcoder == 'P' && you == 'R'))
            return "Dcoder";
       //YOU WIN CASE
       else
            return "You";
   }
  }
}