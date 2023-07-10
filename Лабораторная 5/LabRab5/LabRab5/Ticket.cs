using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRab5
{
    public class Ticket
    {

        private int price;
        private string? travelDirection;

        private TicketType ticketType = new TicketType();
        public Ticket() { }

        public int Price
        {
            get { return price; }
            set
            {
                if(value>0) price = value;
                else price = 0;
            }
        }

        public string? TravelDirection
        {
            get { return travelDirection; }
            set
            {
                travelDirection=value;
            }
        }

        public string? TType
        {
            get
            {
                string? type;
                switch(ticketType)
                {
                    case TicketType.Express:
                        type = "Express";
                        break;
                    case TicketType.Shtadler:
                        type = "Shtadler";
                        break;
                    case TicketType.LongDistance:
                        type = "LongDistance";
                        break;
                    default:
                        type = "No information";
                        break;
                }
                return type;
            }
        }

    }
}