using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolymorphismExamples.ExamplesFromMSDN;

namespace PolymorphismExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            TestData example = new TestData();
            int add1 = example.Add(25, 36, 98);
            int add2 = example.Add(15, 20);


            Drawing circle = new Circle();
            double circleArea = circle.Area();
            Drawing square = new Square();
            double squareArea = square.Area();
            Drawing rectangle = new Rectangle();
            double rectangleArea = rectangle.Area();


            //Drawing various shapes using polymorphism method

            var shapes = new List<Shape>
            {
                new Sphere(),
                new Cube(),
                new Triangle()
            };
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
    }
}
}

