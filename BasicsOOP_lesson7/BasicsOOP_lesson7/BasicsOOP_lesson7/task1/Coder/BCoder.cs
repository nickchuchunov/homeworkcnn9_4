using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson7
{
    public class BCoder : ICoder
    {
        /* Определить интерфейс IСoder, который полагает методы поддержки шифрования
строк. В интерфейсе объявляются два метода Encode() и Decode(),
используемые для шифрования и дешифрования строк. Создать класс ACoder,
реализующий интерфейс ICoder. Класс шифрует строку посредством сдвига
каждого символа на одну «алфавитную» позицию выше. (В результате такого
сдвига буква А становится буквой Б). Создать класс BCoder, реализующий
интерфейс ICoder. Класс шифрует строку, выполняя замену каждой буквы,
стоящей в алфавите на i-й позиции, на букву того же регистра, расположенную в
алфавите на i-й позиции с конца алфавита. (Например, буква В заменяется на
букву Э. Написать программу, демонстрирующую функционирование классов).
*/


        public string Decode(string s)
        {
            char[] _s = s.ToCharArray();
            string _s2 = string.Empty;
            //  Encoding CharCode = Encoding.ASCII; Byte[] SBytes = CharCode.GetBytes(s);
            for (int j = 0; j < _s.Length; j++)
            {
                string _s1 = (++_s[j]).ToString();
                _s2 = _s2 + _s1;
            }

            return _s2;
        }

        public string Encoder(string s)
        {

            char[] _s = s.ToCharArray();
            string _s2 = string.Empty;

            for (int j = 0; j < _s.Length; j++)
            {
                string _s1 = (--_s[j]).ToString();
                _s2 = _s2 + _s1;
            }

            return _s2;
        }


    }

}
