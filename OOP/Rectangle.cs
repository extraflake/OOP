using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Rectangle : Processing
    {
        public Rectangle(int valueA, int valueB)
        {
            ValueA = valueA;
            ValueB = valueB;
        }

        public int ValueA { get; private set; }
        public int ValueB { get; private set; }

        public override double Proceed()
        {
            return ValueA * ValueB;
        }
    }
}
