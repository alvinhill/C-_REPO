using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_SUBMISSION_ASSIGNMENT__385
{
    class Program
    {
       public static void Main(string[] args)
        {
            const int speed = 65;


            CARLOT data = new CARLOT("Toyota");
       

            Console.WriteLine("TYPE IN A CAR MODEL");
            
            data.car =Console.ReadLine();


            
            Console.WriteLine(data.Merch +" "+ data.price+" "+speed);
            Console.ReadLine();



        }
    }
}
