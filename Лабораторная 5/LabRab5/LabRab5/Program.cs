using System;

namespace LabRab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool flag = true;

            Railway ourRailway = new Railway("Minsk-RW");

            while (flag)
            {

                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Нажмите ... чтобы");
                Console.WriteLine("0 - ввести данные о тарифе");
                Console.WriteLine("1 - зарегистрировать покупку билета");
                Console.WriteLine("2 - рассчитать стоимость купленных пассажиром билетов");
                Console.WriteLine("3 - ввести список пассажиров на данное направление движения");
                Console.WriteLine("4 - выйти из программы");
                Console.WriteLine("5 - вывести список пассажиров");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Неверный ввод!");
                }

                switch (choice)
                {
                    case 0:
                        int price;
                        Console.Clear();
                        Console.WriteLine("Введите направление");
                        string? direction;

                        direction = Console.ReadLine();

                        Console.WriteLine("Введите цену");
                        while (!int.TryParse(Console.ReadLine(), out price))
                        {
                            Console.WriteLine("Ошибка вввода");
                        }

                        ourRailway.AddTicket(price, direction);
                        break;
                    case 1:
                        Console.Clear();
                        string? surname, passport;

                        Console.WriteLine("Введите фамилию пассажира");
                        surname=Console.ReadLine();

                        Console.WriteLine("Введите данные паспорта");
                        passport=Console.ReadLine();

                        ourRailway.AddPassanger(surname, passport);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите фамилию пассажира");
                        string? search = Console.ReadLine();
                        ourRailway.GetSoldTicketsCost(search);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введите направление");
                        string? searchDirection = Console.ReadLine();
                        ourRailway.GetPassengersByDirection(searchDirection);
                        break;
                    case 4:
                        flag = false;
                        Console.WriteLine("До свидания!");
                        break;

                    case 5:
                        Console.Clear();
                        ourRailway.ShowPassangers();
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
