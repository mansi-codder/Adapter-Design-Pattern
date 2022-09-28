using System;

namespace AdapterDesignPattern
{
    public class AdapterInheritance : Adaptee, ITarget
    {
        public string MethodA()
        {
          return Convert.ToString(MethodB());
        }
    }
}
