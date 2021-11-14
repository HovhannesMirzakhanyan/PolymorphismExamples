using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExamples.ExamplesFromMSDN
{
    /// <summary>
    /// Vrtual modifier example
    /// </summary>
    class TestClass
    {
        public class Figure
        {
            public const double _pi = Math.PI;
            protected double _x, _y;
            public Figure()
            {

            }
            public Figure(double x, double y)
            {
                _x = x;
                _y = y;
            }
            public virtual double Area()
            {
                return _x * _y;
            }
        }

        public class Circle : Figure
        {
            public Circle(double r):base(r,0)
            {

            }
            public override double Area()
            {
                return _pi * _x * _x;
            }
        }

        public class Sphere:Figure
        {
            public Sphere(double r):base(r,0)
            {

            }

            public override double Area()
            {
                return 4 * _pi * _x * _x;
            }
        }
        public class Cylinder : Figure
        {
            public Cylinder(double r, double h):base(r,h)
            {

            }
            public override double Area()
            {
                return 2 * _pi * _x * _x + 2 * _pi * _x * _y;
            }
        }
    }
}
