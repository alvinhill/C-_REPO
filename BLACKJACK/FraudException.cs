﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public class FraudException:Exception
    {
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }





    }
}
