using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class RightTriangle : Triangle // Прямоугольный треугольник
    {
        private double side3;

        public RightTriangle(double side1, double side2) : base(side1, side2, 90) // Угол между сторонами в прямоугольном треугольнике равен 90 градусам
        {
            this.side3 = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2)); // Вычисляем длину третьей стороны по теореме Пифагора
        }

        public override double CalculateArea()
        {
            return 0.5 * side1 * side2;
        }

        public override double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
