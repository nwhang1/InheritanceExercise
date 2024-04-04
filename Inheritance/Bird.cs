using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool CanFly { get; set; }
        public string FeatherColor { get; set; }
        public double Wingspan { get; set; }
        public string BeakShape { get; set; }

        public Bird(string name, string habitat, int weight, int age, bool canFly, string featherColor, double wingspan, string beakShape)
            : base(name, habitat, weight, age)
        {
            CanFly = canFly;
            FeatherColor = featherColor;
            Wingspan = wingspan;
            BeakShape = beakShape;
        }
    }
}
