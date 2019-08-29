using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member variable(has a)
        Player playerOne = new Player();
        Player PlayerTwo = new Player();
        bool IsGameOver;

        //constructor(spawner)
        public Game()
        {
            List<string> actions = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            IsGameOver = false;


        }



        //member method(can do)
        public void DisplayTheRules()
        {
            Console.WriteLine("The rules of the game are: \n\t Rock crushes Scissors, \n\t Scissors cuts Paper, \n\t Paper covers Rock, \n\t Rock crushes Lizard, \n\t Lizard poisons Spock, \n\t Spock smashes Scissors, \n\t Scissors decapitates Lizard, \n\t Lizard eats Paper, \n\t Paper disproves Spock, \n\t and last but not least Spock vaporizes Rock.");



        }
        public void ChooseWhoYouArePlaying()
        {

        }
        public void PlayGame()
        {

        }
       public void GetTheWinnersName()
        {

        }


    }
}
