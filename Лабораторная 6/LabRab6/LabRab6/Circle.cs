using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRab6
{
    public class Circle : Ellipse
    {
        double radius = 0;
        public double Radius
        {
            set { this.radius=value; }
            get { return this.radius; }
        }

        public override double GetPerimetr()
        {
            return Math.PI*2*Radius;
        }

        public override double GetSquare()
        {
            return Math.PI*Radius*Radius;
        }

        public new void Print()
        {
            Console.WriteLine("Наша фигура - круг");
        }

    }
}