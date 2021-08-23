using System;

namespace Exercises31_32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 31
            int[] randomArray = new int[5];

            randomArray[0] = 2;
            randomArray[1] = 8;
            randomArray[2] = 0;
            randomArray[3] = 24;
            randomArray[4] = 51;

            string userContinue1;

            do
            {
                Console.WriteLine("Enter an index of the array: ");
                int enteredNumber1 = int.Parse(Console.ReadLine());

                bool contains = false;
                for (int i = 0; i < randomArray.Length; i++)
                {
                    if (enteredNumber1 == randomArray[i])
                    {
                        contains = true;
                    }
                }

                if (contains == true)
                {
                    Console.WriteLine($"The value at index {enteredNumber1} is {randomArray[enteredNumber1]}.");
                }
                else
                {
                    Console.WriteLine("That is not a valid index.");
                }

                Console.WriteLine("Would you like to continue (y / n)?");
                userContinue1 = Console.ReadLine();
            } while (userContinue1 == "y");
            Console.WriteLine("Goodbye!");

            //Exercise 32
            int[] arrayRandom = new int[5];

            arrayRandom[0] = 2;
            arrayRandom[1] = 8;
            arrayRandom[2] = 0;
            arrayRandom[3] = 24;
            arrayRandom[4] = 51;

            string userContinue2;

            do
            {
                Console.WriteLine("Enter a number: ");
                int enteredNumber2 = int.Parse(Console.ReadLine());

                bool contains2 = false;
                for (int i = 0; i < arrayRandom.Length; i++)
                {
                    if (enteredNumber2 == i)
                    {
                        contains2 = true;
                    }
                }

                if (contains2 == true)
                {
                    Console.WriteLine($"The value {enteredNumber2} can be found at index {}.");
                }
                else
                {
                    Console.WriteLine("That value cannot be found in the array.");
                }

                Console.WriteLine("Would you like to continue (y / n)?");
                userContinue2 = Console.ReadLine();
            } while (userContinue2 == "y");
            Console.WriteLine("Goodbye!");
        }
    }
}
