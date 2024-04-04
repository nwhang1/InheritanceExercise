using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Reptile : Animal
    {
        public string scaleColor { get; set; }
        public bool laysEggs { get; set; }
        public bool hasShell { get; set; }
        public bool canSwim { get; set; }

        public Reptile(string name, string habitat, int weight, int age, string scaleColor, bool laysEggs, bool hasShell, bool canSwim)
            :base(name, habitat, weight, age)
        {
            this.scaleColor = scaleColor;
            this.laysEggs = laysEggs;
            this.hasShell = hasShell;
            this.canSwim = canSwim;
        }
    }
}
