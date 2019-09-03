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
        int NumberOfPlayers;


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
            if (ProveActions(Action, Actions))
            {
                return Action;
            }
                Console.WriteLine("Stop inputing bananas!.................................... Stop it.");
                return GetPlayersActions(Actions);
            
        }
        public string ChooseAction(List<string> Actions)
        {
            Random RandomAction = new Random();
            int i = RandomAction.Next(Actions.Count);
            string Action = Actions[i];
            return Action;


        }
        public string GetHumanPlayerTwoActions(List<string> Actions)
        {
            Console.WriteLine("Player Two: Please choose either: 'rock', 'paper', 'scissors', 'lizard', or 'spock'");
            string Action = Console.ReadLine().ToLower();
            if (ProveActions(Action, Actions))
            {
                return Action;
            }
            Console.WriteLine("Stop inputing bananas!.................................... Stop it.");
            return GetHumanPlayerTwoActions(Actions);
        }
        public string GetPlayerTwoActions(List<string> Actions)
        {
            string PlayerTwoActions;
            if (NumberOfPlayers == 1)
            {
                PlayerTwoActions = ChooseAction(Actions);

            }
            else
            {
                PlayerTwoActions = GetHumanPlayerTwoActions(Actions);

            }
            return PlayerTwoActions;
        }
     
        public string CompareActions(List<string>Actions)
        {
            string FinalActions = "";
            string Player1Actions = GetPlayersActions(Actions);
            string Player2Actions = GetPlayerTwoActions(Actions);
            if (Player1Actions == Player2Actions)
            {
                FinalActions= "Tie";
            }
            else {
                switch (Player1Actions + Player2Actions)
                {
                    case ("rock" + "scissors"):
                        FinalActions = "Player 1 Wins";
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("scissors" + "rock"):
                        FinalActions = "Player 2 Wins";
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("scissors" + "paper"):
                        FinalActions = "Player 1 Wins";
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("paper" + "scissors"):
                        FinalActions = "Player 2 Wins";
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("paper" + "rock"):
                        FinalActions = "Player 1 Wins";
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("rock" + "paper"):
                        FinalActions = "Player 2 Wins";
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("rock" + "lizard"):
                        FinalActions = "Player 1 Wins";
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("lizard" + "rock"):
                        FinalActions = "Player 2 Wins";
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("lizard" + "spock"):
                        FinalActions = "Player 1 Wins";
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("spock" + "lizard"):
                        FinalActions = "Player 2 Wins";
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("spock" + "scissors"):
                        FinalActions = "Player 1 Wins";
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("scissors" + "spock"):
                        FinalActions = "Player 2 Wins";
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("scissors" + "lizard"):
                        FinalActions = "Player 1 Wins";
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("lizard" + "scissors"):
                        FinalActions = "Player 2 Wins";
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("lizard" + "paper"):
                        FinalActions = "Player 1 Wins";
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("paper" + "lizard"):
                        FinalActions = "Player 2 Wins";
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("paper" + "spock"):
                        FinalActions = "Player 1 Wins";
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("spock" + "paper"):
                        FinalActions = "Player 2 Wins";
                        PlayerTwo.AddToPlayerScore();
                        break;
                    case ("spock" + "rock"):
                        FinalActions = "Player 1 Wins";
                        PlayerOne.AddToPlayerScore();
                        break;
                    case ("rock" + "spock"):
                        FinalActions = "Player 2 Wins";
                        PlayerTwo.AddToPlayerScore();
                        break;

           
                }


            }
            return FinalActions;
        }
      

        public void CongratsWinner(List<string> Actions)
        {
            string Winner;
            Winner = CompareActions(Actions);
            if (NumberOfPlayers == 2)
            {
                switch (Winner)
                {
                    case "Player 1  Wins":
                        Console.WriteLine("congrats Player One you Win with a score of " + PlayerOne.Score + "Please press enter.");
                        break;
                    case "Player 2 Wins":
                        Console.WriteLine("congrats Player Two you Win with a score of " + PlayerTwo.Score + "Please press enter.");
                        break;
                    case "Tie":
                        Console.WriteLine("Dang you both are good. Its a Tie. Please press enter.");
                        break;
                }
            }
            else if (NumberOfPlayers == 1){
                switch (Winner)
                {
                    case "Player 1  Wins":
                        Console.WriteLine("congrats Player One you Win with a score of  " + PlayerOne.Score + " Please press enter.");
                        break;
                    case "Player 2 Wins":
                        Console.WriteLine("Dude the computer beat you. It wins with a score of  " +PlayerTwo.Score + " Please press enter.");
                        break;
                    case "Tie":
                        Console.WriteLine("Dang you both are good. Its a Tie. Please press enter.");
                        break;
                }
            }
        }
      
      public bool PlayGameAgain()
        {
           
            if (PlayerOne.Score <= 3 || PlayerTwo.Score <= 3)
            {
                
                CongratsWinner(Actions);
                Console.ReadLine();
            }
            else if (PlayerOne.Score == 3 || PlayerTwo.Score == 3)
            {
                return IsGameOver = true;
            }
 
            return PlayGameAgain();
        }
       
      
        public void PlayGame()
        {
            DisplayTheRules();
            NumberOfPlayers = GetNumberOfPlayers();
            CreatePlayers(NumberOfPlayers);
            CongratsWinner(Actions);
            Console.ReadLine();

        }
    }
}
