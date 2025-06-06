using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal static class Task4
    {/*
      Задание 4
Пользователь вводит шестизначное число. После чего
пользователь вводит номера разрядов для обмена цифр.
Например, если пользователь ввёл один и шесть — это
значит, что надо обменять местами первую и шестую
цифры.
Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.*/
        public static void Result()
        {
            Console.WriteLine("Введите шестизначное число:");
            string input;
            while (true)
            {
                input = UsenInput.GetStringFromUser();
                if (IsValidInput(input))
                {
                    break;
                }
            }
            Console.WriteLine("Введите номера разрядов для обмена (например, 1 и 6):");
            string[] positions;
            while (true)
            {
                positions = UsenInput.GetStringFromUser().Split(' ');
                if (positions.Length == 2)
                {
                    break;
                }
                Console.WriteLine("Ошибка: введите два корректных номера разрядов.");
            }
            int pos1 = int.Parse(positions[0]) - 1; // Преобразуем в нулевой индекс
            


        }



        private static bool IsValidInput(string input)
        {
            if (input.Length !=6)
                            {
                Console.WriteLine("Ошибка: введите шестизначное число.");
                return false;
            }
            if (!int.TryParse(input, out _))
            {
                Console.WriteLine("Ошибка: введите только цифры.");
                return false;
            }

            return true;
        }






    }
}
