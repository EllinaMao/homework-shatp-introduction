using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    /*
     Задание 2
Пользователь вводит с клавиатуры два числа. Первое
число — это значение, второе число процент, который
необходимо посчитать. Например, мы ввели с клавиатуры
90 и 10. Требуется вывести на экран 10 процентов от 90.
Результат: 9.

     */
    internal static class Task2
    {
        public static void Result()
        {
            Console.WriteLine("Введите первое число (значение):");
            double value = UsenInput.GetDoubleFromUser();
            Console.WriteLine("Введите второе число (процент):");
            double percentage = UsenInput.GetDoubleFromUser();
            double result = (int)(value * (percentage / 100));

            Console.WriteLine($"{percentage}% от {value} равно {result}");//интерполяция строк

        }


    }
}
