using System;

namespace Adapter
{
    internal class Adapter1 : Adapteee, ITarget
    {
        public void Request()
        {
            SpecificRequest();
            Console.WriteLine("base");
        }
    }
}