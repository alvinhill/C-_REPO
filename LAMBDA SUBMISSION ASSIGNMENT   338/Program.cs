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
          
            List<EMPLOYEE> employees = new List<EMPLOYEE>
            {
                // CREATE OBJECTS FOR employees
                new EMPLOYEE{FirstName="Joe",LastName="Jones",Id=1},
                new EMPLOYEE{FirstName="Frank",LastName="Jones",Id=2},
                new EMPLOYEE{FirstName="Joe",LastName="Miller",Id=3},
                new EMPLOYEE{FirstName="MIke",LastName="Jones",Id=4},
                new EMPLOYEE{FirstName="Billy",LastName="Smith",Id=5},
                new EMPLOYEE{FirstName="Jerry",LastName="Miller",Id=6},
                new EMPLOYEE{FirstName="Kaylee",LastName="Jones",Id=7},
                new EMPLOYEE{FirstName="Staci",LastName="Franks",Id=8},
                new EMPLOYEE{FirstName="Linda",LastName="Mays",Id=9},
                new EMPLOYEE{FirstName="Mary",LastName="Newton",Id=10}
                
            };
            //CREATE LIST FOR DUPLICATE "JOEs"
            List<string> extra = new List<string>();
            //CREATE LIST FOR Ids OVER 5
            List<string> extra5 = new List<string>();
            //############################################
            Console.WriteLine("PRINT FULL LIST");
            //FOREACH LOOP TO PLACE THE joes IN A LIST   
            foreach (EMPLOYEE LoopData in employees)
            {
                Console.WriteLine(LoopData.Id+" "+LoopData.FirstName+" "+LoopData.LastName);
                if ((LoopData.FirstName).Contains("Joe"))
                {
                    extra.Add(LoopData.FirstName);
                }
            }
            Console.WriteLine("");
            {//---------------------------------------------------------------
             //############################################
             // POINT OUT "JOEs" WITH LAMBDA AND SEND THEM TO THE extra LIST
                Console.WriteLine("PRINT DUPLICATE JOEs AND ADD THEM TO THE extra LIST");

                employees.ForEach(x =>
                {
                    if(x.FirstName=="Joe")
                    {
                        // SEND THEM TO THE extra LIST
                        extra.Add(x.FirstName);
                            Console.WriteLine("DUPLICATES= "+x.Id+" "+x.FirstName+" "+x.LastName);
                    }
                  });
                //############################################
                //FIND VALUES OVER "5" AND SEND THEM TO THE extra5 LIST USING LAMBDA
                Console.WriteLine("");
                Console.WriteLine("PRINT EMPLOYEE ID OVER 5   ");
                employees.ForEach(x =>
                {
                    if (x.Id>5)
                    {
                        extra5.Add(x.FirstName);
                        Console.WriteLine(x.Id +" "+ x.FirstName+" "+x.LastName);
                    }
                });
                //############################################
                Console.ReadLine();
            }
        }
    }
}
