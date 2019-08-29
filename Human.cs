using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //member varialble (has a)
       public string Name;


        //constructor (spawner)
        public Human(string name)
        {
            this.Name = name;
        }


        //member method(can do)
        public string GetPlayersName()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            return Name;
        }
        public void WelcomeThePlayer()
        {
            Console.WriteLine("Welcome to the game " +Name);
        }
        
          

     
    }
}
