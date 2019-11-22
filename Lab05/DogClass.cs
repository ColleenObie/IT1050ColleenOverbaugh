using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
        public class Dog
        {
            public string Name;
            public static void Main(string[] args)
            {
                Dog myDog = new Dog();
                myDog.Name = "Fido";

                myDog.bark();
                myDog.doTrick("Roll");
            }

            private void bark()
            {
                Console.WriteLine("{0} is barking... ", Name);
            }

            private void doTrick(string trickName)
            {
                Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}", Name, trickName);
            }
        }
}


