using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Picture
    {
        private List<Triangle> triangles;

        public Picture()
        {
            triangles = new List<Triangle>();
        }

        public void AddTriangle(Triangle triangle)
        {
            if (triangle == null)
                return;

            triangles.Add(triangle);
        }

        public string PrintTriangleCharacteristics()
        {
            if (triangles == null)
                return $" Площадь: неизвестна; Периметр: неизвестен.";

            string info = "";
            foreach (var triangle in triangles)
            {
                string triangleType = "";
                if (triangle is EquilateralTriangle)
                {
                    triangleType = "Равносторонний";
                }
                else if (triangle is IsoscelesTriangle)
                {
                    triangleType = "Равнобедренный";
                }
                else if (triangle is RightTriangle)
                {
                    triangleType = "Прямоугольный";
                }
                else
                {
                    triangleType = "Неизвестный";
                }

                info += $"Тип треугольника: {triangleType}, Площадь: {triangle.CalculateArea()}, Периметр: {triangle.CalculatePerimeter()}\n";
            }
            return info;

        }

        public double CalculateTotalArea()
        {
            if (triangles.Count > 0)
            {
                double totalArea = 0;
                foreach (var triangle in triangles)
                {
                    totalArea += triangle.CalculateArea();
                }
                return totalArea;
            }

            return 0;
        }
    }
}
