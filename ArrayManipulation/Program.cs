using Microsoft.VisualBasic;
using System;

namespace ArrayManipulation
{
    class Program
    {

        static void Main(string[] args)
        {
            // my own array provided
            int[] array1 = { 4, 5, 5, 3, 2, 1, 6, 9, 1, 22, 8 };
            int[] array2 = { 3, 5, 2, 6, 4, 8, 7 };
            // arrays provided by the instructions
            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 2, 4, 6, 8, 10 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            CountingArrays.CountThisArray(array1);
            CountingArrays.CountThisArray(arrayA);
            CountingArrays.CountThisArray(arrayB);
            CountingArrays.CountThisArray(arrayC);

            ReverseArrays.ReversedArray(arrayA);
            
            // Call rotation method without explicit parameters, console app asks for input:
            NewRotation.NewRotatedArray(arrayA);
            NewRotation.NewRotatedArray(arrayC);

            //Call rotation method on arrays A B C using direction and number as required in instructions
            NewRotation.NewRotatedArray(arrayA, "l", 2);
            NewRotation.NewRotatedArray(arrayB, "r", 2);
            NewRotation.NewRotatedArray(arrayC, "l", 4);


        }
    }
}
