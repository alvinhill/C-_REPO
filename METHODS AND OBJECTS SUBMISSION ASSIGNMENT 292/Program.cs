using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT_292
{
    class Program
    {
        static void Main()
        {

            // CREATE EMPLOYEE OBJECT
            EMPLOYEE employee = new EMPLOYEE();
            {
                employee.FirstName = "Fred";
                employee.LastName = "Davis";
                         
               
            }




            // CALL sayname METHOD FROM EMPLOYEE CLASS
            employee.SayName();
            Console.ReadLine();

        }
    }
}
