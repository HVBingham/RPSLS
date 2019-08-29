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
        Player PlayerOne;
        Player PlayerTwo;
        bool IsGameOver;

        //constructor(spawner)
        public Game()
        {
            List<string> Actions = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            IsGameOver = false;


        }



        //member method(can do)
        public void DisplayTheRules()
        {
            Console.WriteLine("The rules of the game are: \n\t Rock crushes Scissors, \n\t Scissors cuts Paper, \n\t Paper covers Rock, \n\t Rock crushes Lizard, \n\t Lizard poisons Spock, \n\t Spock smashes Scissors, \n\t Scissors decapitates Lizard, \n\t Lizard eats Paper, \n\t Paper disproves Spock, \n\t and last but not least Spock vaporizes Rock.");

        }     
        
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How Many Players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }
        public void CreatePlayers(int number)
        {
            if(number == 1)
            {
                PlayerOne = new Human();
                PlayerTwo = new Computer();

            }
            else if(number == 2)
            {
                PlayerOne = new Human();
                PlayerTwo = new Human();
            }
        }
        public bool ProveActions(string ChosenActions, List<string> Actions)
        {
            foreach(string action in Actions)
            {
                if(ChosenActions == action)
                {
                    return true;
                }
            }
            return false;
        }
        public string GetPlayersActions(List<string> Actions)
        { 
            Console.WriteLine("Please choose either: 'rock', 'paper', 'scissors', 'lizard', or 'spock'");
           string Action = Console.ReadLine().ToLower();
            if(ProveActions(Action, Actions))
            {
                return Action;
            }
            Console.WriteLine("Stop inputing bananas!");
            return GetPlayersActions(Actions);
        }
        public void CompareActions(string PlayerOneActions, string PlayerTwoActions)
        {
            if (PlayerOneActions == PlayerTwoActions)
            {
                Console.WriteLine("It's A Tie \n\t Rechoose actions.");
            }
            else {
                switch (PlayerOneActions, PlayerTwoActions)
                {
                    case (PlayerOneActions == "rock" && PlayerTwoActions == "scissors"):
                        Console.WriteLine("Player One Wins!");
                        break;
                    case (PlayerOneActions == "scissors" && PlayerTwoActions == "rock"):
                        Console.WriteLine("Player Two Wins!");
                        break;
                    case (PlayerOneActions == "scissors" && PlayerTwoActions == "paper"):
                        Console.WriteLine("Player One Wins!");
                        break;
                    case (PlayerOneActions == "paper" && PlayerTwoActions == "scissors"):
                        Console.WriteLine("Player Two Wins!");
                        break;
                    case (PlayerOneActions == "paper" && PlayerTwoActions == "rock"):
                        Console.WriteLine("Player One Wins!");
                        break;
                    case (PlayerOneActions == "rock" && PlayerTwoActions == "paper"):
                        Console.WriteLine("Player Two Wins!");
                        break;
                    case (PlayerOneActions == "rock" && PlayerTwoActions == "lizard "):
                        Console.WriteLine("Player One Wins!");
                        break;
                    case (PlayerOneActions == "lizard" && PlayerTwoActions == "rock"):
                        Console.WriteLine("Player Two Wins!");
                        break;
                    case (PlayerOneActions == "lizard" && PlayerTwoActions == "spock"):
                        Console.WriteLine("Player One Wins!");
                        break;
                    case (PlayerOneActions == "spock" && PlayerTwoActions == "lizard"):
                        Console.WriteLine("Player Two Wins!");
                        break;
                    case (PlayerOneActions == "spock" && PlayerTwoActions == "scissors"):
                        Console.WriteLine("Player One Wins!");
                        break;
                    case (PlayerOneActions == "scissors" && PlayerTwoActions == "spock"):
                        Console.WriteLine("Player Two Wins!");
                        break;
                    case (PlayerOneActions == "scissors" && PlayerTwoActions == "lizard"):
                        Console.WriteLine("Player One Wins!");
                        break;
                    case (PlayerOneActions == "lizard" && PlayerTwoActions == "scissors"):
                        Console.WriteLine("Player Two Wins!");
                        break;
                    case (PlayerOneActions == "lizard" && PlayerTwoActions == "paper"):
                        Console.WriteLine("Player One Wins!");
                        break;
                    case (PlayerOneActions == "paper" && PlayerTwoActions == "lizard"):
                        Console.WriteLine("Player Two Wins!");
                        break;
                    case (PlayerOneActions == "paper" && PlayerTwoActions == "rock"):
                        Console.WriteLine("Player One Wins!");
                        break;
                    case (PlayerOneActions == "rock" && PlayerTwoActions == "paper"):
                        Console.WriteLine("Player Two Wins!");
                        break;
                }
            }
        }
        public void PlayGame()
        {
            DisplayTheRules();
            int numberofPlayers = GetNumberOfPlayers();
            CreatePlayers(numberofPlayers);
 
        }
    }
}
