using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS_SUBMISSION_ASSIGNMENT
{
    class CALC
    {
        // ASSIGN CLASS VARIABLES
        public int numU;
        public int numSC;
        public int numMC;
    
        // ADDITION SECTION
        public int Addnum(int numU)
        {
            return numU + 100;
        }

        // SUBTRACTION SECTION
        public int Subnum(int numSC)
        {
            return numSC - 10;
        }

        // MULTIPLICATION SECTION
        public int Multnum( int numMC)
        {
            return numMC * 10;
        }

    }
}
