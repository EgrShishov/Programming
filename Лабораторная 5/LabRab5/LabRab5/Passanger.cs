using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRab5
{
    public class Passanger
    {
        private string? passport;
        private List<Ticket> boughtTickets;
        private string? surname;

        public Passanger(string? surname,string? passport) 
        {
           if(boughtTickets==null) boughtTickets = new List<Ticket>();
            this.surname=surname;
            this.passport=passport;
        }

        public List <Ticket> BoughtTickets
        {
            get { return boughtTickets; }
            set { boughtTickets = value; }
        }

        public string? Passport
        {
            get {return passport;}
            set
            {
                passport=value;
            }
        }

        public string? Surname
        {
            get { return surname; }
            set
            {
                surname=value;
            }
        }

        public void BuyTicket(Ticket ticket)
        {
            boughtTickets.Add(ticket);
        }


        public int GetCostOfBoughtTickets()
        {
            int cost = 0;
            if(boughtTickets!=null)
            {
                foreach (var ticket in BoughtTickets)
                {
                    cost+=ticket.Price;
                }

            }
            return cost;
        }

    }
}