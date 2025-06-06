using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке.
 */
namespace homework
{
    internal static class Task1
    {
        public static void Result()
        {
            int num = GetNumberFromUser();
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }

        private static int GetNumberFromUser()
        {
            while (true)
            {
                Console.Write("Введите число от 1 до 100: ");
                int num = UsenInput.GetIntFromUser();
                if (num < 1 || num > 100)
                {
                    Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 100. Пожалуйста, попробуйте снова.");
                }
                else
                {
                    return num;
                }
            }
        }
    }
}

