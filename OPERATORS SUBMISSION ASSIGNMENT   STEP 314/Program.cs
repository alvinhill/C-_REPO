using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORS_SUBMISSION_ASSIGNMENT___STEP_314
{
    class Program
    {
        static void Main(string[] args)
        {
            // CREATE TWO OBJECTS WITH DIFFERENT PROPERTY VALUES
            EMPLOYEE employee1 = new EMPLOYEE();
            employee1.Id = 1;
            employee1.FirstName = "Fred";
            employee1.LastName = "Davis";

            EMPLOYEE employee2 = new EMPLOYEE();
            employee2.Id = 2;
            employee2.FirstName = "June";
            employee2.LastName = "Travis";

            // COMPARE OBJECTS WITH ==
            if (employee1==employee2)
            {
                Console.WriteLine("These employees are equal ");
            }
            else
            {
                Console.WriteLine("These employees are NOT equal ");
            }
            Console.ReadLine();
        }
    }
}
