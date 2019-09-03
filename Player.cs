using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
   public abstract class Player
    {
        //member variables (has a)
       public int Score;
       public string Action;
       public string Name;

        // constructor(spawner)
        public Player()
        {
           Score = 0;


        }




        //member methods (cad do)
        public abstract string GetPlayersName();
        public abstract void WelcomePlayer();
        public int AddToPlayerScore()
        {
           return Score++ ;
        }
        public void DisplayPlayerScore()
        {
            Console.WriteLine(Score);
        }
       
      

    }
}
