using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double mililiters) : base(name, price, mililiters)
        {

        }
    }
}