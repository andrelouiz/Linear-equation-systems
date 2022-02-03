using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_equation_systems
{
    class Program 
    {
        static void Main(string[] args)
        {
            int id = 1;
            bool exitIfFalse = true;
            string userInput;
            Matrix matrix = new Matrix();

            Console.WriteLine("Type linear equations in augmented matrix notation: a1 a2 ... aN d,\n        where a1 ... are parameters and d is constant");
            Console.WriteLine("\nType END to finish entering equations\n");

            while (exitIfFalse)
            {
                Console.Write($"Equation {id}: ");
                userInput = Console.ReadLine();
                if (userInput == "END")
                {
                    break;
                }
                else if (new Equation(userInput).CheckEquation() && !string.IsNullOrEmpty(userInput))
                {
                    matrix.AddEquation(userInput);
                    id++;
                }
            }

            Console.Clear();
            Console.WriteLine("You have entered the following equations:");

            matrix.ShowEquations();
            Console.WriteLine("\nAnswers:");
            matrix.Solve();
            matrix.ShowAnswers();

            Console.ReadLine();
        }
    }


}
