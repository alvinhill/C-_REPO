using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_SUBMISSION_ASSIGNMENT_SREP_279
{
    class Program
    {
        static void Main(string[] args)
        {

            // MAIN METHOD SUBMISSION ASSIGNMENT
            // CREATE OBJECT
            CALC calc = new CALC();

            // ENTER NUMBER INTO CALC CLASS
            Console.Write("Enter Int Number to Multify by Five ");
            calc.numOne = Convert.ToInt32(Console.ReadLine());

            // GET MATH OPERATION FROM FIRST CLASS
            Console.WriteLine(calc.DoMath(calc.numOne));
            Console.ReadLine();

            // ENTER NUMBER INTO CALC CLASS
            Console.Write("Enter Decimal Number That Will Be Subtracted By 15.27 ");
            calc.numTwo = Convert.ToDecimal(Console.ReadLine());

            // GET MATH OPERATION FROM NEXT OVERLOADED CLASS
            Console.WriteLine(calc.DoMath(calc.numTwo));
            Console.ReadLine();

            // ENTER NUMBER INTO CALC CLASS
            Console.Write("Enter A Number to Add 10 To ");
            calc.numThree = (Console.ReadLine());

            // GET MATH OPERATION FROM NEXT OVERLOADED CLASS
            Console.WriteLine(calc.DoMath(calc.numThree));
            Console.ReadLine();

















        }
    }
}
