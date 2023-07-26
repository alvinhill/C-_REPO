using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            // CREATE OBJECT
            CALC calc = new CALC();


            Console.Write("Add 100 to Your Number: ");
            calc.numU = Convert.ToInt32(Console.ReadLine());

            // OUTPUT ADDITION ANSWER
            Console.WriteLine(calc.Addnum());
            Console.ReadLine();

            Console.Write("Subtract 10 From Your Number: ");
            calc.numSC = Convert.ToInt32(Console.ReadLine());

            // OUTPUT SUBTRACTION ANSWER
            Console.WriteLine(calc.Subnum());
            Console.ReadLine();


            Console.Write("Multply Your Number BY 10: ");
            calc.numMC = Convert.ToInt32(Console.ReadLine());

            // OUTPUT MULTIPLICATION ANSWER
            Console.WriteLine(calc.Multnum());
            Console.ReadLine();
















        }
    }
}
