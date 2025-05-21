using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Organ_transplant
{
    internal class operation
    {   
        string receiver;
        string donor;

        public operation(string receiver, string donor)
        {
            this.receiver = receiver;
            this.donor = donor;
        }
        public void performOperation()
        {
            Console.WriteLine("The operation is being performed...");
            Console.WriteLine("The organ is being transplanted from " + donor + " to " + receiver);
            successRate();  

        }
        public void successRate() 
        {
            string print = "";
            int successRate = new Random().Next(1,101);

            if (successRate > 90)
            {
                Console.WriteLine("The operation failed!");
            }
            else {
                Console.WriteLine("The operation succeed!");
            }
   
        }
    }
}
