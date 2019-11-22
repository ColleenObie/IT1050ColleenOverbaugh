using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    class Sweater
    {
        string color = "purple";
        static void Main(string[] args)
        {
            Sweater mySweater = new Sweater();
            Console.WriteLine(mySweater.color);
        }
    }
}