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
                Console.WriteLine(" ***   PART ONE   ***");
                string newString;

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

                // GET USER INPUT
                string addOn;
                Console.Write("Enter Paint Color For the Car: ");
                addOn = Console.ReadLine();

                for (int i = 0; i < cars.Length; i++)
                {

                    // COMBINE THE STRINGS
                    newString = cars[i] + " " + addOn;
                    paint[i] = newString;

                }

                // OUTPUT LOOP FOR THE NEW STRING
                for (int J = 0; J < paint.Length; J++)

                {
                    Console.WriteLine("car and paint");
                    Console.WriteLine(paint[J]);
                    Console.ReadLine();
                }




                Console.WriteLine(" ***   PART TWO   ***");
                Console.WriteLine("");  // MAKE SPACE

                // CONSOLE APP PART TWO INFITE LOOP   **************************
                int Z = 1;
                while (Z != 5)
                {
                    Console.WriteLine("Stop Infinite Loop step 252");
                    Z++;
                }
                // FIXED INFINITE LOOP BY ADDING 1 TO "Z" DURING THE LOOP
                Console.WriteLine(" ***   PART THREE  ***");
                Console.WriteLine("");// ADD SPACE
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
                // ##########################################

                // SET UP LIST
                List<string> plane1 = new List<string>();


                // POPULATE THE LIST
                plane1.Add("b17");
                plane1.Add("f22");
                plane1.Add("b52");
                plane1.Add("DUMMY LOAD");


                // string choice1;
                int index = 0;
                string choice2;

                // DISPLAY CHOICES
                Console.WriteLine("*** PART FOUR ***");
                Console.WriteLine("");// ADD SPACE
                Console.WriteLine("Enter The Name of the Plane To Find it's Hangar");
                Console.WriteLine("Enter a choice: b17 - f22 or b52 ");

                // INPUT NUMBER CHOICE
                choice2 = Console.ReadLine();

                // SET UP FOR LOOP
                for (int i = 0; i < plane1.Count; i++)

                {
                    // CHECK TO SEE IF DATA SEARCH EXCEEDS LIST ITERATIONS
                    if (i == 3)
                    {
                        Console.WriteLine("User Input is Not on The List");
                        Console.ReadLine();
                      

                    }

                    // CHECK FOR MATCH INPUT FROM choice2
                    if (plane1[i].Contains(choice2))
                    {
                        index = i;
                        Console.WriteLine("Index= " + index);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }


                }



                // ##########################################
                //************************************************************
                // CONSOLE APP PART FIVE  
                Console.WriteLine(" *** PART FIVE ***");
                Console.WriteLine("");// ADD SPACE

                // CONSOLE APP PART FIVE  

                // CREATE LIST
                List<string> pets = new List<string>();

                // ADD ITEMS TO LIST ALONG WITH DUPLICATE ITEM
                pets.Add("dog");
                pets.Add("fish");
                pets.Add("frog");
                pets.Add("fish");// DUPLICATE
                pets.Add("cat");
                pets.Add("STOP");

                string choice3;

                // SELECT ITEM FROM LIST WITH DO LOOP

                Console.WriteLine("Enter a choice of pets: ");
                Console.WriteLine("Enter a choice: dog, fish, frog or cat, ");
                Console.WriteLine("");// ADD SPACE
                choice3 = Console.ReadLine();


                // SET UP FOR LOOP
                foreach (string loopData in pets)

                    if (loopData == choice3)
                    {

                        Console.WriteLine(loopData);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }

                Console.ReadLine();

                for (int j = 0; j < pets.Count; j++)
                {

                    if (j == 5)
                    {

                        Console.WriteLine("User Data Not Found");
                        break;
                    }

                }

                Console.WriteLine(" ***   PART SIX   ***");

                // CONSOLE APP PART 6   
                // SHOW UNIQUE AND DUPLICATE ITEMS IN A LIST PROGRAM

                // CREATE LIST WITH DUPLICATES

                List<string> carz = new List<string>();
                carz.Add("ford");
                carz.Add("chevy");
                carz.Add("mercury");
                carz.Add("dodge");
                carz.Add("ford");
                carz.Add("dodge");
                carz.Add("toyota");

                var mainList = new List<string>();

                var dupeList = new List<string>();

                // FOREACH LOOP
                foreach (string loopData in carz)
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



















                //  ******************* PART 6 ****************************





















            } 
        }
    }
}