using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class Meat : Soda
    {
        private decimal costOfSoda;
        private string kindOfSoda;
        public decimal CostOfSoda { get { return costOfSoda; } set { costOfSoda = .06M; } }
        public string KindOfSoda { get { return kindOfSoda; } set { kindOfSoda = "Meat Soda"; } }

    }
}
