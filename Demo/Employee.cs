using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IComparable
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }

        public object Clone()
        {
            return new Employee() { id=this.id,name=this.name,age=this.age,salary=this.salary};
        }

        public int CompareTo(object? obj)
        {
            Employee employee =(Employee) obj;
            if (this.age > employee.age) return -1;
            else if (this.age < employee.age) return 1;
            else return 0;
        }

        public override string ToString()
        {
            return $"id={id} , name={name}, age={age},salary={salary}";
        }
    }
}
