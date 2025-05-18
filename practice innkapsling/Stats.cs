using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Stats
    {
        private List<int>_numbers = new List<int>();
        private int numberCount = 0;
        private bool done = false;

        internal Stats()
        {
            while (done == false)
            {
                Add();

            }
        }
        public void Add()
        {
            Console.WriteLine("Enter a number to add to the list or type 'done' to finish:");
            string value = Console.ReadLine();

            if (value.ToLower() == "done")
            {
                done = true;
                return;
            }

            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            int number = int.Parse(value);

            _numbers.Add(number);
            numberCount++;
        }

        public int getSum()
        {   
            int sum = 0;
            foreach (var num in _numbers)
            { 
                sum += num;
            }

            return sum;
        }

        public double getAverage()
        {
            if (numberCount == 0)
            {
                return 0;
            }
            double average = (double)getSum() / numberCount;
            return average;
        }

        public int counts()
        {
            return numberCount;
        }



    }
}
