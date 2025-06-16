using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    internal class CommandSet
    {
        ICommand[] commands = new ICommand[4];
        public CommandSet()
        {
            commands[0] = new C_Space();
            commands[1] = new C_K();
            commands[2] = new C_S();
            commands[3] = new C_X();
        }

        public void RunCommand(char a, ClickerGame clickerGame)
        {
            
            if (a == 'x'){commands[3].Run(clickerGame);}

            else if (a == ' ') {commands[0].Run(clickerGame);}

            else if (a == 'k' && clickerGame.points >= 10)
            {
                commands[1].Run(clickerGame);
            }
            else if(a == 's' && clickerGame.points >= 100)
            {
                commands[2].Run(clickerGame);
            }

        }
    }
}
