using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RPS2
{
   

    class Game
    {
        // member variables (HAS A)
        public Player player1;
        public Player player2;

        // constructor
        public Game()
        {
            player1 = new Human();
        }

        // member methods (CAN DO)
        public void RunGame()   // master method
        {
            DisplayRules();
            ChooseGameMode();


            // 1) Display the rules (GAME)
         

            Console.WriteLine("DisplayRules");
            Console.WriteLine("ChooseGameMode");
            List gesturelist;

            while (true)
                class gesturelist(List)
            {
                Add.Playergesturelist("1player");
                Add.Playergesturelist("2PLAYER");
                Add.Gameguestrelist =("Game");
            }
          

        public void DisplayRules()
        {
            Console.WriteLine("These are the rules!");
            Console.WriteLine("You have 3 rounds and the winner takes all");
            Console.WriteLine("One at at time, get up to 3 rounds and have fun ");
        }

        public void ChooseGameMode()
        {
            // a. Ask for which game mode
            Console.WriteLine("Please choose a game mode:");
            Console.WriteLine("Press 1 for Human Vs AI.");
            Console.WriteLine("Or press 2 for Human Vs Human.");

            // b. Capture answer from user
            string userInput = Console.ReadLine();

            // c. Make our player objects
            if (userInput == "1")
            {
                player1 = new AI();
            }
            else if (userInput == "2")
            {
                player2 = new Human();
            }
            else
            {
               // pla // what if they don't type "1" or "2" ?
            }

        }


    }
}
