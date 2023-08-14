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

            RIDE car1 = new RIDE("Corvette ", 93500);
            RIDE car2 = new RIDE("Chevy ", 1500);

            Console.WriteLine("The car is a " + car1.car +"at "+speed);
            Console.Read();
        }
    }

    public class RIDE
    {
        public string car;
        public int cost;

        public RIDE(string car, int cost)
        {
            this.car = car;
            this.cost = cost;
        }



    }


    //CARLOT data = new CARLOT("Toyota");

    //Console.WriteLine("TYPE IN A CAR MODEL");

    //data.car =Console.ReadLine();

    //Console.WriteLine(data.Merch +" "+ data.price+" "+speed);
    //Console.ReadLine();








}
