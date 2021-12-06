using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabyBox.Models
{
    public class SimonSays
    {
        public int Time { get; set; }
        public int SetTime { get; set; }

        public SimonSays(int time, int settime)
        {
            Time = time;
            SetTime = settime;

        }
        public SimonSays()
        {

        }
    }
}
