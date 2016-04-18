using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class Quarter : Coin
    {
        public decimal quarter { get; set; }
        public Quarter()
        {
            quarter = .25M;
        }
    }
}
