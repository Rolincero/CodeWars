using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Methods
{
    internal class Even_Or_Not
    {

        /*
         * 
         * В этой Ката мы передаем число (n) в функцию.
         *
         * Ваш код определит, является ли пройденный номер четным (или нет).
         *
         * Функция должна возвращать либо true, либо false.
         *
         * Числа могут быть положительными или отрицательными, целыми или плавающими.
         *
         * Поплавки с десятичной частью, не равной нулю, считаются даже для этого ката.
         * 
         */

        public static bool IsEven(int n)
        {
            return n % 2 == 0 ? true : false;
        }
    }
}
