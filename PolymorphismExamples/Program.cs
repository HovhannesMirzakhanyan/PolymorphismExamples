using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            TestData example = new TestData();
            int add1 = example.Add(25,36,98);
            int add2 = example.Add(15, 20);
        }
    }
}

