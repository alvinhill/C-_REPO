using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA_SUBMISSION_ASSIGNMENT___338
{
    class Program
    {
        static void Main(string[] args)
        {
            EMPLOYEE worker = new EMPLOYEE();
            
            List<string> people = new List<string>();
            List<string> extra = new List<string>();


            people.Add(worker.Id+ "1" );
            people.Add(worker.FirstName+"Joe");
            people.Add(worker.LastName + "Cocker");

            people.Add(worker.Id + "2");
            people.Add(worker.FirstName + "Sam");
            people.Add(worker.LastName + "Jones");

            people.Add(worker.Id + "3");
            people.Add(worker.FirstName + "Joe");
            people.Add(worker.LastName + "Jones");

            people.Add(worker.Id + "4");
            people.Add(worker.FirstName + "Mike");
            people.Add(worker.LastName + "Town");

            people.Add(worker.Id + "5");
            people.Add(worker.FirstName + "Sally");
            people.Add(worker.LastName + "Mack");

            people.Add(worker.Id + "6");
            people.Add(worker.FirstName + "Wendy");
            people.Add(worker.LastName + "Hover");

            people.Add(worker.Id + "7");
            people.Add(worker.FirstName + "Robin");
            people.Add(worker.LastName + "Hover");

            people.Add(worker.Id + "8");
            people.Add(worker.FirstName + "Kaylee");
            people.Add(worker.LastName + "Smith");

            people.Add(worker.Id + "9");
            people.Add(worker.FirstName + "Staci");
            people.Add(worker.LastName + "Franks");

            people.Add(worker.Id + "10");
            people.Add(worker.FirstName + "Janet");
            people.Add(worker.LastName + "Able");

            // FOREACH LOOP
            //foreach (string LoopData in people )
            //    {
            //     Console.WriteLine(LoopData);
            // if (LoopData.Contains("Joe"))
            //    {
            //    extra.Add(LoopData);
            //    }

            //    }
          
            {//---------------------------------------------------------------
                //FILTER OUT "JOEs"
                // people.ForEach(x =>
                //{
                //    if (x == "Joe")
                //    {
                //        extra.Add(x);
                //        Console.WriteLine(x);
                //    }
                //});
                //############################################
                //TRY TO FIND VALUES OVER "5"
                people.ForEach(x =>
                {
                    if ((Convert.ToInt32(worker.Id) > 5))
                    {
                        extra.Add(worker.FirstName);
                        Console.WriteLine(x);
                    }
                });
                //*******************************************
                // people.ForEach(x =>
                //{
                //    if (x == "5")
                //    {
                //        extra.Add(x);
                //        Console.WriteLine(x);
                //    }
                //});
                //foreach (string LoopData in people)
                               
                //{
                //    Console.WriteLine(LoopData);
                //    //if (LoopData.Contains("Joe"))
                //    if (Convert.ToInt32(worker.Id)>5)
                //    {
                //        extra.Add(LoopData);
                //    }

                //}

                //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX





                Console.ReadLine();







            }
        }
    }
}
