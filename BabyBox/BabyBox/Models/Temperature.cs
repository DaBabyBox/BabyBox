using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabyBox.Models
{
    public class Temperature
    {
        public int Temp { get; set; }
       

        public Temperature(int temp)
        {
            Temp = temp;
         
        }
        public Temperature()
        {

        }
    }
}
