using System;
using System.Collections.Generic; //to make my list work
using System.Linq; //to be able to count items in a list

namespace howmanyoddnumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //initiate the list
            List<int> numbers = new List<int>();
            Console.WriteLine("How many odd numbers in a list?\nEnter up to 25 numbers.\nHit enter when finished.\n");
            

            //create loop to have user enter up to 25 numbers to put into list. when they hit enter without a value,
            //they are finished adding and the loop will stop.
            for (int i = 0; i < 25; i++)
            {
                Console.Write("Enter value {0}: ", i + 1);
                string numberString = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(numberString))
                    break;

                int number = int.Parse(numberString);
                numbers.Add(number);

            }

            //initiate new list to put only the odd numbers into from user-entered list
            List<int> oddNumbers = new List<int>();

            //create loop that tests each number from above loop to see if it is odd,
            //and if it is odd it puts it into the new oddNumbers list.
            //if even, it will skip onto the next value.
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    oddNumbers.Add(number);
                }

                else continue;
            }

            //count how many odd numbers are in the oddNumber list.
            int numberOdd = oddNumbers.Count();

            //line break for clarity
            Console.WriteLine();
            //print number of odd numbers to console
            Console.WriteLine("Number of odd values in list: {0}", numberOdd);

            Console.ReadLine();
        }

    }
}
