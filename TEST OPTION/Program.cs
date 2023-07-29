using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_OPTION
{
    class Program
    {
        static void Main()

        {
            TEST test = new TEST();

            string signal;

            // THIS OVERRIDES THE THE OPTIONAL PARAMETER AND ADDS
            // THE FIRST NUMBER TO THE SECOND NUMBER

            Console.Write("ENTER NUMBER 1 ");
            int Number1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("PRESS \"y\" TO AOUTMATICALLY ADD 10  ");
            signal = Console.ReadLine();

            // SWITCH TO MAKE THE CHOICE
            if (signal=="y")
            {
               // OUTPUT NUMBER WITH OPTIONAL PARAMENTER ADDED TO IT.
                Console.WriteLine(test.AddNumber(Number1));

                Console.ReadLine();
            }
          else
            {
                Console.Write("ENTER NUMBER 2 ");
                int Number2 = Convert.ToInt32(Console.ReadLine());

                //OUTPUT NUMBER ONE AND NUMBER 2 ADDED TOGETHER
                Console.WriteLine(test.AddNumber(Number1, Number2));
                Console.ReadLine();

            }

        }
    }
}
