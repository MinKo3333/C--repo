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
            var answer = new Program();
            var number = answer.AreEqual();
          
 
            Console.WriteLine($" {number.a},{number.b}");

        }
            
        public (int a,int b) AreEqual()
        {   var rand = new Random();

            int a = rand.Next(0 , 3);
            int b = rand.Next(3 , 7);

            return (a ,b);
        }

        //Oppgave 3:
        //Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30,
        //skal metoden returnere true. Ellers returnerer metoden false



    }
}

