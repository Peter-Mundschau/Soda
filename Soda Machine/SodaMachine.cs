using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class SodaMachine
    {
        private decimal costOfSoda;
        private string kindOfSoda;

        List<Quarter> quarters;
         List<Dime> dimes; 
        List<Nickel> nickels; 
         List<Penny> pennies;
       List<Orange> oranges; 
        List<Grape> grapes;
        List<Meat> meats;

        public decimal CostOfSoda { get { return costOfSoda; } set { costOfSoda = value; } }
        public string KindOfSoda { get { return kindOfSoda; } set { kindOfSoda = value; } }

        public SodaMachine()
        {
            quarters = new List<Quarter>();
            dimes = new List<Dime>();
            nickels = new List<Nickel>();
            pennies = new List<Penny>();
            oranges = new List<Orange>();
            grapes = new List<Grape>();
            meats = new List<Meat>();
            quarters = stockQuarters();
            dimes = stockDimes();
            nickels = stockNickels();

        }

       
            public List<Quarter> stockQuarters()
        {
            for (int quarterStock = 0; quarterStock < 20; quarterStock++)
            {
                Quarter quarter = new Quarter();
                quarters.Add(quarter);
            }

            return quarters;
        }

        public List<Dime> stockDimes()
        {
            for (int dimeStock = 0; dimeStock < 10; dimeStock++)
            {
                Dime dime = new Dime();
                dimes.Add(dime);

            }
            return dimes;
        }


        public List<Nickel> stockNickels()
        {
            for (int nickelStock = 0; nickelStock < 20; nickelStock++)
            {
                Nickel nickel = new Nickel();
                nickels.Add(nickel);
            }

            return nickels;
        }
        

        
    }
}
