using System;
namespace FigureAreaLibrary
{
    public class FigureManager
    {

        public FigureManager(double radius)
        {
            var circle = new Circle(radius);
            circle.FigureName();
            circle.GetFigureArea();
        }

        public FigureManager(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            triangle.FigureName();
            triangle.GetFigureArea();
        }
    }
}
