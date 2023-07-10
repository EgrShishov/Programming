using System;

namespace LabRab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату");
            var date = Console.ReadLine();  
            Console.WriteLine("День недели - " + DateService.GetDay(date));

            int day, month, year;
            Console.WriteLine("Введите дату,для которой нужно вычислить разницу");
            while (!int.TryParse(Console.ReadLine(), out day) || day>31 || day<1)
                Console.WriteLine("Неправильный ввод");

            while (!int.TryParse(Console.ReadLine(), out month) || month>12 || month<1)
                Console.WriteLine("Неправильный ввод");

            while (!int.TryParse(Console.ReadLine(), out year) || year>9999 || year<1)
                Console.WriteLine("Неправильный ввод");

            Console.WriteLine(DateService.GetDaySpan(day,month,year) + " days");
        }
    }
}
