using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEx01
{
    internal class MyType : IMyType
    {
        public double salary { get ; set ; }

        public void Fun()
        {
            Console.WriteLine("Hello World :)");
        }
    }
}
