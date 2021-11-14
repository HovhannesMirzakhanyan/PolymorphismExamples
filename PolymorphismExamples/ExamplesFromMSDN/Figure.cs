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

    public class Figure
    {
        public const double _pi = Math.PI;
        protected double _x, _y;
       public  string _name;
        public Figure()
        {

        }
        public Figure(string name, double x, double y)
        {
            _name = name;
            _x = x;
            _y = y;
            
        }
        public virtual double Area()
        {
            return _x * _y;
        }
    }

    public class Circle1 : Figure
    {
        public Circle1(string name, double r) : base(name,r, 0)
        {

        }
        public override double Area()
        {
            return _pi * _x * _x;
        }
    }

    public class Pyramid : Figure
    {
        public Pyramid(string name, double r) : base(name, r, 0)
        {

        }

        public override double Area()
        {
            return 4 * _pi * _x * _x;
        }
    }
    public class Cylinder : Figure
    {
        public Cylinder(string name, double r, double h) : base(name,r, h)
        {

        }
        public override double Area()
        {
            return 2 * _pi * _x * _x + 2 * _pi * _x * _y;
        }
    }
}

