using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM_SUBMISSION_ASSIGNMENT___306
{
    class Program
    {
        static void Main()
        {

            // CREATE EMPLOYEE OBJECT
            EMPLOYEE employee = new EMPLOYEE();
            {
                employee.FirstName = "Jenny";
                employee.LastName = "Gayle";
            }
            // CALL sayname METHOD FROM EMPLOYEE CLASS
            employee.SayName();

            //TYPE     VARIBLE         CLASS
            IQuittable iquittable = new EMPLOYEE();

            // CALL quit INTERFACE METHOD 
            iquittable.Quit();

            Console.ReadLine();

        }

        

    }
}
