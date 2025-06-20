﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal static class SwapDigitsClass
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

            int pos1, pos2;
            while (true)
            {
                Console.WriteLine("Введите первую позицию для обмена (от 1 до 6):");
                pos1 = GetPosition();

                Console.WriteLine("Введите вторую позицию для обмена (от 1 до 6, не совпадающую с первой):");
                pos2 = GetPosition();

                if (pos1 != pos2)
                {
                    break;
                }
                Console.WriteLine("Позиции не могут быть одинаковыми. Пожалуйста, введите разные позиции.");
            }

            SwapDigits(ref input, pos1, pos2);
            Console.WriteLine($"Результат: {input}");
        }


        public static int GetPosition()
        {

            while (true) { 
            int pos = UsenInput.GetIntFromUser();
            if (IsValidPos(pos))
            {
                return pos;
            }}}

        
        public static void SwapDigits(ref string number, int pos1, int pos2)
        {
            char[] digits = number.ToCharArray();
            char temp = digits[pos1 - 1]; // -1 для перехода к индексу массива
            digits[pos1 - 1] = digits[pos2 - 1];
            digits[pos2 - 1] = temp;
            number = new string(digits);

        }


        private static bool IsValidPos(int pos)
        {
            if (pos < 1 || pos > 6)
            {
                Console.WriteLine("Ошибка: номера разрядов должны быть от 1 до 6.");
                return false;
            }
            

            return true;
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
