using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _229_REDO
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            bool isX;
            bool isY;
            int y = 10;
            int x = 10;


            // WHILE LOOP
            while (x < 10) ;
            // PRINT VALUE OF X AND LABEL THE LOOP
            Console.WriteLine(x + "  while Loop");

            // LOOK FOR VALUE OF X
            if (x > 5)
            {
                // CHECK BOOLEAN
                isX = true;
                // PRINT BOOLEAN RESULT
                Console.WriteLine(isX);
            }
            Console.WriteLine();// MAKE SPACE

            // DO LOOP
            do
            {
                // PRINT VALUE OF Y AND LABEL THE LOOP
                Console.WriteLine(y + "  do loop");

                if (x > 5)
                {
                    // BOOLEAN
                    isY = true;
                    // PRINT BOOLEAN RESULT
                    Console.WriteLine(isY);
                    Console.ReadLine();

                }
            }
            // CHECK THE VALUE OF Y FOR POSSIBLE NEXT ITERATION
            while (y < 10);
            //
            // INSERT READLINE TO FREEZE DISPALY

        








    }
    }
}
