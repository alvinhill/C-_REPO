using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
   public class TWENTYONEDEALER:DEALER
    {
        private List<CARD> _hand = new List<CARD>();
        public List<CARD> HAND { get { return _hand; } set { _hand = value; } }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }

    }


}

