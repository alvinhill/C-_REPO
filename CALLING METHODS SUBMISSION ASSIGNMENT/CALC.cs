using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS_SUBMISSION_ASSIGNMENT
{
    
    class CALC
    {   
        // STEP 275
        
        // ACCESS PROPERTY
         public int numU;
      
    

        public int num1 { get; set; }
       // public int numSC { get; set; }
        // ADDITION SECTION
        public int Addnum(int numU)
        {
            return numU + 100;
        }

        // SUBTRACTION SECTION
        public int Subnum(int numU)
        {
            return numU - 10;
        }

        // MULTIPLICATION SECTION
        public int Multnum( int numU)
        {
            return numU * 10;
        }

    }
}
