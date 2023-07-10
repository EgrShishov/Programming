using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab6
{
    abstract public class Shape
    {
        public Shape()
        {
            Console.WriteLine("Конструктор родительского класса был вызван");
        }

        public abstract double GetPerimetr();

        public abstract double GetSquare();


    }
}
