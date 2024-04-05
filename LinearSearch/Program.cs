using System;

namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 2, 7, 1, 9, 5, 3, 8, 6, 10 }; //declares an array of integers to search
            int target = 6; //the number the user is searching for
            int index = LinearSearch(numbers, target); //calls the LinearSearch method to find the target number in the array

            if (index == -1)
            {
                Console.WriteLine($"Target number {target} could not be found.");
            }
            else
            {
                Console.WriteLine($"Target number {target} found at index position {index + 1}.");
            }
        }

        static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; //returns index if target is found
                }
            }
            return -1; //returns -1 if target is not found
        }
    }
}