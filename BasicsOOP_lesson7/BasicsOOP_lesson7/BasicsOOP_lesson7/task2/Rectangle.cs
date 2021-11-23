using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson7
{
    class Rectangle : Point
    {
        color _color = new color();




        public cordinates _cordinates1 = new cordinates(); // кординаты противоположных углов прямоугольника
        public cordinates _cordinates2 = new cordinates(); // кординаты противоположных углов прямоугольника



        public double square()  // площадь прямоугольника  при условии что его стораны парралельны осям х и осям y
       {
           double d = Math.Pow((_cordinates1.x - _cordinates2.x), 2) + Math.Pow((_cordinates1.y - _cordinates2.y), 2);  //длина диагонали прямоугольника в квадрате 
           double s = d / 4; // площадь прямоуголника = (диагональ в квадрате) / 4
      
         return s;
        }
      
          internal override string Print()
         {
            string _visibility;
             if (visibility == true) { _visibility = "Видимый"; }
             else { _visibility = "Не видимый"; }
        
        
            string _figure = $"Объек с координатами x1 = {_cordinates1.x} и y1 = {_cordinates1.y}  и  x2 = {_cordinates2.x} и y2 = {_cordinates2.y}\r\n и состоянием {_visibility} \r\n и цветом R= {_color.R}, G = {_color.R} B = {_color.B}";
            return _figure;
        }

        internal override void Moving(int _x1 = 0, int _y1 = 0)
         {
        
             int x = _cordinates1.x - _x1;
             int y = _cordinates1.y - _y1;
        
             _cordinates1.x = _x1;
             _cordinates1.y = _y1;
        
             _cordinates2.x += _x1;  // смещение для определение новых координат противоположного угла
             _cordinates2.y += _y1;
        
        
        
         }




    }
}
