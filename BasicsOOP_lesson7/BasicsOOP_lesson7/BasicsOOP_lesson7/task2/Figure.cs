using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson7
{
    /* Создать класс Figure для работы с геометрическими фигурами. В качестве
полей класса задаются цвет фигуры, состояние «видимое/невидимое».
Реализовать операции: передвижение геометрической фигуры по горизонтали,
по вертикали, изменение цвета, опрос состояния (видимый/невидимый). Метод
вывода на экран должен выводить состояние всех полей объекта. Создать класс
Point (точка) как потомок геометрической фигуры. Создать класс Circle
(окружность) как потомок точки. В класс Circle добавить метод, который
вычисляет площадь окружности. Создать класс Rectangle (прямоугольник) как
потомок точки, реализовать метод вычисления площади прямоугольника. Точка,
окружность, прямоугольник должны поддерживать методы передвижения по
горизонтали и вертикали, изменения цвета. Подумать, какие методы можно
объявить в интерфейсе, нужно ли объявлять абстрактный класс, какие методы и
поля будут в абстрактном классе, какие методы будут виртуальными, какие
перегруженными. */
   internal  class Figure
    {

        internal struct color
        {
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
        }

        internal bool visibility { get; set; } = true;

        internal   struct cordinates
        {
            public int x { get; set; }
            public int y { get; set; }

        }


        internal cordinates _cordinates = new cordinates();

        internal virtual void Moving(int _x = 0, int _y = 0) 
        {
            _cordinates.x = _x;
            _cordinates.y = _y;
        }
      
        

       internal color _color = new color();


        internal virtual void Color(int R = 0, int G = 0, int B = 0)
        {
            _color.R = R;
            _color.G = G;
            _color.B = B;
        }



        internal virtual string Print()
        {

            string _visibility;
            if (visibility == true) { _visibility = "Видимый"; }
            else { _visibility = "Не видимый"; }


            string _figure = $"Объек с координатами x = {_cordinates.x} и y = {_cordinates.y} \r\n и состоянием {_visibility} \r\n и цветом R= {_color.R}, G = {_color.R} B = {_color.B}";
            return _figure;

        }





    }
}
