using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab4
{
    public class Railway
    {
        private static Railway? ourRailway = null;

        Ticket ticket;
        string name;
        int price;
        int sitsAmount;
        int soldTicketsAmount;

        private Railway() { }


        private Railway(String name,int price,int sitsAmount,int soldTicketsAmount)
        {
            this.name=name;
            this.price=price;
            this.sitsAmount=sitsAmount;
            this.soldTicketsAmount=soldTicketsAmount;
            this.ticket= new Ticket(price);
        }

        public static Railway setRailway(String name, int price, int sitsAmount, int soldTicketsAmount)
        {
            if (ourRailway==null)
            {
                ourRailway = new Railway(name, price, sitsAmount, soldTicketsAmount);

            }
                return ourRailway;
        }
        public int getPrice()
        {
            return ourRailway.ticket.getPrice();
        }

        public String getName()
        {
            return ourRailway.name;
        }

        public int getSitsAmount()
        {
            return ourRailway.sitsAmount;
        }

        public int getSoldTicketsAmount()
        {
            return ourRailway.soldTicketsAmount;
        }

        public int costOfUnSoldTickets()
        {
            return ourRailway.getPrice() * ( ourRailway.getSitsAmount() - ourRailway.getSoldTicketsAmount() );
        }

        public void increase(int value)
        {
            ourRailway.ticket.increase(value);
        }

        public void decrease(int value)
        {
            ourRailway.ticket.decrease(value);
        }


    }
}
