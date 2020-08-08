using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayManipulation
{
    public class ReverseArrays
    {
        public static int[] ReversedArray(int[] givenArray)
        {
            // grab the array provided by the user
            int[] reverseThisArray = givenArray;

            //loop backwards through the array and assign the values to a new array
            int[] nowReversed = new int[reverseThisArray.Length];
            int j = 0;
            for (int i = reverseThisArray.Length -1; i >= 0; i--)
            {
                nowReversed[j] = reverseThisArray[i];
                j++;
            }
            for (int i = 0; i < nowReversed.Length;i++)
            {
                if (i != (nowReversed.Length - 1)){
                    Console.Write($"{nowReversed[i]}, ");
                }
                else Console.Write($"{nowReversed[i]}");
            }
            return nowReversed;
        }
        
    }
}
