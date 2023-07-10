using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace LabRab3_3
{
    public class DateService
    {
        public static string GetDay(String date)
        {
            DateTime givenDate;
            while(!DateTime.TryParse(date,out givenDate))
            {
                Console.WriteLine("Ошибка ввода");
            }
            
            return CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName(givenDate.DayOfWeek);//givenDate.DayOfWeek;
        }

        public static int GetDaySpan(int day,int month,int year)
        {
            DateTime currentDate = DateTime.Now;

            DateTime givenDate = new DateTime(year, month, day);

            return givenDate.Subtract(currentDate).Days;
        }
    }
}
