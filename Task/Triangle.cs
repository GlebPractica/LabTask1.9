using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public abstract class Triangle
    {
        protected double side1;
        protected double side2;
        protected double angle;

        public Triangle(double side1, double side2, double angle)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.angle = angle;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
