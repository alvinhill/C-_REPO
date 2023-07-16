using System;
using System.Collections.Generic; 
using System.Text;
using System.Threading.Tasks;

namespace PACKAGE_EEXPRESS
{
    class Program
    {
        static void Main()
        {
            // VARIABLES
            Decimal weight;
            Decimal Width;
            Decimal height;
            Decimal lenght;
            Decimal total;
            Decimal pretotal1;
            Decimal pretotal2;
            Decimal pretotal3;

            // PRDecimal TITLE
            Console.WriteLine("** WELCOME TO PACKAGE EXPESS ***");

            Console.WriteLine("");// ADD SPACE

            // ENTER DATA FOR WEIGHT
            Console.Write("Enter Package Weight ");
            weight = Convert.ToDecimal(Console.ReadLine());

            // PACKAGE WEIGHT
            if (weight>50)
            {
                // EXIT PROGRAM IF PACKAGE TOO HEAVY
                Console.WriteLine("");// ADD SPACE
                Console.WriteLine("Package too Heavy!");
                Console.WriteLine("*** END PROGRAM  ***");
                Console.WriteLine("");// ADD SPACE
                Environment.Exit(0);
            }

            // ENTER DATA FOR WIDTH
            Console.Write("Enter Package Width ");
            Width = Convert.ToDecimal(Console.ReadLine());

            // ENTER DATA FOR HEIGHT
            Console.Write("Enter Package Height ");
            height = Convert.ToDecimal(Console.ReadLine());

            // ENTER DATA FOR LENGHT
            Console.Write("Enter Package Lenght ");
            lenght = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");// ADD SPACE

            // CHECK PACKAGE SIZE
            if (Width + height+lenght>50)
            {
                // EXIT PROGRAM IF PACKAGE TOO BIG
                Console.WriteLine("Your package is too large ");
                Console.WriteLine("for via Package Express ");
                Console.WriteLine("");// ADD SPACE
                Console.WriteLine("*** END PROGRAM  ***");
                Environment.Exit(0);
            }

            // DO CALCULATIONS TO NOT OVERWHELM THE COMPILER
            pretotal1 = lenght * Width;//* height
            pretotal2 = pretotal1 * height;
            pretotal3 =pretotal2*weight;

            total = pretotal3 / 100;

            // PRINT PRICE QUOTE
            Console.WriteLine("Your shipping cost is: $ {0:F2}", total );
            




        }
    }
}
