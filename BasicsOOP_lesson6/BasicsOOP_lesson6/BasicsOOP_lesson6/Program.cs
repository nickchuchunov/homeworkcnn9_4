using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson6
{
    class Program
    {
        static void Main(string[] args)
        {

            // первое практическое задание
            //Figure figure = new Figure();

           // figure.Moving(2);
           // figure.Color(6,0,3);

           // Console.WriteLine(figure.Print());
           // Console.ReadLine();


            // 2 задание
            Rectangle _Rectangle = new Rectangle();


            _Rectangle.Color(1, 2, 3);
            _Rectangle.visibility = false;
            _Rectangle._cordinates1.x = 1;
            _Rectangle._cordinates1.y = 1;
            Console.WriteLine(_Rectangle.Print());
            Console.ReadLine();

        }
    }
}
