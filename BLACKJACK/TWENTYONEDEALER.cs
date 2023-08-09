using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
   public class TWENTYONEDEALER:DEALER
    {
 
        public List<CARD> HAND { get; set; }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }

    }


}

