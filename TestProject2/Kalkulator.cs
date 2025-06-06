using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{

    public class Kalkulator
    {
        public int LeggSammen(int a, int b) { return a + b; } 
        public int TrekkFra(int a, int b) { return a - b; } 
        public int Multipliser(int a, int b) { return a * b; } 
        public int Divider(int a, int b) { if (b == 0) { throw new ArgumentException("Cannot divide by zero."); } return a / b; }
    }
}
