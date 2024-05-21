using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public virtual double DefaultFuelConsumption { get => 1.25; }
        public double FuelConsumption { get { return this.DefaultFuelConsumption; } }
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            
        }

        public virtual void Drive(int km)
        {
            this.Fuel -= this.FuelConsumption * km;
        }
    }
}
