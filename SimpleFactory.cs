using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IProduct
    {
        void operation();
    }

    public class ConcerteProductA: IProduct
    {
        public void operation() 
        {
            Console.WriteLine("Concrete ProductA operation");
        }
    }

    public class ConcerteProductB : IProduct
    {
        public void operation()
        {
            Console.WriteLine("Concrete ProductB operation");
        }
    }

    //Simple Factory exmaple
    /// <summary>
    /// The SimpleFactory design patteren is a creation pattern that provides a centarilized method for creating instances of
    /// objects without exposing the instantion logic to the client .It encapusulate the object creation process and allow the
    /// the client to request the object through SimpleFactory method, promoting code reusability and flexibity. 
    /// </summary>
    public class SimpleFactory
    {
        public static IProduct CreateProduct(string name)
        {
            switch (name)
            {
                case "A":
                    return new ConcerteProductA();
                case "B":
                    return new ConcerteProductB();
                default: return null;
            }
        }
    }

    // FactoryMethos Example
    /// <summary>
    /// The FactoryMethod design patteren provides provides a interface for creating the object but allow subclasses to alter
    /// the type of objects that will be created. It promotes loose coupling by allowing the client code to work with the interface
    /// rather than concerte implementation of object
    /// </summary>
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
    }

    public class ConcreteCreatorA: Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcerteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcerteProductB();
        }
    }

    /// <summary>
    /// The Abstract Factory design patteren is a creational pattern that provides a interface for creating the families of related objects 
    /// without sepecifing there concenrte classes. It allows client to create objects without needing to know thier
    /// specific implementation , promoting loose couplig and enhancing flexibility.
    /// </summary>
    public interface IAbstractFactoryA
    {
        void operation();
    }

    public class ConcerteProductA1: IAbstractFactoryA
    {
        public void operation()
        {
            Console.WriteLine("Concrete ProductA1operation");
        }
    }

    public class ConcerteProductA2: IAbstractFactoryA
    {
        public void operation()
        {
            Console.WriteLine("Concrete ProductB1operation");
        }
    }

    public interface IAbstractFactoryB
    {
        void operation();
    }

    public class ConcerteProductB1 : IAbstractFactoryB
    {
        public void operation()
        {
            Console.WriteLine("Concrete ProductA1operation");
        }
    }

    public class ConcerteProductB2 : IAbstractFactoryB
    {
        public void operation()
        {
            Console.WriteLine("Concrete ProductB1operation");
        }
    }
}
