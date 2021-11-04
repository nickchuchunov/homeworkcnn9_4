using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson5
{
    /*     1. Создать класс рациональных чисел. В классе два поля – числитель и знаменатель. 
     *     Предусмотреть конструктор. Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, –, ++, --. 
     *     Переопределить метод ToString() для вывода дроби. 
     *     Определить операторы преобразования типов между типом дробь,float, int. Определить операторы *, /, %.        */
    class RationalNumber
    {
        internal int Numerator { get; set; }
        internal int Denominator { get; set; }

        RationalNumber() { }


        public static bool operator ==(RationalNumber RationalNumber_1, RationalNumber RationalNumber_2) 
        {
            if (Equals(RationalNumber_1, RationalNumber_2)) return true;
            else return false;
        }
        public static bool operator !=(RationalNumber RationalNumber_1, RationalNumber RationalNumber_2)
        {
            if (Equals(RationalNumber_1, RationalNumber_2)) return false;
            else return true;
        }

        public static bool operator >(RationalNumber RationalNumber_1, RationalNumber RationalNumber_2) 
        {
            if (RationalNumber_1 > RationalNumber_2) return true;
            else return false;
        
        }

        public static bool operator <(RationalNumber RationalNumber_1, RationalNumber RationalNumber_2)
        {
            if (RationalNumber_1 < RationalNumber_2) return true;
            else return false;

        }

        public static bool operator <=(RationalNumber RationalNumber_1, RationalNumber RationalNumber_2) 
        {
            if (RationalNumber_1 <= RationalNumber_2) return true;
            else  return false;
        }

        public static bool operator >=(RationalNumber RationalNumber_1, RationalNumber RationalNumber_2)
        {
            if (RationalNumber_1 >= RationalNumber_2) return true;
            else return false;
        }

        public static int operator +(RationalNumber number)
        {
            return number.Numerator + number.Denominator;

        }


        public static int operator -(RationalNumber number)
        {
            return number.Numerator - number.Denominator;

        }

        public static RationalNumber operator ++(RationalNumber number)
        {

            ++number.Numerator;
            ++number.Denominator;
                return number;
        }


        public static RationalNumber operator --(RationalNumber number)
        {
            --number.Numerator;
            --number.Denominator;
            return number;
        }

        public override string ToString() //RationalNumber value
        {
            int num = Numerator /Denominator;
            return $"{num}";

        }

        public static implicit operator float(RationalNumber value)
        {
            return value.Numerator/value.Denominator;

        }


        public static RationalNumber operator *(RationalNumber RationalNumber_1, RationalNumber RationalNumber_2)
        {
            int value_1 = RationalNumber_1.Numerator * RationalNumber_2.Numerator;
            int value_2 = RationalNumber_1.Denominator * RationalNumber_2.Denominator;

            return new RationalNumber() { Numerator = value_1, Denominator = value_2 };

        }

        public static RationalNumber operator /(RationalNumber RationalNumber_1, RationalNumber RationalNumber_2)
        {
            int value_1 = RationalNumber_1.Numerator / RationalNumber_2.Numerator;
            int value_2 = RationalNumber_1.Denominator / RationalNumber_2.Denominator;

            return new RationalNumber() { Numerator = value_1, Denominator = value_2 };

        }

        public static RationalNumber operator %(RationalNumber RationalNumber_1, RationalNumber RationalNumber_2)
        {
            int value_1 = RationalNumber_1.Numerator % RationalNumber_2.Numerator;
            int value_2 = RationalNumber_1.Denominator % RationalNumber_2.Denominator;

            return new RationalNumber() { Numerator = value_1, Denominator = value_2 };

        }




    }
}
