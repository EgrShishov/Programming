using System;

namespace LabRab4
{  
    class Program
    {
        static void Main(string[] args)
        {

            string? name;

            int price, sitsAmount, soldTicketsAmount;

            Console.WriteLine("Введите название железнодорожной станции");

            name=Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите цену одного билета");

            while (!int.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Ошибка ввода!");
            }

            Console.WriteLine("Введите количество мест");

            while (!int.TryParse(Console.ReadLine(), out sitsAmount))
            {
                Console.WriteLine("Ошибка ввода!");
            }

            Console.WriteLine("Введите количество проданных билетов");
            while (!int.TryParse(Console.ReadLine(), out soldTicketsAmount))
            {
                Console.WriteLine("Ошибка ввода!");
            }

            Railway ourRailway = Railway.setRailway(name, price, sitsAmount, soldTicketsAmount);

            Console.Write("Стоимость непроданных билетов : ");
            Console.WriteLine(ourRailway.costOfUnSoldTickets());

            Console.Write("Наша станция : ");
            Console.WriteLine(ourRailway.getName());

            Console.Write("Цена после увеличения на 30 : ");
            ourRailway.increase(30);
            Console.WriteLine(ourRailway.getPrice());

        }
    }
}