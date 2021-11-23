using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson7
{
    internal class Circle : Point
    {
        internal double R { get; set; } = 5;

        public double square() // метод вычисления площади
        {
              
            double s = R * Math.PI; 

            return s;
        }






        internal override void Moving(int _x = 0, int _y = 0)
        {
            _cordinates.x = _x;
            _cordinates.y = _y;

        }





    }
}
