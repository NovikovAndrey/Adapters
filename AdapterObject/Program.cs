using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Targer targer = new Adapter();
            targer.Request();
            Console.ReadKey();
        }
    }
}
