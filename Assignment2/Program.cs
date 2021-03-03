using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleSolver triangleInst = new TriangleSolver();
            var input = "";
            bool shouldContinue = true;
            while (shouldContinue)
            {
                Console.WriteLine(
                    "Please enter one of the following:" + "\n"
                    + "1. Enter Triangle dimensions." + "\n"
                    + "2. Exit");

                Console.Write("Enter a option - ");
                input = Console.ReadLine();
                int num = -1;
                if (!int.TryParse(input, out num))
                {
                    Console.WriteLine("Not an integer. Please enter valid input.");
                }
                else
                {
                    int option = Convert.ToInt32(input);
                    switch (option)
                    {
                        case 1:
                            int a, b, c;
                            Console.Write("Enter a value for side 1: ");
                            while (!int.TryParse(Console.ReadLine(), out a))
                                Console.Write("The value must be of integer type, please enter again: ");
                            Console.Write("Enter a value for side 2: ");
                            while (!int.TryParse(Console.ReadLine(), out b))
                                Console.Write("The value must be of integer type, please enter again: ");
                            Console.Write("Enter a value for side 3: ");
                            while (!int.TryParse(Console.ReadLine(), out c))
                                Console.Write("The value must be of integer type, please enter again: ");
                            Console.WriteLine(triangleInst.Analyze(a, b, c));
                            break;
                        case 2:
                            shouldContinue = false;
                            break;
                    }
                }
            }
        }
    }
}
