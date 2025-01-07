using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEx01
{
    internal interface IMyType
    {

        //Signature Of Methods
        void Fun();

        //Signature Of Properties
       double salary { get; set; }

        //Default Implmented Methods

        void Print()
        {
            Console.WriteLine("Default Implmented Methods");
        }
    }
}
