using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEx03
{
    internal class Airplan : IMoveable, IFlyable
    {
        int IMoveable.Spead { get; set; }
        int IFlyable.Spead { get ; set ; }

        void IMoveable.Backword()
        {
            Console.WriteLine("Airplan IMoveable Backword ");
        }

        void IFlyable.Backword()
        {
            Console.WriteLine("Airplan IFlyable Backword ");
        }

        void IMoveable.Forword()
        {
            Console.WriteLine("Airplan IMoveable Forword ");
        }

        void IFlyable.Forword()
        {
            Console.WriteLine("Airplan IFlyable Forword ");
        }

        void IMoveable.Lift()
        {
            Console.WriteLine("Airplan IMoveable Lift ");
        }

        void IFlyable.Lift()
        {
            Console.WriteLine("Airplan IFlyable Lift ");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("Airplan IMoveable Right ");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Airplan IFlyable Right ");
        }
    }
}
