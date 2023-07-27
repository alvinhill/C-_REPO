using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_SUBMISSION_ASSIGNMENT_SREP_279
{
    class CALC
    {

        // DECLARE VARIABLES
        public int numOne;
        public decimal numTwo;
        public string numThree;


        // CREATE INT CLASS
        public int DoMath(int numOne)
        {
            int result = numOne * 5;
            return result;
        }

        // CREATE DECIMAL CLASS OVERLOAD
        public decimal DoMath(decimal numTwo)
        {
            decimal result = numTwo - 15.27m;
            return result;
        }


        // CREATE STRING CLASS OVERLOAD
        public string DoMath(string numThree)
        {
            int result = Convert.ToInt32(numThree) + 10;
            return Convert.ToString(result);
        }


    }
}
