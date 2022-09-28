using System;

namespace AdapterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Client client = new Client(new AdapterInheritance());
            client.MakeRequest();
            Console.WriteLine(client.MakeRequest());
        }
    }
}
