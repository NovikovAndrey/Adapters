using System;

namespace AdapterObject
{
    internal class Adapter : Targer
    {
        Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            adaptee.SpecificRequest();
            Console.WriteLine("my");
        }
    }
}