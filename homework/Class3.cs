using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Пользователь вводит с клавиатуры четыре цифры.
Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
сформировать число 1578.
 */
namespace homework
{
    internal static class Task3
    {
        public static void Result()
        {
            Console.WriteLine("Введите четыре цифры, разделенные пробелами:");
            string input;
            string[] parts;

            while (true)
            {
                input = UsenInput.GetStringFromUser();
                parts = input.Split(' ');

                if (CheckDigits(parts) && CheckLength(parts))
            {
                break;
            }

   
            }
            int num = CreateNumberFromDigits(parts);
            Console.WriteLine($"Ваше число: {num}");

        }
        private static bool CheckLength(string[] parts)
        {
            if (parts.Length != 4)
            {
                Console.WriteLine("Ошибка: введите ровно четыре цифры.");
                return false;
            }
            return true;
        }
        private static bool CheckDigits(string[] parts)
        {
            if (!IsDigit(parts))
            {
                Console.WriteLine("Ошибка: введите только цифры от 1 до 9. ");
                return false;
            }
            return true;
        }

        private static int CreateNumberFromDigits(string[] digits)
        {
            int result = 0;

            foreach (string digit in digits)
            {
                try
                {
                    int num = Int32.Parse(digit);
                    result = result * 10 + num;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите корректные цифры.");
                    return 0;
                }
            }

            return result;
        }

        private static bool IsDigit(string[] parts)
        {
            foreach (string part in parts)
            {
                if (part.Length != 1 || !char.IsDigit(part[0]))
                {
                    return false;
                }
            }
            return true;
        }








    }
}
