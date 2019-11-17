using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04_ExtraCredit
{
    class Program
    { 
        static void Main(string[] args)
       
        {   
            //Extra Credit Triangle A and B.
            int i;
            int j;

            for (i = 0; i < 10; i++)
            {
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("**********".Substring(0, i));
                }
                Console.WriteLine();
            }
            for (j = 10; j > 0; j--)
            {
                for (j = 10; j > 0; j--)
                {
                    Console.WriteLine("**********".Substring(0, j));
                }
                Console.WriteLine();
            }


        }  

    }
}
