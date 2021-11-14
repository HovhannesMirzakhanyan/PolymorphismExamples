using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExamples.ExamplesFromMSDN
{
    /// <summary>
    /// Base keyword using example
    /// </summary>
    class Person
    {
        protected string _ssn = "444-55-6666";
        protected string _name = "John Lennon";
        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"SSN:{_ssn}");
        }
    }
    class Employee : Person
    {
        public string _id = "ABCDTE";
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Employee ID: {_id}");
        }
    }
}
