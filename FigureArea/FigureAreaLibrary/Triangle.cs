using System;
namespace FigureAreaLibrary
{
    public class Triangle : Figure
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetFigureArea()
        {
            var perimeter = (A + B + C) / 2;
            var triangleArea = Math.Sqrt(perimeter * (perimeter - A) * (perimeter - B) * (perimeter - C));
            CheckTriangleType(A, B, C);
            Console.WriteLine(triangleArea);
            return triangleArea;
        }

        private void CheckTriangleType(double a, double b, double c)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
            {
                Console.WriteLine("Triangle is rectangular");
            }
            else
            {
                Console.WriteLine("Triangle is not rectangular");
            }
        }

        public override string FigureName()
        {
            var name = "Triangle";
            Console.WriteLine(name);
            return name;
        }
    }
}
