﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class Nickel : Coin
    {
        public decimal nickel { get; set; }
        public Nickel()
        {
            nickel = .05M;
        }

    }
}
