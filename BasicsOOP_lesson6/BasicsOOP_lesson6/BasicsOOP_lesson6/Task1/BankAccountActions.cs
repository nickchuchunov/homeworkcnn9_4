using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson6.Task1
/* 1. Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах.
 * Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode(). 
 * Переопределить методToString() для печати информации о счете. 
 * Протестировать функционирование переопределенных методов и операторов на простом примере.  */

{
    class BankAccountActions : IEquatable<BankAccountActions>
    {
        private static long _AccountNameActions = 155455245555;
        private decimal _RemainsActions = 32546465;
        private string _TypeBankAccount = "active";
        public long AccountNameActions { get { return _AccountNameActions; } set { _AccountNameActions = value; } }
        public decimal? RemainsActions { get { return _RemainsActions; } set { _RemainsActions = (decimal)value; } }
        public string TypeBankAccountActions { get { return _TypeBankAccount; } set { _TypeBankAccount = value; } }

     

        public void TaceOff(long _AccountNameActions, decimal summ) //  метод снятия со счета первый пораметр имя счета 2 параметр сумма.
        {
            bool _TopUp = decimal.TryParse(summ.ToString(), out decimal number);

            if (_TopUp & (_AccountNameActions is long AccountNameActions))
            {
                RemainsActions = RemainsActions - number;
                Console.WriteLine("Денежные средства переведены, на счете {0} денежных средств", RemainsActions);
                Console.ReadLine();
            }
            else { Console.WriteLine("не правильные данные для перевода денежных средств"); }
        }

        public static bool operator ==(BankAccountActions Name1, BankAccountActions Name2) 
        {

            long _remains = Name1.AccountNameActions % Name2.AccountNameActions; 

            if (_remains is 0) return true;
            else return false;

        }


        public static bool operator !=(BankAccountActions Name1, BankAccountActions Name2)
        {

            long _remains = Name1.AccountNameActions % Name2.AccountNameActions;

            if (_remains is 0) return false;
            else return true;

        }


        

        public bool Equals(BankAccountActions Name3)
        {
            

            return Name3 != null &&
                   AccountNameActions == Name3.AccountNameActions;
        }

        public override int GetHashCode()
        {
            return (int)(AccountNameActions + RemainsActions);
        }








    }
}
