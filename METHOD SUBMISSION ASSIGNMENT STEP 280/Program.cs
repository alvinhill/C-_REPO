using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_SUBMISSION_ASSIGNMENT_STEP_280
{
    class Program
    {
        static void Main()
        {
            CALC calc = new CALC();

           
           
            // ENTER NUMBERS
            Console.Write("ENTER TWO NUMBERS ONE AT A TIME. ");
            int Number1 = Convert.ToInt32(Console.ReadLine());

            // THIS OVERRIDES THE THE OPTIONAL PARAMETER AND ADDS
            Console.Write("PRESS ENTER TO SKIP SECOND NUMBER  ");
            string signal = Console.ReadLine();

            // SWITCH TO MAKE THE CHOICE AND STORE VALUE FOR SECOND NUMBER IN "signal"
            if (signal == "")
            {
                // OUTPUT NUMBER WITH OPTIONAL PARAMENTER ADDED TO IT.
                Console.WriteLine("TOTAL WITH AUTO INPUT "+calc.AddNumber(Number1));

            }
            else
            {
             //   Console.Write("ENTER NUMBER 2 ");
                int Number2 = Convert.ToInt32(signal);
                
                //OUTPUT NUMBER ONE AND NUMBER 2 ADDED TOGETHER
                Console.WriteLine("TOTAL OF MANUAL INPUT "+calc.AddNumber(Number1, Number2));
             }

            Console.ReadLine();

        }
    }
}
