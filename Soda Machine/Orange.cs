using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
   public class Orange : Soda 
    {
        private decimal costOfSoda;
        private string kindOfSoda;

        public decimal CostOfSoda { get { return costOfSoda; } set { costOfSoda = .35M; } }
        public string KindOfSoda { get { return kindOfSoda; } set { kindOfSoda = "Orange Soda"; } }
    }
}
