using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}

namespace BasicsOOP_lesson4
{


    /*h1. Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати. 
     * Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. Для этого в классе предусмотреть 
     * статическое поле, которое бы хранило последний использованный номер здания, и предусмотреть метод, который увеличивал бы значение этого поля.*/
   internal class House
    {
        private static int _PreviousNumberBuilding =3;//преведущий номер здания
        private int _BuildingNumber;  //номер здания
        private float _BuildingHeight; //высота
        private int _BuildingFloor; //этажность
        private int _NumberAmpartaments;//количество квартир 
        private int _NumberEntrances;  // количество  подездов

        internal int PreviousNumberBuilding { get { return _PreviousNumberBuilding; } set { _PreviousNumberBuilding = value; } }
        internal  int BuildingNumber { get { return _BuildingNumber; } init { _BuildingNumber = value; } } // использования свойства init  
        internal float BuildingHeight { get { return _BuildingHeight; } set { _BuildingHeight = value; } }
        internal int BuildingFloor { get { return _BuildingFloor; } set { _BuildingFloor=value; } }
        internal int NumberAmpartaments { get { return _NumberAmpartaments; } set { _NumberAmpartaments=value; } }
        internal int NumberEntrances { get { return _NumberEntrances; } set { _NumberEntrances = value; } }

        float FloorHeight()  // высота этажа
        {
            return BuildingHeight / BuildingFloor;
        }


        int NumberApartamentaEntrance() // количество квартир в подъезде
        {
            return NumberAmpartaments / NumberEntrances;
        }

      int  NumberApartmentsFlor() // количество квартир на этаже
        {
          return ( NumberAmpartaments / NumberEntrances)/ BuildingFloor;
        }


       internal House() 
        {
            BuildingNumber = PreviousNumberBuilding +1;
        }





    }
}
