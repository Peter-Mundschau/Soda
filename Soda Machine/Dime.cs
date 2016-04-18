using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class Dime : Coin
    {
        public decimal dime { get; set; }

        public Dime()
        {
             dime = .10M;
            


        }

        
    }
}
