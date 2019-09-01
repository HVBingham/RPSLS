using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
   public class Computer:Player
    {
        //member variable(has a)


        //constructor(spawner)
        public Computer()
        {



        }


        //member method(can do)
     
        public override string GetPlayersName()
        {
            Name = "darkside Player";
            return Name;
        }
        
            
         public override void WelcomePlayer()
        {
            Console.WriteLine("Welcome Dark Side Player");
        }

    }
}
