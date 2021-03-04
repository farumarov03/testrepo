using System;

namespace FigureAreaLibrary
{
    public class Circle : Figure
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetFigureArea()
        {
            var circleArea = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine(circleArea);
            return circleArea;
        }

        public override string FigureName()
        {
            var name = "Circle";
            Console.WriteLine(name);
            return name;
        }
    }
}
