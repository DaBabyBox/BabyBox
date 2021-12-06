using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabyBox.Models
{
    public class Light
    {
        public Array Mode { get; set; }
        public int Speed { get; set; }
        public bool IsOn { get; set; }



        public Light(Array mode, int speed, bool ison)
        {
            Speed = speed;
            Mode = mode;
            IsOn = ison;

        }
        public Light()
        {

        }
    }
}
