using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRab5
{
    public class Railway
    {
        private string? RailwayName;
        private List<Ticket> Tickets = new List<Ticket>();
        private List<Passanger> Passangers = new List<Passanger>();

        public Railway(string? RailwayName) 
        {
            this.RailwayName=RailwayName;
        }

        public List<Passanger> GetPassengers
        {
            get { return Passangers; }
        }

        public string? GetRailwayName
        {
            get { return RailwayName; }
        }

        public List<Ticket> GetTickets
        {
            get { return Tickets; }
        }

        public void AddPassanger(string? surname,string? passport)
        {

            bool isExist = false;

            Console.WriteLine("Введите направление поездки");
            string? direction = Console.ReadLine();

            foreach(var person in Passangers)
            {
                if (person.Surname==surname)
                {
                    isExist = true;

                    foreach (var ticket in Tickets)
                    {
                        if (ticket.TravelDirection==direction)
                        {
                            person.BuyTicket(ticket);
                        }
                    }
                }
            }

            if (!isExist)
            {
                Passanger passanger = new Passanger(surname, passport);
                Passangers.Add(passanger);

                foreach(var ticket in Tickets)
                {
                    if (ticket.TravelDirection==direction)
                    {
                        passanger.BuyTicket(ticket);
                    }
                }
            }

        }

        public void AddTicket(int price,string? direction)
        {
            Ticket ticket = new Ticket();
            ticket.Price = price;
            ticket.TravelDirection = direction;
            Tickets.Add(ticket);
        }

        public void GetPassengersByDirection(string? direction)
        {
            if (Tickets!=null && Passangers!=null)
            {
                bool find = false;

                foreach(var person in Passangers)
                {
                    foreach(var curr in person.BoughtTickets)
                    {
                        if(curr.TravelDirection==direction)
                        {
                            Console.WriteLine($"{person.Surname} , {person.Passport}");
                            find = true;
                        }
                    }
                }

                if (!find)
                    Console.WriteLine("Список пассажиров на данное направление пуст");

            } 

        }

        public void ShowPassangers()
        {
            foreach(var person in Passangers)
            {
                Console.WriteLine($"{person.Surname} , {person.Passport}");
            }
        }

        public void GetSoldTicketsCost(string? surname)
        {
            bool isExist = false;

            foreach(var person in Passangers)
            {
                if (person.Surname==surname)
                {
                    int answer = 0;
                    isExist = true;
                    answer = person.GetCostOfBoughtTickets();
                    if (answer>0)
                        Console.WriteLine(answer);
                    else
                        Console.WriteLine("Данный пассажир не покупал билетов");
                }
            }

            if (!isExist)
                Console.WriteLine($"Пассажир {surname} не найден");
        }

    }
}