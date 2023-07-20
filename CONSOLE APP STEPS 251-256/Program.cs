using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP_STEPS_251_256
{
    class Program
    {
        static void Main()

        {

            // CONSOLE APP PART ONE  **************************
           
            {

                string newSting;

                // SETUP AND POPULATE CAR ARRAY
                string[] cars = new string[5];
                // SETUP PAINT ARRAY
                string[] paint = new string[5];

                // POPULATE THE CAR LIST
                cars[0] = "Ford";
                cars[1] = "Olds";
                cars[2] = "Mercury";
                cars[3] = "Cadilac";
                cars[4] = "Dodge";

                for (int i = 0; i < cars.Length; i++)
                {
                    // GET USER INPUT
                    string addOn;
                    Console.Write("Enter Paint Color For the Car: ");
                    addOn = Console.ReadLine();

                    // COMBINE THE STRINGS
                    newSting = cars[i] + " " + addOn;
                    paint[i] = newSting;

                }

                // OUTPUT LOOP FOR THE NEW STRING
                for (int J = 0; J < paint.Length; J++)

                {
                    Console.WriteLine("car and paint");
                    Console.WriteLine(paint[J]);

                }
                Console.WriteLine("");  // MAKE SPACE

                // CONSOLE APP PART TWO INFITE LOOP   **************************
                int Z = 1;
                while (Z != 5)
                {
                    Console.WriteLine("Stop Infinite Loop step 252");
                    Z++;
                }
                // FIXED INFINITE LOOP BY ADDING 1 TO "Z" DURING THE LOOP

                // CONSOLE APP PART THREE     *********************************
                // ************   PART A    ****************
                // OUTPUT ITEMS THAT ARE LESS THAN FIVE
                for (int W = 0; W < 5; W++)

                {
                    Console.WriteLine("step 253 < " + W);
                }
                // ************   PART B    ****************

                // OUTPUT ITEMS THAT ARE LESS THAN OR EQUAL TO FIVE
                for (int Y = 0; Y <= 5; Y++)

                {
                    Console.WriteLine("step 253 PART 2 <= " + Y);
                }
                // CONSOLE APP PART FOUR      ************************


                // CREATE LIST
                List<string> plane = new List<string>();

                // POPULATE THE LIST
                plane.Add("b17");
                plane.Add("f22");
                plane.Add("b52");

                // CREATE DO LOOP
                string choice;
                do
                {
                    // DISPLAY CHOICES
                    Console.WriteLine("Enter The Name of the Plane To Find it's Hangar");
                    Console.WriteLine("Enter a choice: b17 - f22 or b52 ");

                    // INPUT NUMBER CHOICE
                    choice = Console.ReadLine();

                    // MAKE FOR LOOP FOR LIST
                    for (int i = 0; i < plane.Count; i++)

                    {
                        // COMPARE INPUT TO LIST
                        if (choice == plane[i])
                        {

                            Console.WriteLine("");  // MAKE SPACE

                            // OUTPUT CORRECT CHOICE
                            Console.WriteLine("The plane is in hangar # " + i);

                            // END PROGRAM SECTION
                            Console.WriteLine("END PROGRAM ");
                            Console.ReadLine();
                           // Environment.Exit(0);

                        }


                        // IF SELECTION IS NOT FOUND PRINT MESSAGE TO SCREEN AND CONTINUE LOOP
                        if (choice != plane[i])
                        {
                            Console.WriteLine("hangar not found for: " + plane[i]);
                        }

                        Console.WriteLine(""); // MAKE SPACE

                    }
                }
                while (choice != "end");

                //**********************************************************

                // CONSOLE APP PART FOUR      ************************


                // CREATE LIST
                List<string> plane1 = new List<string>();

                // POPULATE THE LIST
                plane1.Add("b17");
                plane1.Add("f22");
                plane1.Add("b52");
                plane1.Add("b17");


                // CREATE DO LOOP
                string choice1;
                do
                {
                    // DISPLAY CHOICES
                    Console.WriteLine("Enter The Name of the Plane To Find it's Hangar");
                    Console.WriteLine("Enter a choice: b17 - f22 or b52 ");

                    // INPUT NUMBER CHOICE
                    choice1 = Console.ReadLine();

                    // MAKE FOR LOOP FOR LIST
                    for (int i = 0; i < plane1.Count; i++)

                    {
                        // COMPARE INPUT TO LIST
                        if (choice1 == plane1[i])
                        {

                            Console.WriteLine("");  // MAKE SPACE

                            // OUTPUT CORRECT CHOICE
                            Console.WriteLine("The plane is in hangar # " + i);

                            // END PROGRAM SECTION
                            Console.WriteLine("END PROGRAM ");
                            Console.ReadLine();
                           

                        }


                        // IF SELECTION IS NOT FOUND PRINT MESSAGE TO SCREEN AND CONTINUE LOOP
                        if (choice != plane1[i])
                        {
                            Console.WriteLine("hangar not found for: " + plane1[i]);
                        }

                        Console.WriteLine(""); // MAKE SPACE

                    }
                }
                while (choice != "end");

                //************************************************************
                // CONSOLE APP PART FIVE      ************************

                // CREATE LIST
                List<string> pets = new List<string>();

                // ADD ITEMS TO LIST ALONG WITH DUPLICATE ITEM
                pets.Add("dog");
                pets.Add("fish");
                pets.Add("cat");
                pets.Add("fish");// DUPLICATE
                pets.Add("frog");

                // SELECT ITEM FROM LIST WITH DO LOOP
                                string choice2;
                do
                {
                    Console.WriteLine("Enter a choice of pets: ");
                    Console.WriteLine("");// ADD SPACE

                    choice2 = Console.ReadLine();


                    // USE FOR LOOP TO GET STRING ITEM FROM LIST
                    for (int i = 0; i < pets.Count; i++)

                    {
                        if (choice2 == pets[i])
                        {
                             Console.WriteLine("Selection is at index: " + i);
                            // end program here
                        }
                    }
                }
                while (choice2 != "end");

                //  ******************* PART 6 ****************************

                // CONSOLE APP PART 6   
                // SHOW UNIQUE AND DUPLICATE ITEMS IN A LIST PROGRAM

                // CREATE LIST WITH DUPLICATES
                string[] carZ = { "ford", "Chevy", "dodge", "dodge", "buick", "dodge", "ford" };

                // CREATE MAIN LIST AS A VARIABLE
                var mainList = new List<string>();

                // CREATE DUPLICATES LIST AS A VARIBLE
                var dupeList = new List<string>();

                // FOREACH LOOP
                foreach (var loopData in carZ)
                {
                    // IF mainList DOES NOT CONTAIN loopData, ADD TO mainList
                    if (!mainList.Contains(loopData))
                        mainList.Add(loopData);

                    // IF mainList DOES ALREADY CONTAIN NEXT STRING, PUT IT IN dupeList
                    else dupeList.Add(loopData);
                }
                // SHOW WITHOUT DUPES
                foreach (var loopData in mainList)
                    Console.WriteLine(loopData + " Unique");

                //SHOW DUPLICATES
                Console.WriteLine("");
                foreach (var loopData in dupeList)
                    Console.WriteLine(loopData + " Duplicate");

                Console.ReadLine();

            }
        }
    }
}