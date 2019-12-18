using System;

// Ковариантность обобщений.

namespace Generics
{
    public abstract class Shape { }
    public class Circle : Shape { }

    public interface IContainer<T>
    {
        T Figure { get; set; }
    }

    public class Container<T> : IContainer<T>
    {
        public T Figure { get; set; }

        public Container(T figure)
        {
            this.Figure = figure;
        }
    }

    class Program
    {
        static void Main()
        {
            Circle circle = new Circle();

            IContainer<Circle> container = new Container<Circle>(circle);
            /// Circle circle2 = new Shape(); Imposible operation Shape is abstract class
            Shape shape = new Circle();

            Console.WriteLine(container.Figure.ToString());
            A a = new A();
            a.MyProperty = "1";
            B b = new B();
            b.MyPropertyB = "2";
            A c = new B();
           // B d = new A();


            // Delay.
            Console.ReadKey();
        }
    }
    public class A
    {
        private string field;
        public string MyProperty
        {
            get; set;
        }
        public A()
        {
            Console.WriteLine("This is A class from ctor");
        }
    }
    public class B: A
    {
        private string fieldB;
        public string MyPropertyB
        {
            get;set;
        }
        public B()
        {
            Console.WriteLine("This is B class from ctor");
        }
    }
}
