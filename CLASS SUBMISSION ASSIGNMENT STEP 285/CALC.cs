using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT_STEP_285
{
    class CALC
    {
        // METHOD WITH OUT
        public void DoWork(int numOne, out int answer)
        {
            answer = numOne / 2;

        }
        // METHOD WITH TWO OUTS
        public void Data(int a, int b, out int x, out int y)
        {
            x = a + b;
            y = a * b;
        }

        // OVERLOAD METHOD WITH OUTS
        public void Data(int c, int d, int e, out int z)
        {
            z = c + d + e;

        }







    }
}
