using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    class SodaMachine
    {
        //member variables
        List<Coin> register;
        List<Can> inventory;


        //constructor (Spawner)
        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();
            FillRegister();
        }



        //member methods
        public void FillRegister()
        {
            for (int i = 0; i < 50; i++)
            {
                Coin penny = new Penny();
                register.Add(penny);
            }

            for (int i = 0; i < 20; i++)
            {
                Coin nickel = new Nickel();
                register.Add(nickel);
            }
            for (int i = 0; i < 10; i++)
            {
                Coin dime = new Dime();
                register.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Coin quarter = new Quarter();
                register.Add(quarter);
            }
        }
        public void FillInventory()
        {

            for (int i = 0; i < 15; i++)
            {
                Can cola = new Cola();
                inventory.Add(cola);
            }
            for (int i = 0; i < 30; i++)
            {
                Can rootbeer = new Rootbeer();
                inventory.Add(rootbeer);
            }

            for (int i = 0; i < 10; i++)
            {
                Can orange = new OrangeSoda();
                inventory.Add(orange);
            }
        }


    }
}