using System;
using System.Collections.Generic;

namespace howmanyoddnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Count how many odd numbers are in a list.

            //List<string> optionList = new List<string>
            //{ "AdditionalCardPersonAdressType", /* rest of elements */ };

            List<int> numbers = new List<int>();

            Console.WriteLine("Enter up to 50 numbers to add to list.");


            for (int i = 0; i < 50; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);

                int userNumber = int.Parse(Console.ReadLine());
                
                numbers.Add(userNumber);

                if (string.IsNullOrWhiteSpace(userNumber.ToString())) break;

            }








            Console.ReadLine();
        }
    }
}
