using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson6
{
    class Circle: Point
    {

        cordinates _cordinates1 = new cordinates(); // координаты на окружности 
        cordinates _cordinates2 = new cordinates(); // координаты  цента окружности

        public double square()  
        {
            double r = Math.Pow((_cordinates1.x - _cordinates2.x), 2) + Math.Pow((_cordinates1.y - _cordinates2.y), 2);     //= (_cordinates1.x- _cordinates2.x) ^ 2 + _cordinates.y ^ 2;
            double s = r*Math.PI; //  s=p(r*r) извлечение крня из r не требуется 

            return s;
        }





    }
}
