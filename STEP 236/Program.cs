using System;
using System.Collections.Generic;


//CONSOLE APP STRINGS AND INTEGERS SUBMISSION ASSIGNMENT STEP 263

    class Program
    {
    static void Main()
    {
        List<int> numOne = new List<int>();
        numOne.Add(42);
        numOne.Add(37);
        numOne.Add(51);
        numOne.Add(27);

        int numD;
        int answer;

        try
        {
            Console.Write("Enter a Divisor ");
            numD = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numOne.Count; i++)

            {
                answer = numOne[i] / numD;
                Console.WriteLine( numOne[i]+ " / "+ numD+  " = "+answer);

            }

            Console.ReadLine();

        }
            
        catch (FormatException ex)
        {
            Console.WriteLine("The program has emerged from a try/cacth block");
            Console.WriteLine("This will allow the program to contiue");

            Console.WriteLine(ex.Message +"Use Numbers Only");
            Console.ReadLine();

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("The program has emerged from a try/cacth block");
            Console.WriteLine("This will allow the program to contiue");
            Console.WriteLine(ex.Message + "Use a Non-Zero Number");
            Console.ReadLine();

        }

    }
    }

