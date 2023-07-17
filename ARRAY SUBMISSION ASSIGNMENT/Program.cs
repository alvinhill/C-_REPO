using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main()
        {
            // SELECTION VARIABLE
            int num;

            // SETUP AND POPULATE ARRAY
            string[] data = new string[5];
            data[0] = "Janet";
            data[1] = "Jenny";
            data[2] = "Peggy";
            data[3] = "Mary";
            data[4] = "Staci";

            // GET USER ENTRY
            Console.Write("Enter a Number (0 to 4) to Get a Name ");
            num = Convert.ToInt32(Console.ReadLine());

            // STOP THE PROGRAM IF THE SELECTION IS TOO HIGH
            if (num > 4)
            {
                Console.WriteLine("Selection Of Range ");
                Environment.Exit(0);
            }
            // SELECT AND DISPLAY THE PERSON 
            Console.WriteLine("Her name is: "+ data[num]);
                       
            Console.WriteLine("");// MAKE A SPACE

            // SELECTION VARIABLE
            int num1;

            // SETUP AND POPULATE ARRAY
            int[] money = { 1, 5, 10, 20, 50};

            // GET USER ENTRY
            Console.Write("Enter a Number (0 to 4) to Get a dollar denomonation ");
            num1 = Convert.ToInt32(Console.ReadLine());

            // STOP THE PROGRAM IF THE SELECTION IS TOO HIGH
            if (num1 > 4)
            {
                Console.WriteLine("Selection Of Range ");
                Environment.Exit(0);
            }

            // SELECT AND DISPLAY THE DOLLARS
            Console.WriteLine("You selected "+money[num1]+" dollars");
            Console.WriteLine("");// MAKE A SPACE

            // SELECTION VARIABLE
            int num2;

            // SETUP AND POPULATE LIST
            List<string> cars = new List<string>();
            cars.Add("Ford");
            cars.Add("Chevy");
            cars.Add("Honda");
            cars.Add("Dodge");
            cars.Add("Lambegini");

            // GET USER ENTRY
            Console.Write("Enter a Number (0 to 4) to Select a Make of Car ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // STOP THE PROGRAM IF THE SELECTION IS TOO HIGH
            if (num2 > 4)
            {
                Console.WriteLine("Selection Of Range ");
                Environment.Exit(0);
            }

            // SELECT AND DISPLAY THE CAR
            Console.WriteLine("Your car is "+cars[num2]);
            Console.WriteLine("");// MAKE A SPACE
        }
    }
}
