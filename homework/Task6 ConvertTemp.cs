using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{/*Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий
или наоборот.

  */
    internal class ConvertTemp
    {
        static public void Result()
        {
            Console.WriteLine("Введите номер клавиши какую температуру вы хотите конвертировать?\n" +
                "1. Цельсий -> Фаренгейт\n" +
                "2. Фаренгейт -> Цельсий");
            int choice = UsenInput.GetIntFromUser();
            Console.WriteLine("Введите температуру: ");
            double temp = UsenInput.GetDoubleFromUser();
            int num1 = 32;
            double num2 = 1.8;

            switch (choice)
            {
                case 1:

                    double fahrenheit = temp * num2 + num1;
                    Console.WriteLine($"Результат: {fahrenheit:F2} °F");
                    break;

                case 2:
                    double celsius = (temp - num1) * num2;
                    Console.WriteLine($"Результат: {celsius:F2} °C");
                    break;

                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }


        }



        
        
    }


}
