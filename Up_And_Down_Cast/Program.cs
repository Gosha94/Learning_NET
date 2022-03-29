using System;

namespace Up_And_Down_Cast
{

    internal class Employee { }
    internal class Manager : Employee { }

    class A
    {
        public int ClassAProp { get; set; }
        public void MethA() { }

        public virtual void Method()
        {
            Console.WriteLine("Method A invoked");
        }
    }

    class B : A
    {
        public int ClassBProp { get; set; }
        public void MethB() { }
        public new virtual void Method()
        {
            Console.WriteLine("Method B invoked");
        }
    }

    class C : B
    {
        public int ClassCProp { get; set; }
        public void MethC() { }
        public override void Method()
        {
            Console.WriteLine("Method C invoked");
        }
    }
    class D { }

    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new C();
            a1.Method();    // Method A invoked
            A a2 = new B();
            a2.Method();    // Method A invoked
            B b1 = new B();
            b1.Method();    // Method B invoked
            B b2 = new C();
            b2.Method();    // Method C invoked

            //Manager manager = new Manager();
            //Employee employee = new Employee();

            //Employee employee1 = manager; // Upcast

            //Employee employee2 = manager;
            //Manager manager2 = (Manager)employee2;  // Downcast

            Console.ReadLine();

        }

    }
}