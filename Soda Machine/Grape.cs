using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class Grape : Soda
    {
        private decimal costOfSoda;
        private string kindOfSoda;
        public decimal CostOfSoda { get { return costOfSoda; } set { costOfSoda = .60M; } }
        public string KindOfSoda { get { return kindOfSoda; } set { kindOfSoda = "Grape Soda"; } }

        public void GrapeSoda()
        {
            

        }
    }
}
