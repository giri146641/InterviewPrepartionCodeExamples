using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Single Inheritance
    public class Inheritance: Encapsulation
    {
        // No need to any code since it inherting the parent class properties and method
        public void Exam()
        {
            Console.WriteLine("To verify the multilevl inheritance");
        }
    }

    interface I2
    {
        void Fly();
    }

    // Multiple INheritance
    // Multiple inheritance in c# we can achive thorugh single Base class and Multiple Interface classes
    public class MultipleInheritance : Encapsulation, I2
    {
        public void Fly()
        {
            Console.WriteLine("Multiple inheritance will work");
        }
    }

    //MultiLevel Inheritance
    public class MultiLevlInheritance: Inheritance 
    {
        // we are trying to call a method from derived class
    }


    // Hierarichal Inheritance
    // Now we are inheriting the Base class for both Inheritance and Hierarihal inheritance classed
    public class HierarichalInheritance: Encapsulation
    {

    }
}
