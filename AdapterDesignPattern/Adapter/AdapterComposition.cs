using System;

namespace AdapterDesignPattern
{
    public class AdapterComposition : ITarget
    {
        private readonly Adaptee _adaptee;
        public AdapterComposition(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public string MethodA()
        {
          return Convert.ToString(_adaptee.MethodB());
        }
    }
}
