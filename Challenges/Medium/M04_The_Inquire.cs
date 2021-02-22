using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge
    //https://code.dcoder.tech/challenges/57a8e1701e1ff69730eda02a/the-inquire
  public class M04_The_Inquire

  {
    public static void Main(string[] args)
    {
        int houseNumber = Convert.ToInt32(Console.ReadLine());
        int[] peopleLivingInEachHouse = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.None), Convert.ToInt32);
        int queryRequestNumber = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < queryRequestNumber; i++)
        {
            int[] houseRangeForSurveyQuery = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.None), Convert.ToInt32);
            //Convert Number To Index Array number.
            houseRangeForSurveyQuery[0] = houseRangeForSurveyQuery[0]-1;
            houseRangeForSurveyQuery[1] = houseRangeForSurveyQuery[1]-1;
            int result = 0;
            for(int j = houseRangeForSurveyQuery[0]; j <= houseRangeForSurveyQuery[1]; j++)
            {
                result += peopleLivingInEachHouse[j];
            }
            Console.WriteLine(result);

        }
    }
  }
}