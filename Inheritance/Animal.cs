using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, string habitat, double weight, int age)
        {
            Age = age;
            Name = name;
            Habitat = habitat;
            Weight = weight;
        }
    }
}
