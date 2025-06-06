using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    internal class CommandSet
    {
        object[] commands = new object[4];
        public CommandSet()
        {
            commands[0] = new C_Space();
            commands[1] = new C_K();
            commands[2] = new C_S();
            commands[3] = new C_X();
        }

        public void RunCommand(char a)
        {
            if (a == 'x'){commands[3].Run();}

            else if (a == ' ') {commands[0].Run();}

            else if (a == 'k' && points >= 10)
            {
                commands[1].Run();
            }
            else(a == 's' && points >= 100){
                commands[2].Run();
            }
        }
    }
}
