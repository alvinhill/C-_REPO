using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUMERATIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            // SET UP TRY BLOCK FOR ERROR DETECTION
            try
            {
                string data;

                // ENTER THE DAY OF THE WEEK TO AFFECT
                Console.WriteLine("Sun,Mon,Tue,Wed,Thu,Fri or Sat");
                Console.Write("ENTER THE DAY OF THE WEEK ");
                data = Console.ReadLine();

                // GET AND DISPLAY THE ENUM ITEM
                Console.WriteLine(Enum.Parse(typeof(DAYS), data));
                Console.ReadLine();

                // ENTER THE NEW INTEGER VALUE INTO THE ENUM
                Console.Write("Assign New Value to That Day ");
                int x = Convert.ToInt32(Console.ReadLine());

                // PLACE NUMBER INTO THE ENUM
                object CDayN = (DAYS)x;

                // DISPLAY THE NEW INTEGER VALUE
                Enum.TryParse("0", out DAYS value);
                Console.WriteLine("the new value is " + (DAYS)x);
                Console.ReadLine();
            }

            // SET UP CATCH BLOCKS
            catch (FormatException)
            {

                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();
            }
            catch (System.ArgumentException)
            {
                //  Console.WriteLine("The program has emerged from a try/cacth block");
                // Console.WriteLine("This will allow the program to contiue");

                Console.WriteLine("Please enter an integer");
                Console.ReadLine();
            }
        }

        // ENUMERATION
        enum DAYS : int
        {
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat
        }




    
    }
}
