using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    class Wallet

    { // member variables (HAS A)
        List<Coin> MyChange;

        //constructor
        public Wallet()
        {

         MyChange = new List<Coin>();
         MixChange();

        }

        public void MixChange()
        {
            for (int i = 0; i < 8; i++)
            {
                Coin quarter = new Quarter();
                MyChange.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                Coin dime = new Dime();
                MyChange.Add(dime);
            }

            for (int i = 0; i < 20; i++)
            {
                Coin nickel = new Nickel();
                MyChange.Add(nickel);
            }

            for (int i = 0; i < 100; i++)
            {
                Coin penny = new Penny();
                MyChange.Add(penny);
            }




        }        }   
}    






