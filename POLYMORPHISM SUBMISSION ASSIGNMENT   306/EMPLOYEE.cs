using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM_SUBMISSION_ASSIGNMENT___306
{
    // EMPLOYEE INHERITS PERSON AND IQuittable INTERFACE
    public class EMPLOYEE :PERSON ,IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
           
        }


        // INTERFACE METHOD
        public void Quit()
        {
           
            Console.WriteLine("Interface Message ");

        }




    }
}
