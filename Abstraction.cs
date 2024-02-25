using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Abstarction means showing only required things and hiding the implementation/background details
    // We can achive abstraction using abstract class and interfaces
    public abstract class Abstraction
    {
        public abstract void Animal();
    }

    public class Dog : Abstraction 
    { 
        public override void Animal() 
        {
            Console.WriteLine("Abstarction implemented by Abstarct class");
        }
    }

    interface IAbstraction { 
        void Animal();
    }

    public class Pet : IAbstraction
    {
        public void Animal()
        {
            Console.WriteLine("Abstarction implemented by Interface class");
        }
    }
}
