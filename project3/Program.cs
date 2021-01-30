using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            string userInput;
            Pol pol = new Pol();
            
            Console.Clear();

            Console.WriteLine("Please input points in x y representation\nType END to finish");

            while (true)
            { 
                Console.Write($"Pol {id}: ");
                userInput = Console.ReadLine();
                if (userInput == "END" || userInput == "end")
                {
                    break;
                }
                else
                {
                    pol.addLine(userInput);
                    id++;
                }
            }

            Console.Clear();
            Console.WriteLine("You have entered the following equations:");
            pol.read();
            

            
            Console.ReadLine();
        }
    }
}