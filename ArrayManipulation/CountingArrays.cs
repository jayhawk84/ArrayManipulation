using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayManipulation
{
    public class CountingArrays
    {
        public static int CountThisArray(int[] numbersArray)
        {
            // declare an integer array and grab provided values from main method
            int[] providedArray = numbersArray;

            // declare length var and calculate number of elements in array
            int lengthOfArray = providedArray.Length;
            Console.WriteLine($"The number of elements in the array is: {lengthOfArray}");

            //declare sum
            var sum = 0;
            //loop through and count the array values
            for (var i = 0; i < providedArray.Length; i++)
            {
                sum += providedArray[i];
            }
            Console.WriteLine($"The sum of the elements is: {sum}");
            // compute the average
            double average = Convert.ToDouble(sum) / Convert.ToDouble(providedArray.Length);
            Console.WriteLine($"The average of the elements is: {average}\n");
            return sum;

        }
    }
}
