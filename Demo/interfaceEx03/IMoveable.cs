using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEx03
{
    internal interface IMoveable
    {
        int Spead {  get; set; }
        void Forword();
        void Backword();
        void Lift();
        void Right();
    }
}
