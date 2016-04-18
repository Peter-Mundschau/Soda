using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class Menu
    {


        public void MakeSelection()
        {
            Console.WriteLine("========================");
            Console.WriteLine("|                      |");
            Console.WriteLine("| G - Grape Soda       |");
            Console.WriteLine("| M - Meat  Soda       |");
            Console.WriteLine("| O - Orange Soda      |");
            Console.WriteLine("|                      |");
            Console.WriteLine("========================");
            Console.WriteLine();
            Console.WriteLine("Please Choose: ");
            BeverageSelection(Convert.ToChar(Console.ReadLine().ToUpper()));

        }

        private void BeverageSelection(char choice)
        {
            bool choiceMade = false;
            while (!choiceMade)
            {
                switch (choice)
                {
                    case 'G':
                        Console.WriteLine("Selection was Grape");
                        choiceMade = true;
                        break;

                    case 'M':
                        Console.WriteLine("Selection was Meat");
                        choiceMade = true;
                        break;

                    case 'O':
                        Console.WriteLine("Selection was Grape");
                        choiceMade = true;
                        break;

                    default:
                        Console.WriteLine("-Not a valid Choice. Please Choose again:");
                        choice = Convert.ToChar(Console.ReadLine().ToUpper());
                        choiceMade = false;
                        break;
                }
            }
        }

        //public void DepositCoin(coin)
        //{
        //    switch (coin)
        //    {
        //        case (1):
        //            CoinTotal+= 1
        //                break;
        //        case
        //        default:
        //            break;
        //    }

        //}

    }
}
