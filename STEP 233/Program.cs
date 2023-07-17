using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEP_233
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE SEPERATE STRINGS
            string part1 = "I want to ";
            string part2 = "eat choclate ";
            string part3 = "ice cream ";

            // CONCATENATE THE STRINGS
            Console.WriteLine(part1 + part2 + part3);
            Console.WriteLine(""); // CREATE SPACE

            // CONVERT STRING TO UPPERCASE
            Console.WriteLine(part1.ToUpper());
            Console.WriteLine(""); // CREATE SPACE

            // SETUP AND CREATE VARIABLES FOR STRING BUILDER
            string theString = "";
            string partA = "four score and seven years ago ";
            string partB = "I took the Chevy to the levee but the levee was dry ";
            string partC = "And the only thing we have to fear is fear itself";

            // CREATE STRING BUILDER OBJECT
            StringBuilder myStringBuilder = new StringBuilder();

            // SETUP VARIBLES TO APPEND WITH STRING BUILDER
            myStringBuilder.Append(partA);
            myStringBuilder.Append(partB);
            myStringBuilder.Append(partC);

            // ASSIGN AND CONNECT STRINGS FOR STRING BUILDER
            theString = myStringBuilder.ToString();
            // DISPLAY THE HUGE STRING
            Console.WriteLine(theString);
        }
    }
}
