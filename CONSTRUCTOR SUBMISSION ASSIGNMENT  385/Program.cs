using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_SUBMISSION_ASSIGNMENT__385
{
    class Program
    {
        static void Main(string[] args)
        {


            // CREATE OBJECTS
            Person guy = new Person();
            Person guy1 = new Person("Sam");
            Person guy2 = new Person("Henry", "France");

            // DISPLAY OBJECTS WITH DIFFERENT PARAMETERS
            Console.WriteLine("NO PARAMENTERS "+guy.Fname+" "+ guy.Lname);
            Console.WriteLine();
            Console.WriteLine("ONE PARAMENTER " + guy1.Fname + " " + guy1.Lname);
            Console.WriteLine();
            Console.WriteLine("TWO PARAMENTERS " + guy2.Fname+" "+ guy2.Lname);
            Console.ReadLine();

        }

        public class Person
        {
            // CREATE GLOBAL VARIBLES
            public string Fname;
            public string Lname;

            // CONSTRUCTOR WITH ZERO PARAMENTERS
            public Person() : this("John", "Smith")
            {
            }

            // CONSTRUCTOR WITH ONE PARAMENTER
            public Person(string Fname) : this(Fname, "Fred")
            {
            }
            
            // CONSTRUCTOR WITH TWO PARAMENTERS
            public Person(string Fname, string Lname)
            {
                this.Fname = Fname;
                this.Lname = Lname;
            }
        }

    }


}
