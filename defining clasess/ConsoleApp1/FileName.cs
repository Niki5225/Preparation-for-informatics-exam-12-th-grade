﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }



        public string Name { get; set; }
        public int Age { get; set; }


    }
}
