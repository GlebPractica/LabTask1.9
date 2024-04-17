using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class EquilateralTriangle : Triangle // Равносторонний треугольник
    {
        private double side3;

        public EquilateralTriangle(double side) : base(side, side, 60) // Угол между сторонами в равностороннем треугольнике равен 60 градусам
        {
            this.side3 = side;
        }

        public override double CalculateArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(side3, 2);
        }

        public override double CalculatePerimeter()
        {
            return 3 * side3;
        }
    }
}
