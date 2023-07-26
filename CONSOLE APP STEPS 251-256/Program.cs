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
                
                    cars[i] = cars[i] + " " + addOn;
                }

                // OUTPUT LOOP FOR THE NEW STRING
                for (int J = 0; J < cars.Length; J++)

                {
                    Console.WriteLine("car and paint");
                    Console.WriteLine(cars[J]);
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
                        break;
                    }


                }

                // CONSOLE APP PART FIVE       ************************

                List<string> pets = new List<string>();

                // POPULATE THE LIST
                pets.Add("dog");
                pets.Add("cat");
                pets.Add("fish");
                pets.Add("bird");
                pets.Add("fish");
                                             

                string choiceX;

                // DISPLAY CHOICES
                Console.WriteLine("*** PART FIVE ***");
                Console.WriteLine("");// ADD SPACE
                Console.WriteLine("Enter The Name of the Pet To Find ");
                Console.WriteLine("dog, cat, fish or bird ");

                // INPUT NUMBER CHOICE
                choiceX = Console.ReadLine();
                Console.WriteLine("");// ADD SPACE

                // SET UP FOR LOOP
                for (int i = 0; i < pets.Count; i++)
                {
                    // CHECK FOR NON MATCHING INPUT
                    if (pets.IndexOf(choiceX) == -1)
                    {
                        // PRINT NOT FOUND MESSAGE
                        Console.WriteLine("NOT IN THE LIST");
                        Console.ReadLine();
                    }

                    // SELECT MATCHING STRING
                    if (pets[i].Contains(choiceX))
                    {
                        // FORMAT SCREEN
                        Console.WriteLine("________");
                        Console.WriteLine("RESULT: ");

                        // PRINT MATCH AND INDEX
                        Console.WriteLine(pets[i] + " Found At Index: " + i);
                        Console.ReadLine();


                    }


                }




                    // ##########################################


                    Console.WriteLine(" ***   PART SIX   ***");

                // CONSOLE APP PART 6   
                // SHOW UNIQUE AND DUPLICATE ITEMS IN A LIST PROGRAM

                // CREATE LIST WITH DUPLICATES

                List<string> carz = new List<string>();
                carz.Add("ford");
                carz.Add("chevy");
                carz.Add("mercury");
                carz.Add("dodge");
                carz.Add("ford"); // duplicate
                carz.Add("dodge"); // duplicate
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