using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car : Vehicle
    {

        public override double DefaultFuelConsumption { get => 3; }
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            
        }
    }
}
