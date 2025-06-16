using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavingMan
{
    internal class WavingMan
    {
        protected bool _armIsUp;
        protected int _x;
        protected int _y;

        public WavingMan(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void Wave()
        {
            _armIsUp = !_armIsUp;
        }

        public virtual void Show()
        {
            if(_armIsUp)
            {
                Console.CursorLeft = _x;
                Console.CursorTop = _y;
                Console.WriteLine("\\o");
                Console.CursorLeft = _x;
                Console.WriteLine(" |\\");
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
