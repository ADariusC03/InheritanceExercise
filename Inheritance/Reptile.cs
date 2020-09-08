using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public int Heads { get; set; }
        public string Type { get; set; }
        public string Environment { get; set; }
        public bool IsColdBlooded { get; set; }

        public Reptile()
        {

        }

        public Reptile(string name, int age, int legs, bool hasClaws, int heads, string enivronment, string type, bool isColdBlooded )
        {
            Name = name;
            Age = age;
            Legs = legs;
            HasClaws = hasClaws;
            IsColdBlooded = isColdBlooded;
            Heads = heads;
            Type = type;
            Environment = enivronment;
        }
    }
}
