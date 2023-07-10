using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRab8
{

    public class DiscountTarif : InterfacePrice
    {
        private double discount, price;

        public DiscountTarif(double price, double discount)
        {
            this.discount = discount;
            this.price = price;
        }
        public double GetPrice()
        {
            return (double)(price - discount*price/100);
        }
    }
}