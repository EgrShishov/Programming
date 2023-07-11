using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab4
{
    public class Ticket
    {
        static int price;
        Ticket() { }

        public Ticket(int _price)
        {
            price=_price;
        }

        public int getPrice()
        {
            return price;
        }

        public void increase(int value)
        {
            price+=value;
        }

        public void decrease(int value)
        {
            price-=value;
        }


    }
}
