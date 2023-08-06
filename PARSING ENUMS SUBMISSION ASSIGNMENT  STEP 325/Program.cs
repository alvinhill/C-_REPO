using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARSING_ENUMS_SUBMISSION_ASSIGNMENT__STEP_325
{
    class Program

    {
        static void Main(string[] args)
        {

            DAYS days;

            //days = DAYS.Monday;
            //Console.WriteLine(days);
            //Console.ReadLine();
            string data;


            // int dayData = (int)DAYS.Friday;
            //Console.WriteLine(dayData);

            // Console.ReadLine();
            //Console.WriteLine(Enum.IsDefined(typeof(DAYS), "Monday"));

            //Console.WriteLine(Enum.GetName(typeof(DAYS), "Monday"));


          if (Enum.TryParse<DAYS>("4",out days))
            {
                if (Enum.IsDefined(typeof(DAYS), days))
                    Console.WriteLine(days + "found");
            }

           // Console.WriteLine(Enum.IsDefined(typeof(DAYS), "Monday"));
            Console.ReadLine();



            //  Console.WriteLine("Your Day is Number: "+x);







        }
        enum DAYS :int
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday ,
            Saturday 
        }

    }
}
