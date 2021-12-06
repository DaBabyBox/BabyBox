using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabyBox.Models
{
    public class Animal
    {
        public bool OnSwitch { get; set; }
        public Array Sounds { get; set; }

        public Animal(bool onswitch, Array sounds)
        {
            OnSwitch = onswitch;
            Sounds = sounds;

        }
        public Animal()
        {

        }
    }
}
