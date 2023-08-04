using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM_SUBMISSION_ASSIGNMENT___306
{
    public abstract class PERSON
        // BASE CLASS
    {
        // CREATE 2 PROPERITES 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // CREATE sayname METHOD TO PRINTOUT NAMES
        public virtual void SayName()
        {
            // this method has been overridden in the EMPLOYEE class
            Console.WriteLine("Name: " + FirstName + " " + LastName);
           
        }
    }

    








}
