using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04
{
    class Program
    {
        static void Main(string[] args)

        { /*Question 4
            int i;

            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            if ((i % 2) == 0)
            {
                Console.WriteLine("It is even!");
            }
            else if ((i % 2) !=0)
            {
                Console.WriteLine("It is odd!");
            }
           */

            /*Question 5
             Console.WriteLine("Please enter a temperature: ");
             int temp = Convert.ToInt32(Console.ReadLine());

             if (temp < 10) { Console.WriteLine("Polar Bear"); }
             else if (temp < 20) { Console.WriteLine("Penguin"); }
             else if (temp < 40) { Console.WriteLine("Moose"); }
             else if (temp < 50) { Console.WriteLine("Reindeer"); }
             else if (temp < 60) { Console.WriteLine("Deer"); }
             else if (temp < 70) { Console.WriteLine("Turtle"); }
             else if (temp < 80) { Console.WriteLine("Lion"); }
             else if (temp < 90) { Console.WriteLine("Fish"); }
             else { Console.WriteLine("Bug"); }
            */

                
                //Question 6
            {
                Console.WriteLine("Please enter the exhibit number: ");
                string str = Console.ReadLine();
                int caseSwitch = int.Parse(str);
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Polar Bear");
                        break;
                    case 2:
                        Console.WriteLine("Penguin");
                        break;
                    case 3:
                        Console.WriteLine("Moose");
                        break;
                    case 4:
                        Console.WriteLine("Reindeer");
                        break;
                    case 5:
                        Console.WriteLine("Deer");
                        break;
                    case 6:
                        Console.WriteLine("Turtle");
                        break;
                    case 7:
                        Console.WriteLine("Lion");
                        break;
                    case 8:
                        Console.WriteLine("Fish");
                        break;
                    case 9:
                        Console.WriteLine("Bug");
                        break;
                }
            }

        }
    }
}
