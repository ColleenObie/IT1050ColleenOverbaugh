using System;

namespace Week3
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Question 2
            int speedLimit = 35;
            int speed = 42;

            if (speedLimit < speed)
            {
                Console.WriteLine("SLOW NOW");
            }

            //Question 3
            {
                bool isTrue;
                isTrue = true;

                if (isTrue)
                {
                    Console.WriteLine("It is true!");
                }
                else
                {
                    Console.WriteLine("It is false!");
                }
            }

            //Question 4
            {
                double celsius;
                Console.Write("Input fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                celsius = (fahrenheit - 32d) * 5d / 9d;
                Console.WriteLine("Celsius is " + celsius);

                if (fahrenheit > 90)
                {
                    Console.WriteLine("It is hot");
                }
                if (fahrenheit < 40)
                {
                    Console.WriteLine("It is cold");
                }
            }
            
        }
    }
}