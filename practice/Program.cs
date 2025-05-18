using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stats start = new Stats();

            Console.WriteLine($"The number of numbers : {start.counts()}\n"+
                              $"The sum of the numbers is:{start.getSum()}\n" +
                              $"The average of the numbers is: {start.getAverage()}");

        }
     }
       

        
   
}

