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
            Console.Write($"Your first array was: ");
            for (int i = 0; i < givenArray.Length; i++)
            {
                if (i != (givenArray.Length - 1))
                {
                    Console.Write($"{givenArray[i]}, ");
                }
                else Console.Write($"{givenArray[i]}");
            }
            Console.WriteLine();
            Console.Write($"Your array reversed is: ");
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
