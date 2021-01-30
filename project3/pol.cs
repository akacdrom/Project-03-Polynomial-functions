using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Pol
    {
        public List<string> equations = new List<string>();
        //public List<string>numbers = new List<string>();
        public void addLine (string userInput)
            {
                equations.Add(userInput);
            }

        public void read()
        {
            System.Console.WriteLine("Resulting polynomial will be of the order: "+ (equations.Count() -1));
            int id = 1;
            foreach (string equation in equations)
            {
                
                Console.Write($"\nPol #{id++}: \n");
                
                putEq(equation);

            }
           
        }
        
        public void putEq(string equation)
        {
 
            var parts = equation.Split(' ').ToList();
            //System.Console.WriteLine(equations.Count());
                return;
        }

        
    }
}