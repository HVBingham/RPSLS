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
        public string ChooseAction(List<string>Actions)
        {
            Random RandomAction = new Random();
            int i = RandomAction.Next(Actions.Count);
            string Action = Actions[i];
            return Action;
            

        }

        public override string GetPlayersName()
        {
          return Name = "";
        }

    }
}
