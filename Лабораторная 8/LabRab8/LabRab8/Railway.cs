using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab8
{
    internal class Railway
    {
        private List<Tarif> tarifsList = new List <Tarif> ();
        public void AddTarif(Tarif tarif)
        {
            tarifsList.Add(tarif);
        }

        public void SearchMinCostDirection()
        {
            double min = double.MaxValue;
            int index = 0;
            foreach (var tarif in tarifsList)
            {
                if (tarif.Price<min)
                {
                    min = tarif.Price;
                    index = tarifsList.IndexOf(tarif);
                }
            }
            Console.WriteLine($"Минимальная стоимость  : {min}, {tarifsList[index].Direction}");
        }

    }
}
