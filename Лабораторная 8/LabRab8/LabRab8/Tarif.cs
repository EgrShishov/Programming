using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRab8
{
    public class Tarif
    {
        private string? direction;

        InterfacePrice? tarif;
        public Tarif(InterfacePrice tarif, string? direction)
        {
            this.tarif = tarif;
            this.direction = direction;
        }
        public double Price
        {
            get => tarif.GetPrice();
        }

        public string? Direction
        {
            get => direction;
            set => direction = value;
        }

    }
}