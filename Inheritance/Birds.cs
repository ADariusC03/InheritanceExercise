using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Birds : Animal
    {
        public int Wings { get; set; }
        public string Species { get; set; }
        public bool HasBeak { get; set; }
        public bool IsWarmBlooded { get; set; }

        public Birds()
        {

        }

        public Birds(string name, int age, int legs, bool hasClaws, int wings, string species, bool hasBeak, bool isWarmBlooded)
        {
            Name = name;
            Age = age;
            Legs = legs;
            HasClaws = hasClaws;
            Species = species;
            Wings = wings;
            HasBeak = hasBeak;
            IsWarmBlooded = isWarmBlooded;


        }
    }

}
