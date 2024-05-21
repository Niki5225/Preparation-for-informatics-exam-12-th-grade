using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dessert : Food
    {
        public double Calories { get; set; }
        public Dessert(string name) : base(name, 5, 250)
        {
            this.Calories = 1000;
        }
    }
}
