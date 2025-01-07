using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig03.Q01
{
    internal interface IShape
    {
        double Area { get; set; }

        void DisplayShapeInfo();
    }
}
