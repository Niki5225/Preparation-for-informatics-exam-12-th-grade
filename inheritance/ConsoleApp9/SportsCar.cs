using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class SportsCar : Car
    {
        public override double DefaultFuelConsumption { get => 10; }
        public SportsCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }
}
