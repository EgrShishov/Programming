using System;

namespace LabRab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Railway ourRailway = new Railway();
            ourRailway.AddTarif(new Tarif(new NoDiscountTarif(1230),"Minsk-Gorki"));
            ourRailway.AddTarif(new Tarif(new NoDiscountTarif(1000),"Minsk-Zaslavl"));
            ourRailway.AddTarif(new Tarif(new NoDiscountTarif(990),"Minsk-Mstislavl"));
            ourRailway.AddTarif(new Tarif(new DiscountTarif(1000, 1), "Minsk-Grodno"));
            ourRailway.SearchMinCostDirection();
        }
    }

}
