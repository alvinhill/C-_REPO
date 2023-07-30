using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_CLASS_SUBMISSION_ASSIGNMENT_281
{
    class Program
    {
        static void Main()

        {
            // CREATE OBJECT
            MAKE make = new MAKE();

            // PLACE VALUES IN THE MAKE METHOD
            make.doAction(72, 43);

            // PASS VALUES INTO THE MAKE METHOD BY NAME
            make.doAction(num1: 17 , num2: 11);
            Console.ReadLine();

            // FINAL OUTPUT NOT WORKING
            //Console.WriteLine(make.doAction(num1:,num2:));

            Console.ReadLine();

        }
    }
}
