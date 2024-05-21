using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class RaceMotorcycle : Motorcycle
    {
        public override double DefaultFuelConsumption { get => 8; }
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            
        }
    }
}
