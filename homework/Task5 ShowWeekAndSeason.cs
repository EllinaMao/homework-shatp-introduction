using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal static class ShowWeekAndSeason
    {
        /* Задание 5
        Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели.
        Например, если введено 22.12.2021, приложение должно
        отобразить Winter Wednesday.
        */
        public static void Result()
        {
            try
            {

            Console.WriteLine("Введите дату в формате ДД.ММ.ГГГГ:");
            DateTime date = GetDateFromUser();

            string season = GetSeason(date);
            string dayOfWeek = date.DayOfWeek.ToString();
            Console.WriteLine($"{season} {dayOfWeek}");
            }
            catch( Exception ex ) {
                Console.WriteLine(ex.Message);
            }
        }
        private static string GetSeason(DateTime date)
        {

            if (date.Month == 12 || date.Month <= 2)
                return "Winter";
            else if (date.Month >= 3 && date.Month <= 5)
                return "Spring";
            else if (date.Month >= 6 && date.Month <= 8)
                return "Summer";
            else
                return "Autumn";
        }


        private static DateTime GetDateFromUser()
        {
            try { 

                string dateString = UsenInput.GetStringFromUser();
                DateTime dateTime = Convert.ToDateTime(dateString);
                return dateTime;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }











    }
}

