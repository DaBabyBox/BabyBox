using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSays
{
    class RandomNumber
    {
        Form1 _form1;

        public RandomNumber(Form1 Form1)
        {
            _form1 = Form1;
        }
        public void GenerateNumber()
        {
            Random rd = new Random();
            int random = rd.Next(4);

            if (random == 0)
            {
                _form1.BlueBox.Visible = true;
            }
            else if (random == 1)
            {
                _form1.RedBox.Visible = true;
            }
            else if (random == 2)
            {
                _form1.YellowBox.Visible = true;
            }
            else if (random == 3)
            {
                _form1.PurpleBox.Visible = true;
            }


        }
    }
}
