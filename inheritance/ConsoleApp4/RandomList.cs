using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();
            int indexOfNum = random.Next(0, this.Count);
            string randomString = this[indexOfNum];
            RemoveAt(indexOfNum);
            return randomString;
        }
    }
}
