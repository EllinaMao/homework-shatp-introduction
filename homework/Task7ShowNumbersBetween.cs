using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{/*
Задание 7
Пользователь вводит с клавиатуры два числа. Нужно
показать все четные числа в указанном диапазоне. Если
границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь
ввел 20 и 11, требуется нормализация, после которой
начало диапазона станет равно 11, а конец 20.
*/
    internal class ShowNumbersBetween
    {
        public static void Result()
        {
            Console.WriteLine("Введите два числа разделенных пробелом: ");
            int num1;
            int num2;
            while (true)
            {
                string numbers = UsenInput.GetStringFromUser();

                string[] parts = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 2)
                {
                    num1 = int.Parse(parts[0]);
                    num2 = int.Parse(parts[1]);

                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите два корректных числа через пробел.");
                }
            }

            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.WriteLine("Все четные числа данного диапазона: ");
            OutEven(num1, num2);


        }


        private static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        private static void OutEven(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (IsEven(i))
                {
                    Console.WriteLine(i);
                }
            }
        }



    }
}
