using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Coffee : HotBeverage
    {
        private double mililiters = 50;

        private double Caffeine { get; set; }

        public Coffee(string name, double caffeine) : base(name, (decimal)3.50, 50)
        {
            this.Caffeine = caffeine;
        }
    }
}
