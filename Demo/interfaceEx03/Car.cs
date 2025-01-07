using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEx03
{
    internal class Car : IMoveable
    {
        public int Spead { get ; set ; }

        public void Backword()
        {
            Console.WriteLine("Car IMoveable Backword "); 
        }

        public void Forword()
        {
            Console.WriteLine("Car IMoveable Forword ");
        }

        public void Lift()
        {
            Console.WriteLine("Car IMoveable Lift ");
        }

        public void Right()
        {
            Console.WriteLine("Car IMoveable Right ");
        }
    }
}
