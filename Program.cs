using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPARE_INCOME
{
    class Program
    {
        static void Main()
        {
            // SET UP VARIABLES
            double personOneR;
            double personOneH;
            double totalPers1;

            double personTwoR;
            double personTwoH;
            double totalPers2;

            bool compAns;

            // PRINT TITLE
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");// ADD SPACE

            // ENTER DATA FOR PART ONE PERSON 1
            Console.WriteLine("PERSON 1");
            Console.Write("Enter The Hourly Rate ");
            personOneR = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Hours Worked Per Week ");
            personOneH = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");// ADD SPACE

            // ENTER DATA FOR PART ONE PERSON 2
            Console.WriteLine("PERSON 2");
            Console.Write("Enter The Hourly Rate ");
            personTwoR = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Hours Worked Per Week ");
            personTwoH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");// ADD SPACE

            Console.WriteLine("   ***   Conclusion:   ***   ");
            // PRINT SALARY FOR PERSON 1
            totalPers1 = (personOneR * personOneH) * 52;
            Console.WriteLine("The Annual Salary of Person 1 is: $ {0:F2}", totalPers1);

            // PRINT SALARY FOR PERSON 2
            totalPers2 = (personTwoR * personTwoH) * 52;
            Console.WriteLine("The Annual Salary of Person 2 is: $ {0:F2}", totalPers2);

            // ASK COMPARISON QUESTION ON SCREEN AND DO BOOLEAN COMPARISON
            Console.WriteLine("");// ADD SPACE
            Console.WriteLine("   ***   DOes Person 1 Make More Money that Person 2 ?   ***   ");
            compAns = totalPers1 > totalPers2;

            // ANSWER QUESTION AND SHOW COMPARISON RESULT
            Console.WriteLine("");// ADD SPACE
            Console.WriteLine("The Answer is: " + compAns);
            Console.WriteLine("");// ADD SPACE
            Console.WriteLine(" ");// ADD SPACE





        }
    }
}
