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

            Person guy = new Person();

            guy.Fname = "henry";
            guy.Lname = "France";

            Console.WriteLine(guy.Fname);
            Console.WriteLine(guy.Lname);
            Console.ReadLine();

        }

        public class Person
        {
            public string Fname;
            public string Lname;

            //public Person()
            //{
            //}


            public Person(string Fname) : this(Fname, "Fred")
            {

            }
            public Person(string Fname, string Lname)
            {
                this.Fname = Fname;
                this.Lname = Lname;

            }

        }


    }


}
