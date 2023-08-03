using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION_ASSIGNMENT__PAGE_302
{
    class Program
    {
        static void Main(string[] args)
        {

            // CREATE EMPLOYEE OBJECT
            EMPLOYEE employee = new EMPLOYEE();
            {
                employee.FirstName = "Patty";
                employee.LastName = "Smith";
            }
            // CALL sayname METHOD FROM EMPLOYEE CLASS
            employee.SayName();
            Console.ReadLine();




        }
    }
}
