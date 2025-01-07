using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : ICloneable
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }

        public object Clone()
        {
            return new Employee() { id=this.id,name=this.name,age=this.age,salary=this.salary};
        }

        public override string ToString()
        {
            return $"id={id} , name={name}, age={age},salary={salary}";
        }
    }
}
