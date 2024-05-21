using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        protected int age;

        public string Name { get; set; }
        public virtual int  Age { 
            get
            {
                return this.age;
            }
            set 
            { 
                if(value < 0)
                {
                    value = 0;
                }
                this.age = value;
            } }

        public Person(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(string.Format("Name: {0}, Age: {1}",
                this.Name, this.Age));

            return stringBuilder.ToString();
        }
    }
}
