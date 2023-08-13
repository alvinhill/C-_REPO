using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_SUBMISSION_ASSIGNMENT__385
{
    public class CARLOT
    {
        public string car;
        public int cost;
        
        public CARLOT(string car):this(car,425)
        {

        }

        // FIRST CONSTRUCTOR GIVING DEFAULT VALUES TO CAR AND COST
        //public CARLOT(string car,int price)
        //{
        //    Merch = car;
        //    price =cost ;

        //}

       public string Merch { get; set; }
        public int price { get; set; }

    }
}
