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
        public List<string> Actions; 


        //constructor(spawner)
        public Game()
        {
            Actions = new List<string>();
            Actions.Add("rock");
            Actions.Add("paper");
            Actions.Add("scissors");
            Actions.Add("lizard");
            Actions.Add("spock");
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
        public void CompareActions(string Player1Actions, string Player2Actions, List<string>Actions)
        {
            Player1Actions = GetPlayersActions(Actions);
            Player2Actions = GetPlayersActions(Actions);

            if (Player1Actions == Player2Actions)
            {
                Console.WriteLine("It's A Tie \n\t Rechoose actions.");
                GetPlayersActions(Actions);
            }
            else {
                switch (Player1Actions + Player2Actions)
                {
                    case ("rock" + "scissors"):
                        Console.WriteLine("Player 1 Wins");
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("scissors" + "rock"):
                        Console.WriteLine("Player 2 Wins");
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("scissors" + "paper"):
                        Console.WriteLine("Player 1 Wins");
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("paper" + "scissors"):
                        Console.WriteLine("Player 2 wins");
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("paper" + "rock"):
                        Console.WriteLine("player 1 wins");
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("rock" + "paper"):
                        Console.WriteLine("player 2 wins");
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("rock" + "lizard"):
                        Console.WriteLine("player 1 wins");
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("lizard" + "rock"):
                        Console.WriteLine("player 2 wins");
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("lizard" + "spock"):
                        Console.WriteLine("Player 1 Wins");
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("spock" + "lizard"):
                        Console.WriteLine("Player 2 Wins");
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("spock" + "scissors"):
                        Console.WriteLine("Player 1 Wins");
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("scissors" + "spock"):
                        Console.WriteLine("Player 2 wins");
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("scissors" + "lizard"):
                        Console.WriteLine("player 1 wins");
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("lizard" + "scissors"):
                        Console.WriteLine("player 2 wins");
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("lizard" + "paper"):
                        Console.WriteLine("player 1 wins");
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("paper" + "lizard"):
                        Console.WriteLine("player 2 wins");
                         PlayerTwo.AddToPlayerScore();
                        break;
                    case ("paper" + "spock"):
                        Console.WriteLine("player 1 wins");
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("spock" + "paper"):
                        Console.WriteLine("player 2 wins");
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("spock" + "rock"):
                        Console.WriteLine("player 1 wins");
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("rock" + "spock"):
                        Console.WriteLine("player 2 wins");
                        PlayerTwo.AddToPlayerScore();
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
