using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        // STEP 275
        // CALLING_METHODS_SUBMISSION_ASSIGNMENT
        static void Main(string[] args)
        {
            // CREATE OBJECT
            CALC calc = new CALC();

            // INPUT ADDITION METHOD
            Console.Write("Enter a number to do some math on: ");
            calc.numU = Convert.ToInt32(Console.ReadLine());

            // OUTPUT ADDITION ANSWER
            Console.WriteLine("100 ADDED TO THE NUMBER = "+calc.Addnum(calc.numU));
            

            // OUTPUT SUBTRACTION ANSWER
            Console.WriteLine("10 SUBTRACTED FROM THE NUMBER = "+calc.Subnum(calc.numU));
            // Console.ReadLine();

           

            // OUTPUT MULTIPLICATION ANSWER
            Console.Write("10 MULTIPLIED TO THE NUMBER= "+calc.Multnum(calc.numU));
            Console.ReadLine();
















        }
    }
}
