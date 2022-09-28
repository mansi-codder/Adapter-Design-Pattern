using System;

namespace AdapterDesignPattern
{
    public class Adaptee
    {
        public int MethodB()
        {
            Console.WriteLine("MethodB() is called");
            return 123;
        }
    }
}
