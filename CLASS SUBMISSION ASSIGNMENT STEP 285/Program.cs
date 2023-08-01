using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT_STEP_285
{
    // PART SIX
    //STATIC CLASS
    static class data
    {
        public static string FName;

        // STATIC METHOD
        public static void GName()
        {
            Console.WriteLine("ENTER NAME ");
            FName = Console.ReadLine();
            Console.WriteLine("name is " + FName);
            Console.ReadLine();

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            // CLASS SUBMISSION ASSIGNMENT STEP 285

            // CREATE OBJECT
            CALC calc = new CALC();

            //part 1 and 2 
            // ENTER NUMBER INTO THE DoWork METHOD IN THE CALC CLASS
            Console.WriteLine("PART 1 and 2 create void class that outputs integer");
            Console.Write("Divide your number by 2");
            Console.WriteLine("");

            // numOne IS THE VALUE SENT
            int numOne = Convert.ToInt32(Console.ReadLine());

            //part 3 
            // GET THE RESULT OF DoWork METHOD
            Console.WriteLine("PART 3 call method to screen");
            Console.WriteLine("");
            calc.DoWork(numOne, out int answer);
            // DISPLAY THE RESULT
            Console.Write("THE ANSWER = " + answer);
            Console.ReadLine();

            // part 4
            Console.WriteLine("PART 4 output parameters");
            Console.WriteLine("");
            Console.Write("ENTER FIRST NUMBER a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ENTER SECOND NUMBER b ");
            int b = Convert.ToInt32(Console.ReadLine());
            calc.Data(a, b, out int x, out int y);
            // DISPLAY THE RESULT
            Console.WriteLine("THE ANSWER- a plus b = " + x + "   a times b = " + y);
            Console.ReadLine();

            // part 5
            Console.WriteLine("PART 5 overload method ");
            Console.WriteLine("");
            Console.Write("ENTER FIRST NUMBER c ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("ENTER SECOND NUMBER d ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("ENTER THIRD NUMBER e ");
            int e = Convert.ToInt32(Console.ReadLine());

            // DO MATH
            calc.Data(c, d, e, out int z);
            // DISPLAY THE RESULT
            Console.WriteLine("THE ANSWER- c plus d plus e = " + z);
            Console.ReadLine();






        }
    }
}
