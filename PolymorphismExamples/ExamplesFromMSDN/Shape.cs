using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExamples.ExamplesFromMSDN
{

    /// <summary>
    /// Polymophism examples from MSDN
    /// </summary>
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }
    public class Triangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }
    public class Sphere : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a sphere");
            base.Draw();
        }
    }
    public class Cube : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a cube");
            base.Draw();
        }
    }
}
