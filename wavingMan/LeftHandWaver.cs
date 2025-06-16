using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavingMan
{
    internal class LeftHandWaver : WavingMan
    {

        public LeftHandWaver(int x, int y) : base(x, y)
        {
        }

        public override void Show()
        {

            if (!_armIsUp)
            {
                Console.CursorLeft = _x;
                Console.CursorTop = _y;
                Console.WriteLine(" o/");
                Console.CursorLeft = _x;
                Console.WriteLine("/|");
                Console.CursorLeft = _x;
                Console.WriteLine("/ \\");
            }
            else
            {
                Console.CursorLeft = _x;
                Console.CursorTop = _y;
                Console.WriteLine(" o");
                Console.CursorLeft = _x;
                Console.WriteLine("/|\\");
                Console.CursorLeft = _x;
                Console.WriteLine("/ \\");
            }



        }
    }
}
