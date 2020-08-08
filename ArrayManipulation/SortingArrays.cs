using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayManipulation
{
    public class SortingArrays
    {
        public static int[] SortedArray(int[] GivenArray)
        {

            //int[] CopyOfGivenArray = GivenArray;
            int[] UnsortedArray = GivenArray;
            int[] temp = UnsortedArray;
            int[] SortedArray = temp;
            
            int j = 0;
            // need to loop through the first array and determine which values are highest and assign them to the next array indexed by size
            for (int i = 0; i < SortedArray.Length-1; i++)
            {
                //TODO;
                for (int k = i + 1; k < SortedArray.Length; k++)
                {
                    if (SortedArray[i] < SortedArray[k])
                    {
                        j = SortedArray[i];
                        SortedArray[i] = SortedArray[k];
                        SortedArray[k] = j;
                    }
                }

            }
            /* 
            // The array is a reference type so the newly assigned index values apply to the original array as well.
            // Because of this I'm commenting out the next lines because it's confusing
            // I went ahead and made a new class and method for printing out the original array instead
            Console.Write($"Your first array was: ");
            for (int i = 0; i < UnsortedArray.Length; i++)
            {
                Console.Write($"{UnsortedArray[i]}, ");
            }
            */
            
            Console.Write($"Your new array sorted is: ");
            for (int i = 0; i < SortedArray.Length; i++)
            {
                if (i != (SortedArray.Length - 1))
                {
                    Console.Write($"{SortedArray[i]}, ");
                }
                else Console.Write($"{SortedArray[i]}");
            }
            Console.WriteLine();
            return SortedArray;
        }
    }
}
