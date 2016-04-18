using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class Penny : Coin
    {
        public decimal penny { get; set; }

        public Penny()
        {
            penny = .01M;
        }
    }
}
