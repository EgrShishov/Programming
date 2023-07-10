using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab3_2
{
    internal class Func
    {
        public void y(double z)
        {
            double x, y;

            if(z>0)
            {
                x=Math.Sqrt(z);

                Console.WriteLine("Вычисление производилось по правой ветке, y = " + y);
            }
            else
            {
                x=(3*z*z*z-z)-5;

                Console.WriteLine("Вычисление производилось по левой ветке, y = " + y);
            }

            y = Math.Cos(5*x) + Math.Sin(x/5) + Math.Exp(x);


        }
    }
}
