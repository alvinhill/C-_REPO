using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXEPTIONS_STEP_263
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONSOLE APP STRINGS AND INTEGERS SUBMISSION ASSIGNMENT STEP 263

            // SETUP LIST
            List<int> numOne = new List<int>();
            numOne.Add(42);
            numOne.Add(37);
            numOne.Add(51);
            numOne.Add(27);


            // SETUP VARIABLES
            int numD;
            int answer;

            // TRY BLOCK
            try
            {
                // ENTER DIVSISOR FOR NUMBERS IN THE LIST
                Console.Write("Enter a Divisor ");
                numD = Convert.ToInt32(Console.ReadLine());

                // LOOP THROUGH THE NUMBER LIST
                for (int i = 0; i < numOne.Count; i++)

                {
                    // DIVIDE NUMBERS AND OUTPUT THE RESULT
                    answer = numOne[i] / numD;
                    Console.WriteLine(numOne[i] + " / " + numD + " = " + answer);
                }

                Console.ReadLine();
            }
            // CATCH BLOCK STRING OR OTHER INCORRECT INPUT
            catch (FormatException ex)
            {
                Console.WriteLine("The program has emerged from a try/cacth block");
                Console.WriteLine("This will allow the program to contiue");

                Console.WriteLine(ex.Message + "Use Numbers Only");
                Console.ReadLine();
            }

            // CATCH BLOCK FOR DIVIDE BY ZERO
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("The program has emerged from a try/cacth block");
                Console.WriteLine("This will allow the program to contiue");
                Console.WriteLine(ex.Message + "Use a Non-Zero Number");
                Console.ReadLine();
            }

        }
    }
}
