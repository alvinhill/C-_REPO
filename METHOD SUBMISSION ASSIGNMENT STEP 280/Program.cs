using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_SUBMISSION_ASSIGNMENT_STEP_280
{
    class Program
    {
        static void Main()
        {

            // CREATE OBJECT
            CALC calc = new CALC();



            // ENTER NUMBER INTO CALC CLASS
            Console.Write("Enter First Number to Add ");
            calc.NumOne = Convert.ToInt32(Console.ReadLine());

            // ENTER NUMBER INTO CALC CLASS
            Console.Write("Enter Second Number to Add ");
            calc.NumTwo = Convert.ToInt32(Console.ReadLine());

          

            Console.WriteLine("The Answer = "+calc.DoAdd(calc.NumOne, calc.NumTwo));
            Console.ReadLine();
           






        }
    }
}
