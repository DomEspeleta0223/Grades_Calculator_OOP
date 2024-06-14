using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace Grade_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter How Many Subjects You Want To Enter:\t");
            int NoOfSubs = Convert.ToInt16(Console.ReadLine());

            int average = Grades(NoOfSubs);
            string description = Description(average);

            Console.WriteLine("Your Average is " + average + description);

        }

        public static int Grades(int num1)
        {
            int[] Grades = new int[num1];
            int sum = 0;
            int[] maximum = new int[num1];
            for (int i = 0; i < num1; i++)
            {
                Console.Write("Enter Grades:\t");
                Grades[i] = Convert.ToInt16(Console.ReadLine());
                maximum[i] = 100 + sum;
                sum = sum + Grades[i];

                if (sum > maximum[i])
                {
                    Console.WriteLine("Invalid Input!");
                    break; 
                }
            }
            int average = sum / num1;
            return average;
        }

        public static string Description(int num1)
        {
            string description = "";

            if (num1 > 50 && num1 <= 70)
            {
                description = " FAIR";
            }
            else if (num1 > 70 && num1 <= 80)
            {
                description = "GOOD";
            }
            else if (num1 > 80 && num1 <= 90)
            {
                description = " VERY GOOD";
            }
            else if (num1 > 90 && num1 <= 100)
            {
                description = " EXCELENT!";
            }

            return description;
        }
    }
}

