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
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tireList;

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> TireList { get; set; }

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tireList)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.TireList = tireList;

        }
    }
}