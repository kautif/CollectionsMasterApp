﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            int[] RandomNumbers() {
                Random rnd = new Random();
                for (int i = 0; i < 50; i++)
                {
                    numbers[i] = rnd.Next(1, 50);
                }
                return numbers;
            }

            //TODO: Print the first number of the array
            Console.WriteLine(numbers[0]);

            //TODO: Print the last number of the array            
            Console.WriteLine(numbers[numbers.Length - 1]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            int[] revArr = new int[50];
            int index = 0;
            numbers.Reverse();

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            foreach (int i in numbers) {
                if (numbers[i] % 3 == 0) {
                    numbers[i] = 0;
                }
            }

            Console.WriteLine($"Multiple of three = 0: {numbers}");

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> integer = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"List Capacity: {integer.Count}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Random rnd = new Random();
            for (int i = 0; i < 50; i++) {
                integer.Add(rnd.Next(1, 50));
            }

            //TODO: Print the new capacity
            Console.WriteLine($"New List Capacity: {integer.Count}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            string enteredID = Console.ReadLine();
            int parsedID = int.Parse(enteredID);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(integer);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            List<int> oddsOnly () {
                foreach (int i in integer)
                {
                    if (integer[i] % 2 == 0)
                    {
                        integer.Remove(i);
                    }
                }
                Console.WriteLine($"Evens: {integer}");

                return integer;
            }
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            integer.Sort();
            List<int> evensOnly()
            {
                foreach (int i in integer)
                {
                    if (integer[i] % 3 == 0)
                    {
                        integer.Remove(i);
                    }
                }
                Console.WriteLine($"Odds: {integer}");
                return integer;
            }

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] listToArray = integer.ToArray();

            //TODO: Clear the list
            integer.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
