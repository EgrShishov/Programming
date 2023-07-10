using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRab8
{
    public class NoDiscountTarif : InterfacePrice
    {
        private double price;

        public double GetPrice()
        {
            return price;
        }

        public NoDiscountTarif(double price)
        {
            this.price = price;
        }
    }
}