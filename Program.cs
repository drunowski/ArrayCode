//Author: David runowski
//Date: 02/06/2020
using System;

namespace ArrayCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] davidsArray = new int[25];//create davids array with length of 25
            for (int i = 1; i <= 25; i++)//use for loop to fill davidsarray
            {
                davidsArray[i - 1] = i;//fill davidsarray at i-1 with i value

            }
            for (int i = 0; i < davidsArray.Length; i++)//use for loop to go through davidsArray
            {
                Console.WriteLine("Element Value= " + davidsArray[i]);//Print each element in davidsArray.
            }

        }

        
    }
}
