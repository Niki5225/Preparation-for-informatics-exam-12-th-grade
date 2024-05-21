using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Child : Person
    {
        public string Name { get; set; }
        public override int Age {
            get
            {
                return this.age;
            }
            set 
            {
                if (value > 15)
                {
                    this.age = 15;
                }
            } }
        public Child(string name, int age) : base(name, age)
        {
            
        }


    }
}
