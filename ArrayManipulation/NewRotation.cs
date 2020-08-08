using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ArrayManipulation
{
    public class NewRotation
    {
        public static int[] NewRotatedArray(int[] givenArray, string WhichDirection = "", int NumberOfRotations = 0)
        {
            int[] NewlyRotated = new int[givenArray.Length];
            int[] RotateThisArray = givenArray;

            string direction = WhichDirection;
            
            while ((direction != "r") && (direction != "l"))
            {
                Console.WriteLine("\n\nPlease select a direction to rotate the array.  You may only select  L for Left, R for right: ");
                direction = Console.ReadLine();
            }
            int placesRotated = NumberOfRotations;
            Console.Write("How many places would you like to rotate the elements?  ");
            while (placesRotated <= 0 || placesRotated >= givenArray.Length )
            {
                //then need to ask user how many places
                Console.WriteLine($"You must choose a positive integer value less than {givenArray.Length}.");
                placesRotated = int.Parse(Console.ReadLine());
                //the loop needs a if/else case to decide whether to run forward or backward initially
                //if (placesRotated > givenArray.Length) throw new Exception("This is an invalid response.  Please select a number that is less than" +
                //    "the number of elements in the array.");
                //if (placesRotated < 0) throw new Exception("Please choose a positive integer");
                //if (placesRotated >= 0 && placesRotated < givenArray.Length) { continue; }
            }
            if (direction == "l")
            {
                //if the number of rotations is greater than (length - current index value) then we need a second loop 
                //one loops need to shift element starting from the front instead of at [rotation #] 
                //other loop needs to shift elements starting from [rotation # to end]
                int j = 0;
                for (int i = placesRotated; i < givenArray.Length; i++)
                {
                    NewlyRotated[j] = givenArray[i];
                    j++;
                }
                for (int i = 0; i < placesRotated; i++)
                {
                    NewlyRotated[j] = givenArray[i];
                    j++;
                }

            }
            else
            {
                int j = 0;
                // this loop needs to start from last index minus the number of rotations, then loop forward.
                for (int i = givenArray.Length - placesRotated; i < givenArray.Length; i++)
                {
                    NewlyRotated[j] = givenArray[i];
                    j++;
                }
                // this loop needs to start at index 0 and loop forward up until where the first loop started
                for (int i = 0; i < givenArray.Length - placesRotated; i++)
                {
                    NewlyRotated[j] = givenArray[i];
                    j++;
                }
            }
            
            Console.Write($"Your first array was: ");
            for (int i = 0; i < givenArray.Length; i++)
            {
                Console.Write($"{givenArray[i]}, ");
            }
            Console.WriteLine();
            Console.Write($"Your array rotated {placesRotated} places to the {(direction == "l" ? "left" : "right")} is: ");
            for (int i = 0; i < NewlyRotated.Length; i++)
            {
                Console.Write($"{NewlyRotated[i]}, ");
            }
            Console.WriteLine();
            return NewlyRotated;
        }
        /*public static int[] NewRotatedArray(int[] givenArray, string WhichDirection, int NumberOfRotations)
        {
            int[] NewlyRotated = new int[givenArray.Length];
            string direction = WhichDirection;
            int placesRotated = NumberOfRotations;
        }*/
    }
}
