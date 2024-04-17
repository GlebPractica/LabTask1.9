using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class IsoscelesTriangle : Triangle // Равнобедренный треугольник
    {
        private double baseSide;

        public IsoscelesTriangle(double side, double baseSide, double angle) : base(side, side, angle)
        {
            this.baseSide = baseSide;
        }

        public override double CalculateArea()
        {
            return (baseSide / 4) * Math.Sqrt(4 * Math.Pow(side1, 2) - Math.Pow(baseSide, 2));
        }

        public override double CalculatePerimeter()
        {
            return 2 * side1 + baseSide;
        }
    }
}
