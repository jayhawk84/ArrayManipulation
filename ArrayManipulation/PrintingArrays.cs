using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayManipulation
{
    public class PrintingArrays
    {
        public static void PrintThisArray (int[] givenArray)
        {
            int[] PrintArray = givenArray;
            Console.WriteLine();
            Console.Write($"Your array provided was: ");
            for (int i = 0; i < givenArray.Length; i++)
            {
                if (i != (givenArray.Length - 1))
                {
                    Console.Write($"{givenArray[i]}, ");
                }
                else Console.Write($"{givenArray[i]}");
            }
            Console.WriteLine();
        }

    }
}
