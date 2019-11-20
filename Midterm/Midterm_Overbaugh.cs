using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm1
{
    class Program
    {
        static void Main(string[] args)
        {/*Question 2
            bool keepLooping = true;

            while (keepLooping)
            {
                Console.WriteLine("True");
            }
            */
            /*Question 3
            int counter = 2;

            while (counter < 128)
            {
                Console.WriteLine("["+counter+"]");
                counter *= 2;
            }
            */
            /*Question 4
            for (int counter = 49; counter >= 1; counter--)
            {
                Console.Write(counter);
            if (counter > 1) 
                Console.Write(", ");
            }
            */
            /*Question 5
            int counter = 1;

            while (counter <= 21)
            { 
                Console.Write(counter + " ");
                counter += 2;
            }
            */
            /*Question 7
            bool icyRain;
            bool tornadoWarning;

            icyRain = false;
            tornadoWarning = false;

            if (!icyRain && !tornadoWarning)
            {
                Console.WriteLine("Let's go outside!");
            }
            */
            //Extra Credit!
            int counter = 0;
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 0; j < counter; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                counter++;
            }
        }
    }
}
