using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATETIME_SUBMISSION_ASSIGNMENT_STEP_370
{
    class Program
    {
        static void Main(string[] args)


        {

            // SET UP VARIABLE
            int x;

            // DISPLAY MESSAGE
            Console.WriteLine("THE CURRENT TIME IS: ");
            // DISPALY CURRENT TIME
            Console.WriteLine(DateTime.Now);


            Console.WriteLine("");
            // ASK FOR NUMBER OF HOURS TO ADD
            Console.Write("ENTER A NUMBER ");

            // INPUT VARIABLE VALUE
            x =Convert.ToInt32(Console.ReadLine());

            // CREATE DATETIME VARIABLE 
            // USE "NOW" METHOD TO DISPLAY CURRENT TIME
            // ADD HOURS TO Mytime VARIABLE
            DateTime Mytime = DateTime.Now.AddHours(x);
            Console.Write("IN " + x + " HOURS, IT WILL BE: "+Mytime);

          
            Console.ReadLine();

        }
    }
}
