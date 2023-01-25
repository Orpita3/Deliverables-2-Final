/*
 Author: Orpita Shreya
Date:1/19/2023
Description: C# Console Application for calculating letter grades
*/
using System;
using System.Transactions;

namespace Deliverables_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade:");
            try
            {

                int grade = int.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                }
                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                }
                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                }

                else if (grade >= 50 && grade < 60)
                {
                    letter = "F";
                }
            }
            catch
            {
                Console.WriteLine("Enter a numeric value");
            }
        }
    }
}