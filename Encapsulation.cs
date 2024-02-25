using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Encapsulation
    {
        // old format to declare the encapsulation
        //private int _experience;

        //public int Experience
        //{
        //    get{
        //        return _experience;
        //    }

        //    set
        //    {
        //        _experience = value;
        //    }
        //}

        //new formart and the code is short and simple
        /// <summary>
        /// It is auto Implemented property  but the behind scenes the c# complier genarates a private filed and the getter and setter
        /// methods for the property . It allows you to access and modify the property as if it were a public field, while still
        /// providing the encapsulation by  controlling access to the underlying filed
        /// </summary>
        public double Experience { get; set; }

        public double CalculateSalary()
        {
            return Experience * 0.5;
        }

    }
}
