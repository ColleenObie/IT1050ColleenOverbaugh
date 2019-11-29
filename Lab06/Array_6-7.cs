using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_02
{
    class Program
    {
        static void Main(string[] args)
        { /*Question 6 
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine("{0,2}. {1}", i, names[i++]);
            }
            */
            //Question 7
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine("{0,2}. {1}", i, names[i++]);
            }
            foreach (var name in names)
            {
                Console.WriteLine("{0,2}. {1}", i, names[i++]);
            }
        }
    }
}
