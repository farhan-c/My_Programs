using System;
using Task_List;

public class Method_Overriding
{
    class Father  // Base class 
    {
        public virtual void Height() // Adding virtual keyword so that it can be overridden.
        {
            Console.WriteLine("Father's height = 6.2\"");
        }
    }
    class Son : Father  // Derived class 
    {
        public override void Height() // Overriding Father's height
        {
            Console.WriteLine("Son height = 6\"");
        }
    }

    class Daughter : Father  // Derived class 
    {
        public override void Height() //Overriding Father's height
        {
            Console.WriteLine("Daughter height = 5.8\"");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Father obj = new Father();  // Create  Father object
            Daughter obj1 = new Daughter();  // Create  Daughter object
            Son obj2 = new Son();  // Create  Son object

            obj.Height();
            obj2.Height();
            obj1.Height();
        }
    }
}