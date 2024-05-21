using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance = 0;

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }



        public void Drive(int amountKm)
        {
            if (this.FuelAmount - (amountKm * this.FuelConsumptionPerKilometer) >= 0)
            {
                this.FuelAmount -= amountKm * this.FuelConsumptionPerKilometer;
                this.TravelledDistance += amountKm;
            } else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}
