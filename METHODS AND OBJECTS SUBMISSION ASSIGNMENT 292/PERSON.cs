using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT_292
{
    class PERSON
    {   
        // CREATE 2 PROPERITES 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // CREATE sayname METHOD TO PRINTOUT NAMES
        public void SayName()
       {
        Console.WriteLine("Name: "+FirstName+" "+LastName);

            Console.ReadLine();

        }
        
    }





}
