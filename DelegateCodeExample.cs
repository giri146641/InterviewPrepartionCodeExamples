using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void Caclculator(int x, int y);

    public class DelegateCodeExample
    {
        public static void Add(int x, int y)
        {
            int a= x += y;
            Console.WriteLine(a);
        }

        public static void Multi(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public static void delegatefunction()
        {
            // normal delegate only single method we can execute
            //Caclculator cal = new Caclculator(Add);
            //cal(10, 15);

            // MultiCast Delegate we can multiple method using multi cast delegate
            Caclculator cal = new Caclculator(Add);
            cal += Multi;
            cal(10, 15);
            Console.ReadLine();
        }
    }
}
